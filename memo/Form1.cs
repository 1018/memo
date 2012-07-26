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
            const string MSG_BOX_STRING = "ファイルは保存されていません。\n\n編集中のテキストは破棄されます。\n\nよろしいですか?";
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
            const string STATUS_STRING = "に保存しといたよ";
            
            //ステータスバー上のラベルに表示
            toolStripStatusLabel1.Text = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + STATUS_STRING;
        }

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
        /// 新規保存の場合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileNewSave_Click(object sender, EventArgs e)
        {
            //ファイルが新規作成だった場合の名前
            const string NEW_FILE_NAME = "新規テキストファイル.txt";

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
            const string MSGBOX_TITLE = "りょこ帳の終了";
            if (confirmDestructionText(MSGBOX_TITLE))
            {
                this.Close();
                this.Dispose();
            }
        } 
  

    }
}

// EOF