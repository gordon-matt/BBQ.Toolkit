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
            txtPattern = new KryptonTextBox();
            grpPattern = new GroupBox();
            grpOptions = new GroupBox();
            cbCompiled = new KryptonCheckBox();
            cbIgnorePatternWS = new KryptonCheckBox();
            cbRightToLeft = new KryptonCheckBox();
            cbECMAScript = new KryptonCheckBox();
            cbExplicitCapture = new KryptonCheckBox();
            cbSingleline = new KryptonCheckBox();
            cbMultiline = new KryptonCheckBox();
            cbIgnoreCase = new KryptonCheckBox();
            btnFindMatches = new KryptonButton();
            grpReplacementString = new GroupBox();
            txtReplacementString = new KryptonTextBox();
            btnReplace = new KryptonButton();
            pnlTop = new KryptonPanel();
            btnShowCSharpCode = new KryptonButton();
            txtOutput = new KryptonTextBox();
            splitContainerOutput = new SplitContainer();
            tvOutput = new MatchTreeView();
            splitContainerMain = new SplitContainer();
            rTxtInput = new KryptonRichTextBox();
            mnuMain = new MenuStrip();
            mnuMainFile = new ToolStripMenuItem();
            mnuMainFileNew = new ToolStripMenuItem();
            mnuMainFileOpen = new ToolStripMenuItem();
            mnuMainFileSeparator1 = new ToolStripSeparator();
            mnuMainFileSave = new ToolStripMenuItem();
            mnuMainFileSaveAs = new ToolStripMenuItem();
            mnuMainHelp = new ToolStripMenuItem();
            mnuMainHelpAbout = new ToolStripMenuItem();
            dlgSaveFile = new SaveFileDialog();
            dlgOpenFile = new OpenFileDialog();
            grpPattern.SuspendLayout();
            grpOptions.SuspendLayout();
            grpReplacementString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlTop).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerOutput).BeginInit();
            splitContainerOutput.Panel1.SuspendLayout();
            splitContainerOutput.Panel2.SuspendLayout();
            splitContainerOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtPattern
            // 
            txtPattern.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPattern.Location = new System.Drawing.Point(8, 22);
            txtPattern.Margin = new Padding(4, 3, 4, 3);
            txtPattern.Multiline = true;
            txtPattern.Name = "txtPattern";
            txtPattern.ScrollBars = ScrollBars.Vertical;
            txtPattern.Size = new System.Drawing.Size(536, 63);
            txtPattern.TabIndex = 0;
            txtPattern.Text = "Project(?<value>(?:(?!Project).)*)EndProject";
            // 
            // grpPattern
            // 
            grpPattern.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPattern.Controls.Add(txtPattern);
            grpPattern.Location = new System.Drawing.Point(4, 3);
            grpPattern.Margin = new Padding(4, 3, 4, 3);
            grpPattern.Name = "grpPattern";
            grpPattern.Padding = new Padding(4, 3, 4, 3);
            grpPattern.Size = new System.Drawing.Size(555, 98);
            grpPattern.TabIndex = 0;
            grpPattern.TabStop = false;
            grpPattern.Text = "Pattern";
            // 
            // grpOptions
            // 
            grpOptions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpOptions.Controls.Add(cbCompiled);
            grpOptions.Controls.Add(cbIgnorePatternWS);
            grpOptions.Controls.Add(cbRightToLeft);
            grpOptions.Controls.Add(cbECMAScript);
            grpOptions.Controls.Add(cbExplicitCapture);
            grpOptions.Controls.Add(cbSingleline);
            grpOptions.Controls.Add(cbMultiline);
            grpOptions.Controls.Add(cbIgnoreCase);
            grpOptions.Location = new System.Drawing.Point(565, 3);
            grpOptions.Margin = new Padding(4, 3, 4, 3);
            grpOptions.Name = "grpOptions";
            grpOptions.Padding = new Padding(4, 3, 4, 3);
            grpOptions.Size = new System.Drawing.Size(281, 162);
            grpOptions.TabIndex = 2;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // cbCompiled
            // 
            cbCompiled.Checked = true;
            cbCompiled.CheckState = CheckState.Checked;
            cbCompiled.Location = new System.Drawing.Point(141, 125);
            cbCompiled.Margin = new Padding(4, 3, 4, 3);
            cbCompiled.Name = "cbCompiled";
            cbCompiled.Size = new System.Drawing.Size(76, 20);
            cbCompiled.TabIndex = 7;
            cbCompiled.Values.Text = "Compiled";
            // 
            // cbIgnorePatternWS
            // 
            cbIgnorePatternWS.Location = new System.Drawing.Point(141, 91);
            cbIgnorePatternWS.Margin = new Padding(4, 3, 4, 3);
            cbIgnorePatternWS.Name = "cbIgnorePatternWS";
            cbIgnorePatternWS.Size = new System.Drawing.Size(123, 20);
            cbIgnorePatternWS.TabIndex = 5;
            cbIgnorePatternWS.Values.Text = "Ignore Pattern WS";
            cbIgnorePatternWS.CheckedChanged += cbNonECMAOptions_CheckedChanged;
            // 
            // cbRightToLeft
            // 
            cbRightToLeft.Location = new System.Drawing.Point(141, 58);
            cbRightToLeft.Margin = new Padding(4, 3, 4, 3);
            cbRightToLeft.Name = "cbRightToLeft";
            cbRightToLeft.Size = new System.Drawing.Size(93, 20);
            cbRightToLeft.TabIndex = 3;
            cbRightToLeft.Values.Text = "Right To Left";
            cbRightToLeft.CheckedChanged += cbNonECMAOptions_CheckedChanged;
            // 
            // cbECMAScript
            // 
            cbECMAScript.Location = new System.Drawing.Point(141, 24);
            cbECMAScript.Margin = new Padding(4, 3, 4, 3);
            cbECMAScript.Name = "cbECMAScript";
            cbECMAScript.Size = new System.Drawing.Size(91, 20);
            cbECMAScript.TabIndex = 1;
            cbECMAScript.Values.Text = "ECMA Script";
            cbECMAScript.CheckedChanged += cbECMAScript_CheckedChanged;
            // 
            // cbExplicitCapture
            // 
            cbExplicitCapture.Location = new System.Drawing.Point(7, 125);
            cbExplicitCapture.Margin = new Padding(4, 3, 4, 3);
            cbExplicitCapture.Name = "cbExplicitCapture";
            cbExplicitCapture.Size = new System.Drawing.Size(108, 20);
            cbExplicitCapture.TabIndex = 6;
            cbExplicitCapture.Values.Text = "Explicit Capture";
            cbExplicitCapture.CheckedChanged += cbNonECMAOptions_CheckedChanged;
            // 
            // cbSingleline
            // 
            cbSingleline.Location = new System.Drawing.Point(7, 91);
            cbSingleline.Margin = new Padding(4, 3, 4, 3);
            cbSingleline.Name = "cbSingleline";
            cbSingleline.Size = new System.Drawing.Size(76, 20);
            cbSingleline.TabIndex = 4;
            cbSingleline.Values.Text = "Singleline";
            cbSingleline.CheckedChanged += cbNonECMAOptions_CheckedChanged;
            // 
            // cbMultiline
            // 
            cbMultiline.Checked = true;
            cbMultiline.CheckState = CheckState.Checked;
            cbMultiline.Location = new System.Drawing.Point(7, 58);
            cbMultiline.Margin = new Padding(4, 3, 4, 3);
            cbMultiline.Name = "cbMultiline";
            cbMultiline.Size = new System.Drawing.Size(71, 20);
            cbMultiline.TabIndex = 2;
            cbMultiline.Values.Text = "Multiline";
            // 
            // cbIgnoreCase
            // 
            cbIgnoreCase.Checked = true;
            cbIgnoreCase.CheckState = CheckState.Checked;
            cbIgnoreCase.Location = new System.Drawing.Point(7, 24);
            cbIgnoreCase.Margin = new Padding(4, 3, 4, 3);
            cbIgnoreCase.Name = "cbIgnoreCase";
            cbIgnoreCase.Size = new System.Drawing.Size(88, 20);
            cbIgnoreCase.TabIndex = 0;
            cbIgnoreCase.Values.Text = "Ignore Case";
            // 
            // btnFindMatches
            // 
            btnFindMatches.CornerRoundingRadius = -1F;
            btnFindMatches.Location = new System.Drawing.Point(4, 173);
            btnFindMatches.Margin = new Padding(4, 3, 4, 3);
            btnFindMatches.Name = "btnFindMatches";
            btnFindMatches.Size = new System.Drawing.Size(167, 50);
            btnFindMatches.TabIndex = 3;
            btnFindMatches.Values.Image = Properties.Resources.Search;
            btnFindMatches.Values.Text = "Find Matches";
            btnFindMatches.Click += btnFindMatches_Click;
            // 
            // grpReplacementString
            // 
            grpReplacementString.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpReplacementString.Controls.Add(txtReplacementString);
            grpReplacementString.Location = new System.Drawing.Point(4, 108);
            grpReplacementString.Margin = new Padding(4, 3, 4, 3);
            grpReplacementString.Name = "grpReplacementString";
            grpReplacementString.Padding = new Padding(4, 3, 4, 3);
            grpReplacementString.Size = new System.Drawing.Size(555, 57);
            grpReplacementString.TabIndex = 1;
            grpReplacementString.TabStop = false;
            grpReplacementString.Text = "Replacement String";
            // 
            // txtReplacementString
            // 
            txtReplacementString.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReplacementString.Location = new System.Drawing.Point(8, 22);
            txtReplacementString.Margin = new Padding(4, 3, 4, 3);
            txtReplacementString.Name = "txtReplacementString";
            txtReplacementString.Size = new System.Drawing.Size(536, 23);
            txtReplacementString.TabIndex = 0;
            // 
            // btnReplace
            // 
            btnReplace.CornerRoundingRadius = -1F;
            btnReplace.Location = new System.Drawing.Point(179, 172);
            btnReplace.Margin = new Padding(4, 3, 4, 3);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new System.Drawing.Size(167, 50);
            btnReplace.TabIndex = 4;
            btnReplace.Values.Image = Properties.Resources.Replace;
            btnReplace.Values.Text = "Replace";
            btnReplace.Click += btnReplace_Click;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnShowCSharpCode);
            pnlTop.Controls.Add(grpPattern);
            pnlTop.Controls.Add(btnReplace);
            pnlTop.Controls.Add(grpOptions);
            pnlTop.Controls.Add(grpReplacementString);
            pnlTop.Controls.Add(btnFindMatches);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 24);
            pnlTop.Margin = new Padding(4, 3, 4, 3);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(874, 229);
            pnlTop.TabIndex = 0;
            // 
            // btnShowCSharpCode
            // 
            btnShowCSharpCode.CornerRoundingRadius = -1F;
            btnShowCSharpCode.Location = new System.Drawing.Point(354, 172);
            btnShowCSharpCode.Margin = new Padding(4, 3, 4, 3);
            btnShowCSharpCode.Name = "btnShowCSharpCode";
            btnShowCSharpCode.Size = new System.Drawing.Size(167, 50);
            btnShowCSharpCode.TabIndex = 5;
            btnShowCSharpCode.Values.Image = Properties.Resources.CS_Script;
            btnShowCSharpCode.Values.Text = "Show C# Code";
            btnShowCSharpCode.Click += btnShowCSharpCode_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = System.Drawing.Color.LemonChiffon;
            txtOutput.Dock = DockStyle.Fill;
            txtOutput.Location = new System.Drawing.Point(0, 0);
            txtOutput.Margin = new Padding(4, 3, 4, 3);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new System.Drawing.Size(500, 144);
            txtOutput.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(255, 255, 192);
            txtOutput.TabIndex = 0;
            // 
            // splitContainerOutput
            // 
            splitContainerOutput.Dock = DockStyle.Fill;
            splitContainerOutput.Location = new System.Drawing.Point(0, 0);
            splitContainerOutput.Margin = new Padding(4, 3, 4, 3);
            splitContainerOutput.Name = "splitContainerOutput";
            splitContainerOutput.Orientation = Orientation.Horizontal;
            // 
            // splitContainerOutput.Panel1
            // 
            splitContainerOutput.Panel1.Controls.Add(tvOutput);
            // 
            // splitContainerOutput.Panel2
            // 
            splitContainerOutput.Panel2.Controls.Add(txtOutput);
            splitContainerOutput.Size = new System.Drawing.Size(500, 428);
            splitContainerOutput.SplitterDistance = 279;
            splitContainerOutput.SplitterWidth = 5;
            splitContainerOutput.TabIndex = 6;
            // 
            // tvOutput
            // 
            tvOutput.Dock = DockStyle.Fill;
            tvOutput.Location = new System.Drawing.Point(0, 0);
            tvOutput.Margin = new Padding(4, 3, 4, 3);
            tvOutput.Name = "tvOutput";
            tvOutput.Size = new System.Drawing.Size(500, 279);
            tvOutput.TabIndex = 0;
            tvOutput.GroupChanged += tvOutput_GroupChanged;
            tvOutput.MatchChanged += tvOutput_MatchChanged;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new System.Drawing.Point(0, 253);
            splitContainerMain.Margin = new Padding(4, 3, 4, 3);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(rTxtInput);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(splitContainerOutput);
            splitContainerMain.Size = new System.Drawing.Size(874, 428);
            splitContainerMain.SplitterDistance = 369;
            splitContainerMain.SplitterWidth = 5;
            splitContainerMain.TabIndex = 7;
            // 
            // rTxtInput
            // 
            rTxtInput.DetectUrls = false;
            rTxtInput.Dock = DockStyle.Fill;
            rTxtInput.Location = new System.Drawing.Point(0, 0);
            rTxtInput.Margin = new Padding(4, 3, 4, 3);
            rTxtInput.Name = "rTxtInput";
            rTxtInput.Size = new System.Drawing.Size(369, 428);
            rTxtInput.TabIndex = 0;
            rTxtInput.Text = "";
            rTxtInput.Enter += rTxtInput_Enter;
            // 
            // mnuMain
            // 
            mnuMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuMainFile, mnuMainHelp });
            mnuMain.Location = new System.Drawing.Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new Padding(7, 2, 0, 2);
            mnuMain.Size = new System.Drawing.Size(874, 24);
            mnuMain.TabIndex = 8;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            mnuMainFile.DropDownItems.AddRange(new ToolStripItem[] { mnuMainFileNew, mnuMainFileOpen, mnuMainFileSeparator1, mnuMainFileSave, mnuMainFileSaveAs });
            mnuMainFile.Name = "mnuMainFile";
            mnuMainFile.Size = new System.Drawing.Size(37, 20);
            mnuMainFile.Text = "&File";
            // 
            // mnuMainFileNew
            // 
            mnuMainFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            mnuMainFileNew.Name = "mnuMainFileNew";
            mnuMainFileNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuMainFileNew.Size = new System.Drawing.Size(146, 22);
            mnuMainFileNew.Text = "&New";
            mnuMainFileNew.Click += mnuMainFileNew_Click;
            // 
            // mnuMainFileOpen
            // 
            mnuMainFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            mnuMainFileOpen.Name = "mnuMainFileOpen";
            mnuMainFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuMainFileOpen.Size = new System.Drawing.Size(146, 22);
            mnuMainFileOpen.Text = "&Open";
            mnuMainFileOpen.Click += mnuMainFileOpen_Click;
            // 
            // mnuMainFileSeparator1
            // 
            mnuMainFileSeparator1.Name = "mnuMainFileSeparator1";
            mnuMainFileSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // mnuMainFileSave
            // 
            mnuMainFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            mnuMainFileSave.Name = "mnuMainFileSave";
            mnuMainFileSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuMainFileSave.Size = new System.Drawing.Size(146, 22);
            mnuMainFileSave.Text = "&Save";
            mnuMainFileSave.Click += mnuMainFileSave_Click;
            // 
            // mnuMainFileSaveAs
            // 
            mnuMainFileSaveAs.Name = "mnuMainFileSaveAs";
            mnuMainFileSaveAs.Size = new System.Drawing.Size(146, 22);
            mnuMainFileSaveAs.Text = "Save &As";
            mnuMainFileSaveAs.Click += mnuMainFileSaveAs_Click;
            // 
            // mnuMainHelp
            // 
            mnuMainHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuMainHelpAbout });
            mnuMainHelp.Name = "mnuMainHelp";
            mnuMainHelp.Size = new System.Drawing.Size(44, 20);
            mnuMainHelp.Text = "&Help";
            // 
            // mnuMainHelpAbout
            // 
            mnuMainHelpAbout.Name = "mnuMainHelpAbout";
            mnuMainHelpAbout.Size = new System.Drawing.Size(116, 22);
            mnuMainHelpAbout.Text = "&About...";
            // 
            // dlgSaveFile
            // 
            dlgSaveFile.Filter = "Regex Studio Files|*.rgx";
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "Regex Studio Files|*.rgx";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerMain);
            Controls.Add(pnlTop);
            Controls.Add(mnuMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            Size = new System.Drawing.Size(874, 681);
            Load += MainForm_Load;
            grpPattern.ResumeLayout(false);
            grpPattern.PerformLayout();
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            grpReplacementString.ResumeLayout(false);
            grpReplacementString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlTop).EndInit();
            pnlTop.ResumeLayout(false);
            splitContainerOutput.Panel1.ResumeLayout(false);
            splitContainerOutput.Panel2.ResumeLayout(false);
            splitContainerOutput.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerOutput).EndInit();
            splitContainerOutput.ResumeLayout(false);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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