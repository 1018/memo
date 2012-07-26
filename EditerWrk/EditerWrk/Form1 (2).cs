//本サンプルは Windows アプリケーションの作成手順を説明するためのものであり、その動作を保証するものではありません。 
//ご使用の際には、用途に合わせて修正して頂き、十分なテストを実施して頂きます様お願いします。 
//サンプル内で使用しておりますAPI などの詳細な情報に関しては、MSDN 、PlatformSDK などをご参照ください。

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool dirtyFlag = false; 　 //ダーティーフラグ
        private bool readOnlyFlag = false; //読み取り専用フラグ
        private string editFilePath = "";  //編集中のファイルのパス

        findDialog findDlg = null;  //検索ダイアログボックスのインスタンスを格納

        //追加ぶん
        jumpDialog jumpDlg = null; //ジャンプダイアログボックスのインスタンスを格納

        public Form1()
        {
            InitializeComponent();
        }

//フォームのイベントハンドラ
#region Form_handlers
        //フォームロード時のイベント
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }

        //フォームクロージングのイベントハンドラ
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string MSGBOX_TITLE = "アプリケーションの終了";
            if (confirmDestructionText(MSGBOX_TITLE))
            {
                SaveSetting();
                this.Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
#endregion

//[ファイル(&F)]メニュー関連のイベントハンドラ
#region FileMenu handlers

        //[新規作成]メニューの処理
        private void menuNew_Click(object sender, EventArgs e)
        {
            const string MSG_BOX_TITLE = "ファイルの新規作成";
            if (confirmDestructionText(MSG_BOX_TITLE)) //編集中のテキストがないか確認
            {
                this.Text = "無題";     //アプリケーションのタイトルを変更
                textBox1.Clear();       //テキストボックスの内容をクリア
                editFilePath = "";      //編集中ファイルのパスをクリア
                setDirty(false);        //ダーティーフラグと[上書き..]メニューを設定
            }
        }

    
        //[上書き保存] メニューの処理
        private void menuSave_Click(object sender, EventArgs e)
        {
            const string MSGBOX_TITLE = "ファイルの上書き保存";

            //保存先のファイルが存在するかチェック
            if (File.Exists(editFilePath))
            {
                try
                {
                    //テキストボックスの内容をファイルに書き込み
                    File.WriteAllText(editFilePath, textBox1.Text,Encoding.Default);
                    setDirty(false);

                    //ステータスバーに保存日時を表示
                    ShowSaveDateTime();
                }
                catch (Exception ex)
                {
                    //ファイルの書き込みでエラーが発生した場合に Exception の内容を表示
                    MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string MSG_BOX_STRING = "ファイル\"" + editFilePath
                     + "\" のパスは正しくありません。\n\nディレクトリが存在するか確認してください。";
                MessageBox.Show(MSG_BOX_STRING, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //[名前をつけて保存]メニューの処理
        private void menuSaveAdd_Click(object sender, EventArgs e)
        {
            //ファイルが新規作成だった場合の名前
            const string NEW_FILE_NAME = "新規テキストファイル.txt";

            //編集中のファイルのフルパスからファイル名だけを取得
            string fileNameString = GetFileNameString(editFilePath, '\\');

            //ファイル名が空白であった場合は　"新規テキストファイル.txt" をセット
            saveFileDlg.FileName = (fileNameString == "") ? NEW_FILE_NAME : fileNameString;
            saveFileDlg.ShowDialog(this);
        }

        //[終了] メニューの処理
        private void menuEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            openFileDlg.ShowDialog(this);
        }

        //ファイルを開く処理
        private void openFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            const string TITLE_EXTN_ReadOnly = " (読み取り専用)";
            const string MSGBOX_TITLE = "ファイル オープン";

            //選択されたファイルのパスを取得
            editFilePath = openFileDlg.FileName;

            //ファイルダイアログで読み取り専用が選択されたかどうかの値を取得
            readOnlyFlag = openFileDlg.ReadOnlyChecked;

            //読み取り専用で開いた場合にタイトル(ファイル名)に "読み取り専用" の文字をつける
            this.Text = (readOnlyFlag)
                 ? openFileDlg.SafeFileName + TITLE_EXTN_ReadOnly : openFileDlg.SafeFileName;

            //ダーティーフラグのリセット
            setDirty(false);

            try
            {
                //テキストファイルの内容をテキストボックスにロード
                textBox1.Text = File.ReadAllText(editFilePath, Encoding.Default);
            }
            catch (Exception ex)
            {
                //ファイルの読み込みでエラーが発生した場合に Exception の内容を表示
                MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ファイルを保存する処理
        private void saveFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            const string MSGBOX_TITLE = "名前を付けて保存";

            //ファイルダイアログで指定された保存先パスを取得
            editFilePath = saveFileDlg.FileName;
            try
            {
                //ファイルの書き込み
                File.WriteAllText(editFilePath, textBox1.Text, Encoding.Default);

                //ファイル名をウィンドウのタイトルに設定
                this.Text = GetFileNameString(editFilePath, '\\');

                //ダーティーフラグのリセット
                setDirty(false);

                //ステータスバーに保存日時を表示
                ShowSaveDateTime();
            }
            catch (Exception ex)
            {
                //エラー発生の際に Exception の内容を表示
                MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
#endregion

//[編集(&E)]メニュー関連のイベントハンドラ
#region EditMenu handlers

        //[元に戻す]メニューの処理
        private void menuUndo_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        //[切り取り]メニューの処理
        private void menuCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "") textBox1.Cut(); 
        }

        //[コピー]メニューの処理
        private void menuCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "") textBox1.Copy();
        }

        //[貼り付け]メニューの処理
        private void menuPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)) 
                textBox1.Paste();
        }

        //[削除]メニューの処理
        private void menuDelete_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
            Clipboard.Clear();
        }

        //[全て選択] メニューの処理
        private void menuAllSelect_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

/*
        //[検索] メニューの処理
        private void menuFind_Click(object sender, EventArgs e)
        {

            //二重起動を防止
            if (findDlg == null || findDlg.IsDisposed)
            {
                //検索ダイアログボックス用フォームのインスタンスを生成
                findDlg = new findDialog(dialogMode.Find, textBox1);
                //検索ダイアログボックスを表示
                findDlg.Show(this);
            }
        }

        //[置換] メニューの処理
        private void menuReplace_Click(object sender, EventArgs e)
        {
            //二重起動を防止
            if (findDlg == null || findDlg.IsDisposed)
            {
                //検索ダイアログボックス用フォームのインスタンスを生成
                findDlg = new findDialog(dialogMode.Replace, textBox1);
                findDlg.Show(this);
            }
        }
 */
        //[検索]と[置換]メニューの処理をひとまとめにしたもの
        private void menuFindReplace(object sender, EventArgs e)
        {
            //二重起動を防止
            if (findDlg == null || findDlg.IsDisposed)
            {
                //検索ダイアログボックス用フォームのインスタンスを生成
                findDlg = new findDialog((((ToolStripMenuItem)sender).Name == "menuFind") ? dialogMode.Find : dialogMode.Replace, textBox1);
                findDlg.Show(this);
            }
        }

        //[行へ移動] メニューの処理
        private void menuJump_Click(object sender, EventArgs e)
        {
            if (jumpDlg == null || jumpDlg.IsDisposed)
            {
                jumpDlg = new jumpDialog(textBox1);
                jumpDlg.ShowDialog(this);
            }
        }

#endregion

        //[書式(&O)] メニュー関連のイベントハンドラ
#region FormatMenu
        //[右側で折り返す] メニューの処理
        private void menuWordWrap_Click(object sender, EventArgs e)
        {
            bool wWrapFlag = !menuWordWrap.Checked;
            menuWordWrap.Checked = wWrapFlag;
            menuJump.Enabled = !wWrapFlag;
            textBox1.WordWrap = wWrapFlag;
        }
#endregion

        //[ツール(&T)] メニュー関連のイベントハンドラ
#region ToolMenu handlers
        private void menuOption_Click(object sender, EventArgs e)
        {
            //設定用ダイアログのインスタンスを生成
            //コンストラクタに対象となる TextBox のインスタンスを渡す
            settingDialog settinfDlg = new settingDialog(textBox1);
            settinfDlg.ShowDialog(this);
        }
#endregion

//その他のイベントハンドラ
#region Other Event handler

        //テキストボックスの内容が変更された際に発生するイベント
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            setDirty(true);
        }
#endregion


//関数など
#region Functions

        //ダーティーフラグの設定
        private void setDirty(bool flag)
        {
            dirtyFlag = flag;
            //読み取り専用でファイルがオープンされている場合、新規作成の場合
            //[上書き(&S)] メニューアイテムは常に無効
            menuSave.Enabled = (readOnlyFlag || editFilePath == "") ? false : flag;
        }

        //保存していない編集中のテキストがある場合に確認するための関数
        private bool confirmDestructionText(string msgboxTitle)
        {
            const string MSG_BOX_STRING = "ファイルは保存されていません。\n\n編集中のテキストは破棄されます。\n\nよろしいですか?";
            if (!dirtyFlag) return true;
            return (MessageBox.Show(MSG_BOX_STRING, msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        //フルパスからファイル名のみを取り出す関数
        private string GetFileNameString(string filePath, char separateChar)
        {
            try
            {
                string[] strArray = filePath.Split(separateChar);
                return strArray[strArray.Length - 1];
            }
            catch
            { return ""; }
        }

        //ステータスバーに保存日時を表示
        private void ShowSaveDateTime()
        {
            const string STATUS_STRING = "に保存しました";
            //ステータスバー上のラベルに表示
            toolStripStatusLabel1.Text = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + STATUS_STRING;
        }

        //状態の取り出し
        private void LoadSetting()
        {
            //ユーザーにより値が設定されないうちはアプリケーション情報をロードしない
            if (Properties.Settings.Default.Initialized)
            {
                this.Height = Properties.Settings.Default.Height;
                this.Width = Properties.Settings.Default.Width;
                this.Top = Properties.Settings.Default.Top;
                this.Left = Properties.Settings.Default.Left;
                textBox1.Font = Properties.Settings.Default.Font;
                textBox1.BackColor = Properties.Settings.Default.BackGroundColor;
                textBox1.ForeColor = Properties.Settings.Default.ForeColor;
                bool wWrapFlg = Properties.Settings.Default.WordWrap;
                textBox1.WordWrap = wWrapFlg;
                menuWordWrap.Checked = wWrapFlg;
                menuJump.Enabled = (!wWrapFlg);
            }
        }

        ///状態の保存
        private void SaveSetting()
        {
            Properties.Settings.Default["Height"] = this.Height;
            Properties.Settings.Default["Width"] = this.Width;
            Properties.Settings.Default["Top"] = this.Top;
            Properties.Settings.Default["Left"] = this.Top;
            Properties.Settings.Default["Font"] = textBox1.Font;
            Properties.Settings.Default["BackGroundColor"] = textBox1.BackColor;
            Properties.Settings.Default["WordWrap"] = textBox1.WordWrap;
            Properties.Settings.Default["Initialized"] = true;
            Properties.Settings.Default.Save();
        } 

#endregion

       

        
       
        

        

    }
}
