using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tabControl = new System.Windows.Forms.TabControl();
            tabTemplate = new System.Windows.Forms.TabPage();
            fctTemplate = new FastColoredTextBoxNS.FastColoredTextBox();
            tabResults = new System.Windows.Forms.TabPage();
            fctResults = new FastColoredTextBoxNS.FastColoredTextBox();
            toolStrip = new KryptonToolStrip();
            tsBtnOpenTemplate = new System.Windows.Forms.ToolStripButton();
            tsBtnNewTemplate = new System.Windows.Forms.ToolStripButton();
            tsBtnSaveResult = new System.Windows.Forms.ToolStripButton();
            tsDDBtnData = new System.Windows.Forms.ToolStripDropDownButton();
            tsDDBtnDataListStrings = new System.Windows.Forms.ToolStripMenuItem();
            tsDDBtnDataCSV = new System.Windows.Forms.ToolStripMenuItem();
            tsDDBtnDataJSON = new System.Windows.Forms.ToolStripMenuItem();
            tsBtnGenerateCode = new System.Windows.Forms.ToolStripButton();
            tsDDBtnLanguage = new System.Windows.Forms.ToolStripDropDownButton();
            dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            splitContainer = new System.Windows.Forms.SplitContainer();
            txtModelHelp = new KryptonTextBox();
            tabControl.SuspendLayout();
            tabTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fctTemplate).BeginInit();
            tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fctResults).BeginInit();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabTemplate);
            tabControl.Controls.Add(tabResults);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(568, 545);
            tabControl.TabIndex = 0;
            // 
            // tabTemplate
            // 
            tabTemplate.Controls.Add(fctTemplate);
            tabTemplate.Location = new System.Drawing.Point(4, 24);
            tabTemplate.Name = "tabTemplate";
            tabTemplate.Padding = new System.Windows.Forms.Padding(3);
            tabTemplate.Size = new System.Drawing.Size(560, 517);
            tabTemplate.TabIndex = 0;
            tabTemplate.Text = "Template";
            tabTemplate.UseVisualStyleBackColor = true;
            // 
            // fctTemplate
            // 
            fctTemplate.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
            fctTemplate.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            fctTemplate.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            fctTemplate.BackBrush = null;
            fctTemplate.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            fctTemplate.CharHeight = 14;
            fctTemplate.CharWidth = 8;
            fctTemplate.DefaultMarkerSize = 8;
            fctTemplate.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            fctTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            fctTemplate.IsReplaceMode = false;
            fctTemplate.Language = FastColoredTextBoxNS.Language.CSharp;
            fctTemplate.LeftBracket = '(';
            fctTemplate.LeftBracket2 = '{';
            fctTemplate.Location = new System.Drawing.Point(3, 3);
            fctTemplate.Name = "fctTemplate";
            fctTemplate.Paddings = new System.Windows.Forms.Padding(0);
            fctTemplate.RightBracket = ')';
            fctTemplate.RightBracket2 = '}';
            fctTemplate.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            fctTemplate.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctTemplate.ServiceColors");
            fctTemplate.Size = new System.Drawing.Size(554, 511);
            fctTemplate.TabIndex = 0;
            fctTemplate.Zoom = 100;
            // 
            // tabResults
            // 
            tabResults.Controls.Add(fctResults);
            tabResults.Location = new System.Drawing.Point(4, 24);
            tabResults.Name = "tabResults";
            tabResults.Padding = new System.Windows.Forms.Padding(3);
            tabResults.Size = new System.Drawing.Size(850, 517);
            tabResults.TabIndex = 1;
            tabResults.Text = "Results";
            tabResults.UseVisualStyleBackColor = true;
            // 
            // fctResults
            // 
            fctResults.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
            fctResults.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            fctResults.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            fctResults.BackBrush = null;
            fctResults.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            fctResults.CharHeight = 14;
            fctResults.CharWidth = 8;
            fctResults.DefaultMarkerSize = 8;
            fctResults.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            fctResults.Dock = System.Windows.Forms.DockStyle.Fill;
            fctResults.IsReplaceMode = false;
            fctResults.Language = FastColoredTextBoxNS.Language.CSharp;
            fctResults.LeftBracket = '(';
            fctResults.LeftBracket2 = '{';
            fctResults.Location = new System.Drawing.Point(3, 3);
            fctResults.Name = "fctResults";
            fctResults.Paddings = new System.Windows.Forms.Padding(0);
            fctResults.RightBracket = ')';
            fctResults.RightBracket2 = '}';
            fctResults.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            fctResults.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctResults.ServiceColors");
            fctResults.Size = new System.Drawing.Size(844, 511);
            fctResults.TabIndex = 0;
            fctResults.Zoom = 100;
            // 
            // toolStrip
            // 
            toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsBtnOpenTemplate, tsBtnNewTemplate, tsBtnSaveResult, tsDDBtnData, tsBtnGenerateCode, tsDDBtnLanguage });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(858, 39);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "kryptonToolStrip1";
            // 
            // tsBtnOpenTemplate
            // 
            tsBtnOpenTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsBtnOpenTemplate.Image = (System.Drawing.Image)resources.GetObject("tsBtnOpenTemplate.Image");
            tsBtnOpenTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnOpenTemplate.Name = "tsBtnOpenTemplate";
            tsBtnOpenTemplate.Size = new System.Drawing.Size(36, 36);
            tsBtnOpenTemplate.Text = "Open Template";
            tsBtnOpenTemplate.Click += tsBtnOpenTemplate_Click;
            // 
            // tsBtnNewTemplate
            // 
            tsBtnNewTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsBtnNewTemplate.Image = (System.Drawing.Image)resources.GetObject("tsBtnNewTemplate.Image");
            tsBtnNewTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnNewTemplate.Name = "tsBtnNewTemplate";
            tsBtnNewTemplate.Size = new System.Drawing.Size(36, 36);
            tsBtnNewTemplate.Text = "New Template";
            tsBtnNewTemplate.Click += tsBtnNewTemplate_Click;
            // 
            // tsBtnSaveResult
            // 
            tsBtnSaveResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsBtnSaveResult.Image = (System.Drawing.Image)resources.GetObject("tsBtnSaveResult.Image");
            tsBtnSaveResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnSaveResult.Name = "tsBtnSaveResult";
            tsBtnSaveResult.Size = new System.Drawing.Size(36, 36);
            tsBtnSaveResult.Text = "Save Result";
            tsBtnSaveResult.Click += tsBtnSaveResult_Click;
            // 
            // tsDDBtnData
            // 
            tsDDBtnData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsDDBtnData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsDDBtnDataListStrings, tsDDBtnDataCSV, tsDDBtnDataJSON });
            tsDDBtnData.Image = Properties.Resources.Input_32x32;
            tsDDBtnData.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsDDBtnData.Name = "tsDDBtnData";
            tsDDBtnData.Size = new System.Drawing.Size(45, 36);
            tsDDBtnData.Text = "toolStripDropDownButton1";
            // 
            // tsDDBtnDataListStrings
            // 
            tsDDBtnDataListStrings.Name = "tsDDBtnDataListStrings";
            tsDDBtnDataListStrings.Size = new System.Drawing.Size(180, 22);
            tsDDBtnDataListStrings.Text = "List of Strings";
            tsDDBtnDataListStrings.Click += tsDDBtnDataListStrings_Click;
            // 
            // tsDDBtnDataCSV
            // 
            tsDDBtnDataCSV.Name = "tsDDBtnDataCSV";
            tsDDBtnDataCSV.Size = new System.Drawing.Size(180, 22);
            tsDDBtnDataCSV.Text = "CSV";
            tsDDBtnDataCSV.Click += tsDDBtnDataCSV_Click;
            // 
            // tsDDBtnDataJSON
            // 
            tsDDBtnDataJSON.Name = "tsDDBtnDataJSON";
            tsDDBtnDataJSON.Size = new System.Drawing.Size(180, 22);
            tsDDBtnDataJSON.Text = "JSON";
            tsDDBtnDataJSON.Click += tsDDBtnDataJSON_Click;
            // 
            // tsBtnGenerateCode
            // 
            tsBtnGenerateCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsBtnGenerateCode.Image = Properties.Resources.Wand_32x32;
            tsBtnGenerateCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnGenerateCode.Name = "tsBtnGenerateCode";
            tsBtnGenerateCode.Size = new System.Drawing.Size(36, 36);
            tsBtnGenerateCode.Text = "Generate Code";
            tsBtnGenerateCode.Click += tsBtnGenerateCode_Click;
            // 
            // tsDDBtnLanguage
            // 
            tsDDBtnLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsDDBtnLanguage.Image = Properties.Resources.Braces_32x32;
            tsDDBtnLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsDDBtnLanguage.Name = "tsDDBtnLanguage";
            tsDDBtnLanguage.Size = new System.Drawing.Size(45, 36);
            tsDDBtnLanguage.Text = "Language";
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.FileName = "openFileDialog1";
            // 
            // splitContainer
            // 
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 39);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(txtModelHelp);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tabControl);
            splitContainer.Size = new System.Drawing.Size(858, 545);
            splitContainer.SplitterDistance = 286;
            splitContainer.TabIndex = 2;
            // 
            // txtModelHelp
            // 
            txtModelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            txtModelHelp.Location = new System.Drawing.Point(0, 0);
            txtModelHelp.Multiline = true;
            txtModelHelp.Name = "txtModelHelp";
            txtModelHelp.Size = new System.Drawing.Size(286, 545);
            txtModelHelp.TabIndex = 0;
            txtModelHelp.Text = "// Help text will appear here to describe the data model after you load some data";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Controls.Add(toolStrip);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            Size = new System.Drawing.Size(858, 584);
            tabControl.ResumeLayout(false);
            tabTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fctTemplate).EndInit();
            tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fctResults).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTemplate;
        private System.Windows.Forms.TabPage tabResults;
        private FastColoredTextBoxNS.FastColoredTextBox fctTemplate;
        private FastColoredTextBoxNS.FastColoredTextBox fctResults;
        private KryptonToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsBtnOpenTemplate;
        private System.Windows.Forms.ToolStripButton tsBtnNewTemplate;
        private System.Windows.Forms.ToolStripButton tsBtnSaveResult;
        private System.Windows.Forms.ToolStripDropDownButton tsDDBtnLanguage;
        private System.Windows.Forms.ToolStripButton tsBtnGenerateCode;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.ToolStripDropDownButton tsDDBtnData;
        private System.Windows.Forms.ToolStripMenuItem tsDDBtnDataListStrings;
        private System.Windows.Forms.ToolStripMenuItem tsDDBtnDataCSV;
        private System.Windows.Forms.ToolStripMenuItem tsDDBtnDataJSON;
        private System.Windows.Forms.SplitContainer splitContainer;
        private KryptonTextBox txtModelHelp;
    }
}
