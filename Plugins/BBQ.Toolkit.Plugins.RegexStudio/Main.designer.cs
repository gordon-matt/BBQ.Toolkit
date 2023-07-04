using System.Windows.Forms;
using BBQ.Toolkit.Plugins.RegexStudio.Controls;
using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.RegexStudio
{
    partial class Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPattern = new Krypton.Toolkit.KryptonTextBox();
            this.grpPattern = new System.Windows.Forms.GroupBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.cbCompiled = new Krypton.Toolkit.KryptonCheckBox();
            this.cbIgnorePatternWS = new Krypton.Toolkit.KryptonCheckBox();
            this.cbRightToLeft = new Krypton.Toolkit.KryptonCheckBox();
            this.cbECMAScript = new Krypton.Toolkit.KryptonCheckBox();
            this.cbExplicitCapture = new Krypton.Toolkit.KryptonCheckBox();
            this.cbSingleline = new Krypton.Toolkit.KryptonCheckBox();
            this.cbMultiline = new Krypton.Toolkit.KryptonCheckBox();
            this.cbIgnoreCase = new Krypton.Toolkit.KryptonCheckBox();
            this.btnFindMatches = new Krypton.Toolkit.KryptonButton();
            this.grpReplacementString = new System.Windows.Forms.GroupBox();
            this.txtReplacementString = new Krypton.Toolkit.KryptonTextBox();
            this.btnReplace = new Krypton.Toolkit.KryptonButton();
            this.pnlTop = new Krypton.Toolkit.KryptonPanel();
            this.btnShowCSharpCode = new Krypton.Toolkit.KryptonButton();
            this.txtOutput = new Krypton.Toolkit.KryptonTextBox();
            this.splitContainerOutput = new System.Windows.Forms.SplitContainer();
            this.tvOutput = new BBQ.Toolkit.Plugins.RegexStudio.Controls.MatchTreeView();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.rTxtInput = new Krypton.Toolkit.KryptonRichTextBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.grpPattern.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpReplacementString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOutput)).BeginInit();
            this.splitContainerOutput.Panel1.SuspendLayout();
            this.splitContainerOutput.Panel2.SuspendLayout();
            this.splitContainerOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPattern
            // 
            this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPattern.Location = new System.Drawing.Point(8, 22);
            this.txtPattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPattern.Multiline = true;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPattern.Size = new System.Drawing.Size(536, 63);
            this.txtPattern.TabIndex = 0;
            this.txtPattern.Text = "Project(?<value>(?:(?!Project).)*)EndProject";
            // 
            // grpPattern
            // 
            this.grpPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPattern.Controls.Add(this.txtPattern);
            this.grpPattern.Location = new System.Drawing.Point(4, 3);
            this.grpPattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPattern.Name = "grpPattern";
            this.grpPattern.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPattern.Size = new System.Drawing.Size(555, 98);
            this.grpPattern.TabIndex = 0;
            this.grpPattern.TabStop = false;
            this.grpPattern.Text = "Pattern";
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.cbCompiled);
            this.grpOptions.Controls.Add(this.cbIgnorePatternWS);
            this.grpOptions.Controls.Add(this.cbRightToLeft);
            this.grpOptions.Controls.Add(this.cbECMAScript);
            this.grpOptions.Controls.Add(this.cbExplicitCapture);
            this.grpOptions.Controls.Add(this.cbSingleline);
            this.grpOptions.Controls.Add(this.cbMultiline);
            this.grpOptions.Controls.Add(this.cbIgnoreCase);
            this.grpOptions.Location = new System.Drawing.Point(565, 3);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpOptions.Size = new System.Drawing.Size(281, 162);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // cbCompiled
            // 
            this.cbCompiled.Checked = true;
            this.cbCompiled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCompiled.Location = new System.Drawing.Point(141, 125);
            this.cbCompiled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCompiled.Name = "cbCompiled";
            this.cbCompiled.Size = new System.Drawing.Size(76, 20);
            this.cbCompiled.TabIndex = 7;
            this.cbCompiled.Values.Text = "Compiled";
            // 
            // cbIgnorePatternWS
            // 
            this.cbIgnorePatternWS.Location = new System.Drawing.Point(141, 91);
            this.cbIgnorePatternWS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIgnorePatternWS.Name = "cbIgnorePatternWS";
            this.cbIgnorePatternWS.Size = new System.Drawing.Size(123, 20);
            this.cbIgnorePatternWS.TabIndex = 5;
            this.cbIgnorePatternWS.Values.Text = "Ignore Pattern WS";
            this.cbIgnorePatternWS.CheckedChanged += new System.EventHandler(this.cbNonECMAOptions_CheckedChanged);
            // 
            // cbRightToLeft
            // 
            this.cbRightToLeft.Location = new System.Drawing.Point(141, 58);
            this.cbRightToLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRightToLeft.Name = "cbRightToLeft";
            this.cbRightToLeft.Size = new System.Drawing.Size(93, 20);
            this.cbRightToLeft.TabIndex = 3;
            this.cbRightToLeft.Values.Text = "Right To Left";
            this.cbRightToLeft.CheckedChanged += new System.EventHandler(this.cbNonECMAOptions_CheckedChanged);
            // 
            // cbECMAScript
            // 
            this.cbECMAScript.Location = new System.Drawing.Point(141, 24);
            this.cbECMAScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbECMAScript.Name = "cbECMAScript";
            this.cbECMAScript.Size = new System.Drawing.Size(91, 20);
            this.cbECMAScript.TabIndex = 1;
            this.cbECMAScript.Values.Text = "ECMA Script";
            this.cbECMAScript.CheckedChanged += new System.EventHandler(this.cbECMAScript_CheckedChanged);
            // 
            // cbExplicitCapture
            // 
            this.cbExplicitCapture.Location = new System.Drawing.Point(7, 125);
            this.cbExplicitCapture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbExplicitCapture.Name = "cbExplicitCapture";
            this.cbExplicitCapture.Size = new System.Drawing.Size(108, 20);
            this.cbExplicitCapture.TabIndex = 6;
            this.cbExplicitCapture.Values.Text = "Explicit Capture";
            this.cbExplicitCapture.CheckedChanged += new System.EventHandler(this.cbNonECMAOptions_CheckedChanged);
            // 
            // cbSingleline
            // 
            this.cbSingleline.Location = new System.Drawing.Point(7, 91);
            this.cbSingleline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSingleline.Name = "cbSingleline";
            this.cbSingleline.Size = new System.Drawing.Size(76, 20);
            this.cbSingleline.TabIndex = 4;
            this.cbSingleline.Values.Text = "Singleline";
            this.cbSingleline.CheckedChanged += new System.EventHandler(this.cbNonECMAOptions_CheckedChanged);
            // 
            // cbMultiline
            // 
            this.cbMultiline.Checked = true;
            this.cbMultiline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMultiline.Location = new System.Drawing.Point(7, 58);
            this.cbMultiline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMultiline.Name = "cbMultiline";
            this.cbMultiline.Size = new System.Drawing.Size(71, 20);
            this.cbMultiline.TabIndex = 2;
            this.cbMultiline.Values.Text = "Multiline";
            // 
            // cbIgnoreCase
            // 
            this.cbIgnoreCase.Checked = true;
            this.cbIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreCase.Location = new System.Drawing.Point(7, 24);
            this.cbIgnoreCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIgnoreCase.Name = "cbIgnoreCase";
            this.cbIgnoreCase.Size = new System.Drawing.Size(88, 20);
            this.cbIgnoreCase.TabIndex = 0;
            this.cbIgnoreCase.Values.Text = "Ignore Case";
            // 
            // btnFindMatches
            // 
            this.btnFindMatches.CornerRoundingRadius = -1F;
            this.btnFindMatches.Location = new System.Drawing.Point(12, 172);
            this.btnFindMatches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindMatches.Name = "btnFindMatches";
            this.btnFindMatches.Size = new System.Drawing.Size(167, 50);
            this.btnFindMatches.TabIndex = 3;
            this.btnFindMatches.Values.Image = global::BBQ.Toolkit.Plugins.RegexStudio.Properties.Resources.Search;
            this.btnFindMatches.Values.Text = "Find Matches";
            this.btnFindMatches.Click += new System.EventHandler(this.btnFindMatches_Click);
            // 
            // grpReplacementString
            // 
            this.grpReplacementString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReplacementString.Controls.Add(this.txtReplacementString);
            this.grpReplacementString.Location = new System.Drawing.Point(4, 108);
            this.grpReplacementString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpReplacementString.Name = "grpReplacementString";
            this.grpReplacementString.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpReplacementString.Size = new System.Drawing.Size(555, 57);
            this.grpReplacementString.TabIndex = 1;
            this.grpReplacementString.TabStop = false;
            this.grpReplacementString.Text = "Replacement String";
            // 
            // txtReplacementString
            // 
            this.txtReplacementString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplacementString.Location = new System.Drawing.Point(8, 22);
            this.txtReplacementString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReplacementString.Name = "txtReplacementString";
            this.txtReplacementString.Size = new System.Drawing.Size(536, 23);
            this.txtReplacementString.TabIndex = 0;
            // 
            // btnReplace
            // 
            this.btnReplace.CornerRoundingRadius = -1F;
            this.btnReplace.Location = new System.Drawing.Point(187, 171);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(167, 50);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Values.Image = global::BBQ.Toolkit.Plugins.RegexStudio.Properties.Resources.Replace;
            this.btnReplace.Values.Text = "Replace";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnShowCSharpCode);
            this.pnlTop.Controls.Add(this.grpPattern);
            this.pnlTop.Controls.Add(this.btnReplace);
            this.pnlTop.Controls.Add(this.grpOptions);
            this.pnlTop.Controls.Add(this.grpReplacementString);
            this.pnlTop.Controls.Add(this.btnFindMatches);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 24);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(874, 229);
            this.pnlTop.TabIndex = 0;
            // 
            // btnShowCSharpCode
            // 
            this.btnShowCSharpCode.CornerRoundingRadius = -1F;
            this.btnShowCSharpCode.Location = new System.Drawing.Point(362, 171);
            this.btnShowCSharpCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowCSharpCode.Name = "btnShowCSharpCode";
            this.btnShowCSharpCode.Size = new System.Drawing.Size(167, 50);
            this.btnShowCSharpCode.TabIndex = 5;
            this.btnShowCSharpCode.Values.Image = global::BBQ.Toolkit.Plugins.RegexStudio.Properties.Resources.CS_Script;
            this.btnShowCSharpCode.Values.Text = "Show C# Code";
            this.btnShowCSharpCode.Click += new System.EventHandler(this.btnShowCSharpCode_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(500, 144);
            this.txtOutput.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOutput.TabIndex = 0;
            // 
            // splitContainerOutput
            // 
            this.splitContainerOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOutput.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainerOutput.Name = "splitContainerOutput";
            this.splitContainerOutput.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerOutput.Panel1
            // 
            this.splitContainerOutput.Panel1.Controls.Add(this.tvOutput);
            // 
            // splitContainerOutput.Panel2
            // 
            this.splitContainerOutput.Panel2.Controls.Add(this.txtOutput);
            this.splitContainerOutput.Size = new System.Drawing.Size(500, 428);
            this.splitContainerOutput.SplitterDistance = 279;
            this.splitContainerOutput.SplitterWidth = 5;
            this.splitContainerOutput.TabIndex = 6;
            // 
            // tvOutput
            // 
            this.tvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOutput.Location = new System.Drawing.Point(0, 0);
            this.tvOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvOutput.Name = "tvOutput";
            this.tvOutput.Size = new System.Drawing.Size(500, 279);
            this.tvOutput.TabIndex = 0;
            this.tvOutput.GroupChanged += new BBQ.Toolkit.Plugins.RegexStudio.Controls.MatchTreeView.GroupChangedEventHandler(this.tvOutput_GroupChanged);
            this.tvOutput.MatchChanged += new BBQ.Toolkit.Plugins.RegexStudio.Controls.MatchTreeView.MatchChangedEventHandler(this.tvOutput_MatchChanged);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 253);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.rTxtInput);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerOutput);
            this.splitContainerMain.Size = new System.Drawing.Size(874, 428);
            this.splitContainerMain.SplitterDistance = 369;
            this.splitContainerMain.SplitterWidth = 5;
            this.splitContainerMain.TabIndex = 7;
            // 
            // rTxtInput
            // 
            this.rTxtInput.DetectUrls = false;
            this.rTxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtInput.Location = new System.Drawing.Point(0, 0);
            this.rTxtInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rTxtInput.Name = "rTxtInput";
            this.rTxtInput.Size = new System.Drawing.Size(369, 428);
            this.rTxtInput.TabIndex = 0;
            this.rTxtInput.Text = "";
            this.rTxtInput.Enter += new System.EventHandler(this.rTxtInput_Enter);
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.mnuMainHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(874, 24);
            this.mnuMain.TabIndex = 8;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            this.mnuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFileNew,
            this.mnuMainFileOpen,
            this.mnuMainFileSeparator1,
            this.mnuMainFileSave,
            this.mnuMainFileSaveAs});
            this.mnuMainFile.Name = "mnuMainFile";
            this.mnuMainFile.Size = new System.Drawing.Size(37, 20);
            this.mnuMainFile.Text = "&File";
            // 
            // mnuMainFileNew
            // 
            this.mnuMainFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuMainFileNew.Name = "mnuMainFileNew";
            this.mnuMainFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuMainFileNew.Size = new System.Drawing.Size(146, 22);
            this.mnuMainFileNew.Text = "&New";
            this.mnuMainFileNew.Click += new System.EventHandler(this.mnuMainFileNew_Click);
            // 
            // mnuMainFileOpen
            // 
            this.mnuMainFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuMainFileOpen.Name = "mnuMainFileOpen";
            this.mnuMainFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuMainFileOpen.Size = new System.Drawing.Size(146, 22);
            this.mnuMainFileOpen.Text = "&Open";
            this.mnuMainFileOpen.Click += new System.EventHandler(this.mnuMainFileOpen_Click);
            // 
            // mnuMainFileSeparator1
            // 
            this.mnuMainFileSeparator1.Name = "mnuMainFileSeparator1";
            this.mnuMainFileSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // mnuMainFileSave
            // 
            this.mnuMainFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuMainFileSave.Name = "mnuMainFileSave";
            this.mnuMainFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuMainFileSave.Size = new System.Drawing.Size(146, 22);
            this.mnuMainFileSave.Text = "&Save";
            this.mnuMainFileSave.Click += new System.EventHandler(this.mnuMainFileSave_Click);
            // 
            // mnuMainFileSaveAs
            // 
            this.mnuMainFileSaveAs.Name = "mnuMainFileSaveAs";
            this.mnuMainFileSaveAs.Size = new System.Drawing.Size(146, 22);
            this.mnuMainFileSaveAs.Text = "Save &As";
            this.mnuMainFileSaveAs.Click += new System.EventHandler(this.mnuMainFileSaveAs_Click);
            // 
            // mnuMainHelp
            // 
            this.mnuMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainHelpAbout});
            this.mnuMainHelp.Name = "mnuMainHelp";
            this.mnuMainHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuMainHelp.Text = "&Help";
            // 
            // mnuMainHelpAbout
            // 
            this.mnuMainHelpAbout.Name = "mnuMainHelpAbout";
            this.mnuMainHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuMainHelpAbout.Text = "&About...";
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.Filter = "Regex Studio Files|*.rgx";
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "Regex Studio Files|*.rgx";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.mnuMain);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(874, 681);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpPattern.ResumeLayout(false);
            this.grpPattern.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpReplacementString.ResumeLayout(false);
            this.grpReplacementString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.splitContainerOutput.Panel1.ResumeLayout(false);
            this.splitContainerOutput.Panel2.ResumeLayout(false);
            this.splitContainerOutput.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOutput)).EndInit();
            this.splitContainerOutput.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonButton btnFindMatches;
        private KryptonButton btnReplace;
        private KryptonButton btnShowCSharpCode;
        private KryptonCheckBox cbCompiled;
        private KryptonCheckBox cbECMAScript;
        private KryptonCheckBox cbExplicitCapture;
        private KryptonCheckBox cbIgnoreCase;
        private KryptonCheckBox cbIgnorePatternWS;
        private KryptonCheckBox cbMultiline;
        private KryptonCheckBox cbRightToLeft;
        private KryptonCheckBox cbSingleline;
        
        private OpenFileDialog dlgOpenFile;
        private SaveFileDialog dlgSaveFile;
        private GroupBox grpOptions;
        private GroupBox grpPattern;
        private GroupBox grpReplacementString;
        
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuMainFile;
        private ToolStripMenuItem mnuMainFileNew;
        private ToolStripMenuItem mnuMainFileOpen;
        private ToolStripMenuItem mnuMainFileSave;
        private ToolStripMenuItem mnuMainFileSaveAs;
        private ToolStripSeparator mnuMainFileSeparator1;
        private ToolStripMenuItem mnuMainHelp;
        private ToolStripMenuItem mnuMainHelpAbout;
        private KryptonPanel pnlTop;
        private KryptonRichTextBox rTxtInput;
        private SplitContainer splitContainerMain;
        private SplitContainer splitContainerOutput;
        private RegexStudioFile studioFile;
        private MatchTreeView tvOutput;
        private KryptonTextBox txtOutput;
        private KryptonTextBox txtPattern;
        private KryptonTextBox txtReplacementString;
    }
}