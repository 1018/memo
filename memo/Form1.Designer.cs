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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ﾌｧｲﾙFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNewSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.へんしゅうToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.editCut = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.editFind = new System.Windows.Forms.ToolStripMenuItem();
            this.editFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.editReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.editJump = new System.Windows.Forms.ToolStripMenuItem();
            this.editAllSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.editDate = new System.Windows.Forms.ToolStripMenuItem();
            this.format = new System.Windows.Forms.ToolStripMenuItem();
            this.formatWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.つーるTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ひょうじVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.すてーたすばーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.へるぷHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.へるぷHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ばーじょんVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.transparencyTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("あずきフォント", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(32, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(540, 283);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ﾌｧｲﾙFToolStripMenuItem,
            this.へんしゅうToolStripMenuItem,
            this.format,
            this.つーるTToolStripMenuItem,
            this.ひょうじVToolStripMenuItem,
            this.へるぷHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
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
            this.ﾌｧｲﾙFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ﾌｧｲﾙFToolStripMenuItem.Text = "File(&F)";
            // 
            // fileNew
            // 
            this.fileNew.Name = "fileNew";
            this.fileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNew.Size = new System.Drawing.Size(172, 22);
            this.fileNew.Text = "new(&N)";
            this.fileNew.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpen.Size = new System.Drawing.Size(172, 22);
            this.fileOpen.Text = "open(&O)";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSave.Size = new System.Drawing.Size(172, 22);
            this.fileSave.Text = "save(&S)";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileNewSave
            // 
            this.fileNewSave.Name = "fileNewSave";
            this.fileNewSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.fileNewSave.Size = new System.Drawing.Size(172, 22);
            this.fileNewSave.Text = "save as ..(&A)";
            this.fileNewSave.Click += new System.EventHandler(this.fileNewSave_Click);
            // 
            // fileEnd
            // 
            this.fileEnd.Name = "fileEnd";
            this.fileEnd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.fileEnd.Size = new System.Drawing.Size(172, 22);
            this.fileEnd.Text = "exit(&X)";
            this.fileEnd.Click += new System.EventHandler(this.fileEnd_Click);
            // 
            // へんしゅうToolStripMenuItem
            // 
            this.へんしゅうToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUndo,
            this.editCut,
            this.editCopy,
            this.editPaste,
            this.editFind,
            this.editFindNext,
            this.editReplace,
            this.editJump,
            this.editAllSelect,
            this.editDate});
            this.へんしゅうToolStripMenuItem.Name = "へんしゅうToolStripMenuItem";
            this.へんしゅうToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.へんしゅうToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.へんしゅうToolStripMenuItem.Text = "Edit(&E)";
            // 
            // editUndo
            // 
            this.editUndo.Name = "editUndo";
            this.editUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.editUndo.Size = new System.Drawing.Size(171, 22);
            this.editUndo.Text = "undo(&U)";
            this.editUndo.Click += new System.EventHandler(this.editUndo_Click);
            // 
            // editCut
            // 
            this.editCut.Name = "editCut";
            this.editCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.editCut.Size = new System.Drawing.Size(171, 22);
            this.editCut.Text = "cut(&C)";
            this.editCut.Click += new System.EventHandler(this.editCut_Click);
            // 
            // editCopy
            // 
            this.editCopy.Name = "editCopy";
            this.editCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editCopy.Size = new System.Drawing.Size(171, 22);
            this.editCopy.Text = "yank(&Y)";
            this.editCopy.Click += new System.EventHandler(this.editCopy_Click);
            // 
            // editPaste
            // 
            this.editPaste.Name = "editPaste";
            this.editPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editPaste.Size = new System.Drawing.Size(171, 22);
            this.editPaste.Text = "paste(&P)";
            this.editPaste.Click += new System.EventHandler(this.editPaste_Click);
            // 
            // editFind
            // 
            this.editFind.Name = "editFind";
            this.editFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.editFind.Size = new System.Drawing.Size(171, 22);
            this.editFind.Text = "find(&F)";
            this.editFind.Click += new System.EventHandler(this.editFind_Click);
            // 
            // editFindNext
            // 
            this.editFindNext.Name = "editFindNext";
            this.editFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.editFindNext.Size = new System.Drawing.Size(171, 22);
            this.editFindNext.Text = "find next(&N)";
            // 
            // editReplace
            // 
            this.editReplace.Name = "editReplace";
            this.editReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.editReplace.Size = new System.Drawing.Size(171, 22);
            this.editReplace.Text = "replace(&R)";
            this.editReplace.Click += new System.EventHandler(this.editReplace_Click);
            // 
            // editJump
            // 
            this.editJump.Name = "editJump";
            this.editJump.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.editJump.Size = new System.Drawing.Size(171, 22);
            this.editJump.Text = "goto in(&G)";
            this.editJump.Click += new System.EventHandler(this.editJump_Click);
            // 
            // editAllSelect
            // 
            this.editAllSelect.Name = "editAllSelect";
            this.editAllSelect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.editAllSelect.Size = new System.Drawing.Size(171, 22);
            this.editAllSelect.Text = "all select(&A)";
            this.editAllSelect.Click += new System.EventHandler(this.editAllSelect_Click);
            // 
            // editDate
            // 
            this.editDate.Name = "editDate";
            this.editDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.editDate.Size = new System.Drawing.Size(171, 22);
            this.editDate.Text = "time & date(&D)";
            // 
            // format
            // 
            this.format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatWordWrap});
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(69, 20);
            this.format.Text = "Format(&O)";
            // 
            // formatWordWrap
            // 
            this.formatWordWrap.Name = "formatWordWrap";
            this.formatWordWrap.Size = new System.Drawing.Size(152, 22);
            this.formatWordWrap.Text = "wrap word(&W)";
            this.formatWordWrap.Click += new System.EventHandler(this.formatWordWrap_Click);
            // 
            // つーるTToolStripMenuItem
            // 
            this.つーるTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOption,
            this.transparencyTToolStripMenuItem,
            this.settingSToolStripMenuItem});
            this.つーるTToolStripMenuItem.Name = "つーるTToolStripMenuItem";
            this.つーるTToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.つーるTToolStripMenuItem.Text = "Tool(&T)";
            // 
            // toolOption
            // 
            this.toolOption.Name = "toolOption";
            this.toolOption.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolOption.Size = new System.Drawing.Size(155, 22);
            this.toolOption.Text = "option(&O)";
            this.toolOption.Click += new System.EventHandler(this.toolOption_Click);
            // 
            // ひょうじVToolStripMenuItem
            // 
            this.ひょうじVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.すてーたすばーToolStripMenuItem});
            this.ひょうじVToolStripMenuItem.Name = "ひょうじVToolStripMenuItem";
            this.ひょうじVToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ひょうじVToolStripMenuItem.Text = "Visual(&V)";
            // 
            // すてーたすばーToolStripMenuItem
            // 
            this.すてーたすばーToolStripMenuItem.Name = "すてーたすばーToolStripMenuItem";
            this.すてーたすばーToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.すてーたすばーToolStripMenuItem.Text = "status(&S)";
            // 
            // へるぷHToolStripMenuItem
            // 
            this.へるぷHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.へるぷHToolStripMenuItem1,
            this.ばーじょんVToolStripMenuItem});
            this.へるぷHToolStripMenuItem.Name = "へるぷHToolStripMenuItem";
            this.へるぷHToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.へるぷHToolStripMenuItem.Text = "Help(&H)";
            // 
            // へるぷHToolStripMenuItem1
            // 
            this.へるぷHToolStripMenuItem1.Name = "へるぷHToolStripMenuItem1";
            this.へるぷHToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.へるぷHToolStripMenuItem1.Text = "help(&H)";
            // 
            // ばーじょんVToolStripMenuItem
            // 
            this.ばーじょんVToolStripMenuItem.Name = "ばーじょんVToolStripMenuItem";
            this.ばーじょんVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ばーじょんVToolStripMenuItem.Text = "about(&V)";
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
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(570, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // transparencyTToolStripMenuItem
            // 
            this.transparencyTToolStripMenuItem.Name = "transparencyTToolStripMenuItem";
            this.transparencyTToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.transparencyTToolStripMenuItem.Text = "transparency(&T)";
            // 
            // settingSToolStripMenuItem
            // 
            this.settingSToolStripMenuItem.Name = "settingSToolStripMenuItem";
            this.settingSToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.settingSToolStripMenuItem.Text = "setting(&S)";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.DimGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Location = new System.Drawing.Point(0, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(572, 19);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "  ....+....0....+....1....+....2....+....3....+....4....+....5....+....6....+...." +
                "7....+....8....+....9.........+.........+.........+.........+.........+........." +
                "+.........+";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.BackColor = System.Drawing.Color.DimGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(0, 24);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(34, 276);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "           1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 322);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "no title - もー帳";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem format;
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
        private System.Windows.Forms.ToolStripMenuItem editUndo;
        private System.Windows.Forms.ToolStripMenuItem editCut;
        private System.Windows.Forms.ToolStripMenuItem editFind;
        private System.Windows.Forms.ToolStripMenuItem editFindNext;
        private System.Windows.Forms.ToolStripMenuItem editReplace;
        private System.Windows.Forms.ToolStripMenuItem editJump;
        private System.Windows.Forms.ToolStripMenuItem editAllSelect;
        private System.Windows.Forms.ToolStripMenuItem editDate;
        private System.Windows.Forms.ToolStripMenuItem すてーたすばーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem へるぷHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ばーじょんVToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem editCopy;
        private System.Windows.Forms.ToolStripMenuItem editPaste;
        private System.Windows.Forms.ToolStripMenuItem つーるTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolOption;
        private System.Windows.Forms.ToolStripMenuItem formatWordWrap;
        private System.Windows.Forms.ToolStripMenuItem transparencyTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingSToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

