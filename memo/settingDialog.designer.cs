namespace memo
{
    partial class settingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FontButton = new System.Windows.Forms.Button();
            this.BgColorButton = new System.Windows.Forms.Button();
            this.PreViewTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(183, 259);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(77, 26);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(266, 259);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(77, 26);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "適用";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(349, 259);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(77, 26);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ResetButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.FontButton);
            this.tabPage1.Controls.Add(this.BgColorButton);
            this.tabPage1.Controls.Add(this.PreViewTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "色とフォント";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(311, 133);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(83, 25);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "リセット(&R)";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "プレビュー(&P):";
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(311, 91);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(84, 24);
            this.FontButton.TabIndex = 2;
            this.FontButton.Text = "フォント(&F)...";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // BgColorButton
            // 
            this.BgColorButton.Location = new System.Drawing.Point(311, 47);
            this.BgColorButton.Name = "BgColorButton";
            this.BgColorButton.Size = new System.Drawing.Size(84, 24);
            this.BgColorButton.TabIndex = 1;
            this.BgColorButton.Text = "背景色(&B)...";
            this.BgColorButton.UseVisualStyleBackColor = true;
            this.BgColorButton.Click += new System.EventHandler(this.BgColorButton_Click);
            // 
            // PreViewTextBox
            // 
            this.PreViewTextBox.Location = new System.Drawing.Point(20, 47);
            this.PreViewTextBox.Multiline = true;
            this.PreViewTextBox.Name = "PreViewTextBox";
            this.PreViewTextBox.ReadOnly = true;
            this.PreViewTextBox.Size = new System.Drawing.Size(276, 124);
            this.PreViewTextBox.TabIndex = 0;
            this.PreViewTextBox.Text = "12345\r\nabcde\r\nABCDE\r\nｱｲｳｴｵ\r\nアイウエオ\r\nあいうえお";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 241);
            this.tabControl1.TabIndex = 0;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // settingDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 294);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "settingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "アブリレーションの設定";
            this.Load += new System.EventHandler(this.settingDialog_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox PreViewTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.Button BgColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button ResetButton;
    }
}