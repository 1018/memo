using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace memo
{
    public partial class Form1 : Form
    {
        private bool dirtyFlag = false; 　      //ダーティーフラグ 
        private bool readOnlyFlag = false;  //読み取り専用フラグ
        private string editFilePath = "";      //編集中のファイルのパス

        findDialog findDlg = null; //検索ダイアログボックスのインスタンスを格納        
        jumpDialog jumpDlg = null; //ジャンプダイアログボックスのインスタンスを格納
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新規作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileNew_Click(object sender, EventArgs e)
        {
            const string MSG_BOX_TITLE = "新規作成";     //編集中のテキストがないか確認
            if (confirmDestructionText(MSG_BOX_TITLE))
            {
                this.Text = "new file"; //アプリケーションのタイトルを変更
                textBox1.Clear();　　　　　 //テキストボックスの内容をクリア
                editFilePath = ""; 　         //編集中ファイルのパスをクリア
                setDirty(false);               //ダーティーフラグと[上書き..]メニューを設定
            }
        }


        /// <summary>
        /// ダーティーフラグと [上書き(&S)] メニューアイテム有効/無効の処理
        /// </summary>
        /// <param name="flag"></param>
        private void setDirty(bool flag)
        {
            dirtyFlag = flag;
            //読み取り専用でファイルがオープンされている場合、
            //[上書き(&S)] メニューアイテムは常に無効
            fileSave.Enabled = (readOnlyFlag) ? false : flag;
        }
        
        
        /// <summary>
        /// 保存していない編集中のテキストがある場合に確認
        /// </summary>
        /// <param name="msgboxTitle"></param>
        /// <returns></returns>
        private bool confirmDestructionText(string msgboxTitle)
        {
            const string MSG_BOX_STRING = "今のファイルはすてちゃうけど\n\nよかかにょ?";
            if (!dirtyFlag) return true;
            
            return (MessageBox.Show(MSG_BOX_STRING, msgboxTitle, 
                　　MessageBoxButtons.YesNo, 
                  　MessageBoxIcon.Question) == DialogResult.Yes);
        }

        /// <summary>
        /// 開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileOpen_Click(object sender, EventArgs e)
        {
            openFileDlg.ShowDialog(this);
        }

        /// <summary>
        /// file開くﾀﾞｲｱﾛｸﾞでのOK時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            const string TITLE_EXTN_ReadOnly = " (読み取り専用)";
            const string MSGBOX_TITLE = "file open";

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

        
        /// <summary>
        /// ステータスバーに保存日時を表示する関数
        /// </summary>
        private void ShowSaveDateTime()
        {
            const string STATUS_STRING = "に、もー帳で保存したよ";
            
            //ステータスバー上のラベルに表示
            toolStripStatusLabel1.Text = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + STATUS_STRING;
        }


        /// <summary>
        /// 上書き保存できるように
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ダーティーフラグを設定
            setDirty(true);
        } 

        /// <summary>
        /// ﾌｧｲﾙ保存OKｸﾘｯｸ時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileSave_Click(object sender, EventArgs e)
        {
            const string MSGBOX_TITLE = "うわがきするよ";

            //保存先のファイルが存在するかチェック
            if (File.Exists(editFilePath))
            {
                try
                {
                    //テキストボックスの内容をファイルに書き込み
                    File.WriteAllText(editFilePath, textBox1.Text, Encoding.Default);

                    //ダーティーフラグをリセット
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

        /// <summary>
        /// 新規保存の場合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileNewSave_Click(object sender, EventArgs e)
        {
            //ファイルが新規作成だった場合の名前
            const string NEW_FILE_NAME = "もーnew.txt";

            //編集中のファイルのフルパスからファイル名だけを取得
            string fileNameString = GetFileNameString(editFilePath, '\\');

            //ファイル名が空白であった場合は　"新規テキストファイル.txt" をセット
            saveFileDlg.FileName = (fileNameString == "")
                 ? NEW_FILE_NAME : fileNameString;
            saveFileDlg.ShowDialog(this);
        }


        /// <summary>
        /// ﾌﾙﾊﾟｽからﾌｧｲﾙ名だけ取得
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="separateChar"></param>
        /// <returns></returns>
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

        private void fileEnd_Click(object sender, EventArgs e)
        {
            const string MSGBOX_TITLE = "も-帳の終了";
            if (confirmDestructionText(MSGBOX_TITLE))
            {
                this.Close();
                this.Dispose();
            }
        }

        // 元に戻す
        private void editUndo_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo) //元に戻すことが可能であれば
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }


        //[編集(&E)]メニュー関連のイベントハンドラ
        #region EditMenu handlers

        // 切り取り
        private void editCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "") textBox1.Cut();        
        }

        // コピー
        private void editCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "") textBox1.Copy();
        }

        // 貼り付け
        private void editPaste_Click(object sender, EventArgs e)
        {
            //クリップボードの内容がテキストで扱えるのであれば貼り付けを
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                textBox1.Paste();
        }

        // すべて選択
        private void editAllSelect_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }


        #endregion

        // 検索
        private void editFind_Click(object sender, EventArgs e)
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

        // 置き換え
        private void editReplace_Click(object sender, EventArgs e)
        {
            //二重起動を防止
            if (findDlg == null || findDlg.IsDisposed)
            {
                //検索ダイアログボックス用フォームのインスタンスを生成
                findDlg = new findDialog(dialogMode.Replace, textBox1);
                findDlg.Show(this);
            }
        }

        private void toolOption_Click(object sender, EventArgs e)
        {
            settingDialog settinfDlg = new settingDialog(textBox1);
            settinfDlg.ShowDialog(this);
        }

        /// <summary>
        /// フォームロード時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();
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
                textBox3.Font = Properties.Settings.Default.Font;

                textBox1.BackColor = Properties.Settings.Default.BackGroundColor;
                textBox1.ForeColor = Properties.Settings.Default.ForeColor;
                bool wWrapFlg = Properties.Settings.Default.WordWrap;
                textBox1.WordWrap = wWrapFlg;
                format.Checked = wWrapFlg;
                editJump.Enabled = (!wWrapFlg);
            }
        }

        /// <summary>
        /// アプリケーション情報の読み出しと保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string MSGBOX_TITLE = "もー帳の終了";
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

        #region FormatMenu
        private void formatWordWrap_Click(object sender, EventArgs e)
        {
            bool wWrapFlag = !formatWordWrap.Checked;
            formatWordWrap.Checked = wWrapFlag;
            editJump.Enabled = !wWrapFlag;
            textBox1.WordWrap = wWrapFlag;
        }
        #endregion

        //[行へ移動] メニューの処理
        private void editJump_Click(object sender, EventArgs e)
        {
            if (jumpDlg == null || jumpDlg.IsDisposed)
            {
                jumpDlg = new jumpDialog(textBox1);
                jumpDlg.ShowDialog(this);
            }
        }

        /// <summary>
        /// Drag&Dropでファイルを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] dlagFilePathArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //複数のファイルがドラックされた場合、パスが配列として取得されるが、
            //今回のアプリケーションは TextBox が 1 つしかないため、先頭の
            //ファイルのみを扱う
            string filePath = dlagFilePathArray[0];

            //ファイルがテキスト形式でオープン可能なものかどうか確認
            if (CheckFileType(filePath))
            {
                //ファイルの内容を TextBox にロード
                textBox1.Text = File.ReadAllText(filePath, Encoding.Default);

                //フォームのタイトル部分にファイル名を表示
                this.Text = GetFileNameString(filePath, '\\');
                editFilePath = filePath;
                setDirty(false);
            }

        }

        //ドロップファイルがオープン可能なものであるかどうかをチェックする関数
        private bool CheckFileType(string filePath)
        {
            //読み込みを許可するファイルの拡張子を指定 (app.config に定義した方が本当は便利)
            string[] extnArray = { "txt", "cs", "vb", "htm", "html", "xml", "csv", "js", "vbs", "wsh","cpp","c" };
            foreach (string extn in extnArray)
            {
                int dotLen = extn.Length;
                if (extn == filePath.Substring(filePath.Length - dotLen, dotLen))
                {
                    return true;
                }
            }
            return false;
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            　//ドラッグされたのがファイルであるか確認
　           if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //ドラッグされたデータを受け取る
                e.Effect = DragDropEffects.All;
            }
            else
            {
                //ドラッグされたデータを受け取らない
                e.Effect = DragDropEffects.None;
            }

        }


        /// <summary>
        /// 論理行番号を表示する
        /// </summary>
        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //文字列
                string str = textBox1.Text;
                //カレットの位置を取得
                int selectPos = textBox1.SelectionStart;

                //カレットの位置までの行を数える
                int row = 1, startPos = 0;
                for (int endPos = 0;
                    (endPos = str.IndexOf('\n', startPos)) < selectPos && endPos > -1;
                    row++)
                {
                    startPos = endPos + 1;
                }               
 
                this.textBox3.AppendText(row.ToString() + "\r\n");                   

            }

        }















    }
}

// EOF