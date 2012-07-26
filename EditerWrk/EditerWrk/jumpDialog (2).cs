using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class jumpDialog : Form
    {
        //処理対象となる TextBox のインスタンスを保持
        private TextBox _textBox;
      
        public jumpDialog()
        {
            InitializeComponent();
        }

        public jumpDialog(TextBox txtBox)
        {
            InitializeComponent();
            _textBox = txtBox;
        }

#region EventHandlers //イベントハンドラ

        //ダイアログボックスのロード
        private void jumpDialog_Load(object sender, EventArgs e)
        {
            lineNumTextBox.Text = GetCurrntLineNumber().ToString();
            lineNumTextBox.SelectAll();
            lineNumTextBox.Focus();
        }

        //[キャンセル] ボタンのクリック
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        //[OK] ボタンのクリック
        private void okButton_Click(object sender, EventArgs e)
        {
            const string MSG_INVALID_LINE = "行番号が範囲外です。";
            string[] lineArray = _textBox.Text.Split('\n');
            int jumpPoint = int.Parse(lineNumTextBox.Text) - 1;
            int lineCount = lineArray.Length;
            int lastLength = 0;
            if (lineCount < jumpPoint)
            {
                MessageBox.Show(MSG_INVALID_LINE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            StringBuilder stringBld = new StringBuilder();
            for (int i = 0; jumpPoint >= i; i++)
            {
                lastLength = lineArray[i].Length;
                stringBld.Append(lineArray[i]);
            }
            _textBox.SelectionStart = stringBld.ToString().Length - (lastLength - jumpPoint);
            _textBox.Focus();
            this.Close();
            this.Dispose();
        }
#endregion

#region property //プロパティ

        //処理対象となる TextBox のインスタンス設定するためのプロパティ
        public TextBox textBox
        {
            get { return _textBox; }
            set { _textBox = value; }
        }
#endregion

        
        private int GetCurrntLineNumber()
        {
            int currentPoint = _textBox.SelectionStart;
            string editString = _textBox.Text.Substring(0, currentPoint);
            return editString.Split('\n').Length;
        }
        

    }
}
