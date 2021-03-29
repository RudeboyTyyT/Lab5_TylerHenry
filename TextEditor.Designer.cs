
namespace Lab5_TylerHenry
{
    partial class textEditor
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
            this.components = new System.ComponentModel.Container();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxTextEditor = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(800, 28);
            this.menuTop.TabIndex = 1;
            this.menuTop.Text = "menuStrip2";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileClose,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Contains options regaurding file operations";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(181, 26);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "Clears current file and opens a new one";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(181, 26);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Open a saved file";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(181, 26);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Save current text entered";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(224, 26);
            this.menuFileSaveAs.Text = "Save &As";
            this.menuFileSaveAs.ToolTipText = "Save text as new file";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(224, 26);
            this.menuFileClose.Text = "Close";
            this.menuFileClose.ToolTipText = "Closes form";
            this.menuFileClose.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(181, 26);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.ToolTipText = "Exits form";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCopy,
            this.menuEditCut,
            this.menuEditPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(49, 24);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.ToolTipText = "Options regaurding editing text";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(224, 26);
            this.menuEditCopy.Text = "&Copy ";
            this.menuEditCopy.ToolTipText = "Copy the highlighted text";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(224, 26);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.ToolTipText = "Cut and copy highlighted text";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(224, 26);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Paste copied text";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(55, 24);
            this.menuHelp.Text = "&Help";
            this.menuHelp.ToolTipText = "Gives information about the form";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(224, 26);
            this.menuHelpAbout.Text = "A&bout";
            this.menuHelpAbout.ToolTipText = "Shows information about the form";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // textBoxTextEditor
            // 
            this.textBoxTextEditor.Location = new System.Drawing.Point(0, 31);
            this.textBoxTextEditor.Multiline = true;
            this.textBoxTextEditor.Name = "textBoxTextEditor";
            this.textBoxTextEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTextEditor.Size = new System.Drawing.Size(800, 420);
            this.textBoxTextEditor.TabIndex = 2;
            // 
            // textEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTextEditor);
            this.Controls.Add(this.menuTop);
            this.Name = "textEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor Select a File to Open";
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.TextBox textBoxTextEditor;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

