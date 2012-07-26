namespace memo
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ﾌｧｲﾙFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNewSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.へんしゅうToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.しょしきOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ひょうじVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.へるぷHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 273);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ﾌｧｲﾙFToolStripMenuItem,
            this.へんしゅうToolStripMenuItem,
            this.しょしきOToolStripMenuItem,
            this.ひょうじVToolStripMenuItem,
            this.へるぷHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ﾌｧｲﾙFToolStripMenuItem
            // 
            this.ﾌｧｲﾙFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNew,
            this.fileOpen,
            this.fileSave,
            this.fileNewSave,
            this.fileEnd});
            this.ﾌｧｲﾙFToolStripMenuItem.Name = "ﾌｧｲﾙFToolStripMenuItem";
            this.ﾌｧｲﾙFToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ﾌｧｲﾙFToolStripMenuItem.Text = "ふぁいる(&F)";
            // 
            // fileNew
            // 
            this.fileNew.Name = "fileNew";
            this.fileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNew.Size = new System.Drawing.Size(192, 22);
            this.fileNew.Text = "しんき(&N)";
            this.fileNew.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpen.Size = new System.Drawing.Size(192, 22);
            this.fileOpen.Text = "ひらく(&O)";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSave.Size = new System.Drawing.Size(192, 22);
            this.fileSave.Text = "うわがき(&S)";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileNewSave
            // 
            this.fileNewSave.Name = "fileNewSave";
            this.fileNewSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.fileNewSave.Size = new System.Drawing.Size(192, 22);
            this.fileNewSave.Text = "なまえをつけて!(&A)";
            this.fileNewSave.Click += new System.EventHandler(this.fileNewSave_Click);
            // 
            // fileEnd
            // 
            this.fileEnd.Name = "fileEnd";
            this.fileEnd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.fileEnd.Size = new System.Drawing.Size(192, 22);
            this.fileEnd.Text = "しゅうりょう(&X)";
            this.fileEnd.Click += new System.EventHandler(this.fileEnd_Click);
            // 
            // へんしゅうToolStripMenuItem
            // 
            this.へんしゅうToolStripMenuItem.Name = "へんしゅうToolStripMenuItem";
            this.へんしゅうToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.へんしゅうToolStripMenuItem.Text = "へんしゅう(&E)";
            // 
            // しょしきOToolStripMenuItem
            // 
            this.しょしきOToolStripMenuItem.Name = "しょしきOToolStripMenuItem";
            this.しょしきOToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.しょしきOToolStripMenuItem.Text = "しょしき(&O)";
            // 
            // ひょうじVToolStripMenuItem
            // 
            this.ひょうじVToolStripMenuItem.Name = "ひょうじVToolStripMenuItem";
            this.ひょうじVToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ひょうじVToolStripMenuItem.Text = "ひょうじ(&V)";
            // 
            // へるぷHToolStripMenuItem
            // 
            this.へるぷHToolStripMenuItem.Name = "へるぷHToolStripMenuItem";
            this.へるぷHToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.へるぷHToolStripMenuItem.Text = "へるぷ(&H)";
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "テキストファイル (*.txt)|*.txt|C++ ソース(*.cpp)|*.cpp|全てのファイル (*.*)|*.*";
            this.openFileDlg.Title = "ひらく";
            this.openFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDlg_FileOk);
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Filter = "テキストファイル (*.txt)|*.txt|C++ ソース(*.cpp)|*.cpp|全てのファイル (*.*)|*.*";
            this.saveFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDlg_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(423, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 294);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "no title";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ﾌｧｲﾙFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem へんしゅうToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem しょしきOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ひょうじVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem へるぷHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNew;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileNewSave;
        private System.Windows.Forms.ToolStripMenuItem fileEnd;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

