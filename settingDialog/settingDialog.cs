using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class settingDialog : Form
    {
        //処理対象となる TextBox のインスタンスを保持
        private TextBox _textBox;


        public settingDialog()
        {
            InitializeComponent();
        }

        public settingDialog(TextBox txtBox)
        {
            InitializeComponent();
            _textBox = txtBox;
        }




#region property //プロパティ

        //処理対象となる TextBox のインスタンス設定するためのプロパティ
        public TextBox textBox
        {
            get { return _textBox; }
            set { _textBox = value; }
        }
#endregion


#region EventHandlers //イベントハンドラ

        //ダイアログボックスのロード
        private void settingDialog_Load(object sender, EventArgs e)
        {
            PreViewTextBox.ForeColor = _textBox.ForeColor;
            PreViewTextBox.BackColor = _textBox.BackColor;
            PreViewTextBox.Font = _textBox.Font;
        }

        //[フォント] ボタンのクリック
        private void FontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Color = PreViewTextBox.ForeColor;
            fontDialog1.Font = PreViewTextBox.Font;
            fontDialog1.ShowDialog(this);
            PreViewTextBox.Font = fontDialog1.Font;
            PreViewTextBox.ForeColor = fontDialog1.Color;
            
        }

        //[背景色] ボタンのクリック
        private void BgColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = PreViewTextBox.BackColor;
            colorDialog1.ShowDialog(this);
            PreViewTextBox.BackColor = colorDialog1.Color;
        }

        //[適用] ボタンのクリック
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        //[キャンセル] ボタンのクリック
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();  
        }

        //[OK] ボタンのクリック
        private void OKButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
            this.Dispose();
        }

        //[リセット] ボタンのクリック
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            PreViewTextBox.Font = Properties.Settings.Default.Font;
            PreViewTextBox.ForeColor = Properties.Settings.Default.ForeColor;
            PreViewTextBox.BackColor = Properties.Settings.Default.BackGroundColor;
        }
#endregion

        //ダイアログでの設定を保存
        private void SaveSettings()
        {
            _textBox.Font = PreViewTextBox.Font;
            _textBox.BackColor = PreViewTextBox.BackColor;
            _textBox.ForeColor = PreViewTextBox.ForeColor;
            Properties.Settings.Default["Font"] = PreViewTextBox.Font;
            Properties.Settings.Default["BackGroundColor"] = PreViewTextBox.BackColor;
            Properties.Settings.Default["ForeColor"] = PreViewTextBox.ForeColor;
            Properties.Settings.Default.Save();
        }

       

    }
}
