using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BBQ.Toolkit.Plugins.RegexStudio.Controls;

namespace BBQ.Toolkit.Plugins.RegexStudio
{
    [ToolboxItem(false)]
    public partial class Main : UserControl
    {
        private const string INITIAL_INPUT_TEXT = "This is a test: Project test EndProject";
        private const string INITIAL_OUTPUT_TEXT = "This is for the output";

        public Main()
        {
            this.InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.rTxtInput.Text = "This is a test: Project test EndProject";
            this.txtOutput.Text = "This is for the output";
            this.studioFile = new RegexStudioFile();
        }

        private void btnFindMatches_Click(object sender, EventArgs e)
        {
            Regex regex = this.BuildRegex();
            if (regex != null)
            {
                this.ClearMatches();
                foreach (Match match in regex.Matches(this.InputText))
                {
                    this.tvOutput.AddMatch(regex, match);
                }
            }
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = this.BuildRegex().Replace(this.InputText, this.ReplacementString);
        }
        private void btnShowCSharpCode_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = this.BuildCSharpCode();
        }

        private string BuildCSharpCode()
        {
            Regex regex = this.BuildRegex();
            if (regex == null)
            {
                return string.Empty;
            }
            StringBuilder builder = new StringBuilder();
            builder.Append("Regex regex = new Regex(");
            builder.Append(Environment.NewLine);
            builder.Append("@\"");
            builder.Append(regex.ToString());
            builder.Append("\",");
            builder.Append(Environment.NewLine);
            bool flag = false;
            if (this.cbCompiled.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.Compiled");
                flag = true;
            }
            if (this.cbECMAScript.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.ECMAScript");
                flag = true;
            }
            if (this.cbExplicitCapture.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.ExplicitCapture");
                flag = true;
            }
            if (this.cbIgnoreCase.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.IgnoreCase");
                flag = true;
            }
            if (this.cbIgnorePatternWS.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.IgnorePatternWhitespace");
                flag = true;
            }
            if (this.cbMultiline.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.Multiline");
                flag = true;
            }
            if (this.cbRightToLeft.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.RightToLeft");
                flag = true;
            }
            if (this.cbSingleline.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.Singleline");
                flag = true;
            }
            builder.Append(");");
            return builder.ToString();
        }
        private Regex BuildRegex()
        {
            RegexOptions none = RegexOptions.None;
            if (this.cbCompiled.Checked)
            {
                none |= RegexOptions.Compiled;
            }
            if (this.cbECMAScript.Checked)
            {
                none |= RegexOptions.ECMAScript;
            }
            if (this.cbExplicitCapture.Checked)
            {
                none |= RegexOptions.ExplicitCapture;
            }
            if (this.cbIgnoreCase.Checked)
            {
                none |= RegexOptions.IgnoreCase;
            }
            if (this.cbIgnorePatternWS.Checked)
            {
                none |= RegexOptions.IgnorePatternWhitespace;
            }
            if (this.cbMultiline.Checked)
            {
                none |= RegexOptions.Multiline;
            }
            if (this.cbRightToLeft.Checked)
            {
                none |= RegexOptions.RightToLeft;
            }
            if (this.cbSingleline.Checked)
            {
                none |= RegexOptions.Singleline;
            }
            try
            {
                return new Regex(this.Pattern, none);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return null;
            }
        }

        private void cbECMAScript_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbECMAScript.Checked)
            {
                this.cbSingleline.Checked = false;
                this.cbExplicitCapture.Checked = false;
                this.cbRightToLeft.Checked = false;
                this.cbIgnorePatternWS.Checked = false;
            }
        }
        private void cbNonECMAOptions_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            if (box.Checked)
            {
                this.cbECMAScript.Checked = false;
            }
        }

        private void Clear()
        {
            this.ClearMatches();
            this.rTxtInput.Clear();
            this.Pattern = string.Empty;
            this.ReplacementString = string.Empty;
            this.cbCompiled.Checked = true;
            this.cbECMAScript.Checked = false;
            this.cbExplicitCapture.Checked = false;
            this.cbIgnoreCase.Checked = true;
            this.cbIgnorePatternWS.Checked = false;
            this.cbMultiline.Checked = true;
            this.cbRightToLeft.Checked = false;
            this.cbSingleline.Checked = false;
        }
        private void ClearMatches()
        {
            this.tvOutput.Nodes.Clear();
            this.txtOutput.Clear();
            this.rTxtInput.SelectAll();
            this.rTxtInput.SelectionBackColor = Color.White;
        }
        private void LoadStudioFile()
        {
            this.cbCompiled.Checked = this.studioFile.Compiled;
            this.cbECMAScript.Checked = this.studioFile.ECMAScript;
            this.cbExplicitCapture.Checked = this.studioFile.ExplicitCapture;
            this.cbIgnoreCase.Checked = this.studioFile.IgnoreCase;
            this.cbIgnorePatternWS.Checked = this.studioFile.IgnorePatternWhitespace;
            this.cbMultiline.Checked = this.studioFile.Multiline;
            this.cbRightToLeft.Checked = this.studioFile.RightToLeft;
            this.cbSingleline.Checked = this.studioFile.Singleline;
            this.InputText = this.studioFile.MatchText;
            this.Pattern = this.studioFile.Pattern;
            this.ReplacementString = this.studioFile.ReplacementString;
        }

        private void mnuMainFileNew_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
        private void mnuMainFileOpen_Click(object sender, EventArgs e)
        {
            if (this.dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                this.studioFile = RegexStudioFile.Load(this.dlgOpenFile.FileName);
                this.Clear();
                this.LoadStudioFile();
            }
        }
        private void mnuMainFileSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.studioFile.FilePath))
            {
                this.SaveStudioFile(this.studioFile.FilePath);
            }
            else if (this.dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                this.SaveStudioFile(this.dlgSaveFile.FileName);
            }
        }
        private void mnuMainFileSaveAs_Click(object sender, EventArgs e)
        {
            if (this.dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                this.SaveStudioFile(this.dlgSaveFile.FileName);
            }
        }

        private void rTxtInput_Enter(object sender, EventArgs e)
        {
            if (this.rTxtInput.Text.Equals("This is a test: Project test EndProject", StringComparison.OrdinalIgnoreCase))
            {
                this.rTxtInput.Clear();
            }
        }

        private void SaveStudioFile(string filePath)
        {
            this.studioFile.Compiled = this.cbCompiled.Checked;
            this.studioFile.ECMAScript = this.cbECMAScript.Checked;
            this.studioFile.ExplicitCapture = this.cbExplicitCapture.Checked;
            this.studioFile.IgnoreCase = this.cbIgnoreCase.Checked;
            this.studioFile.IgnorePatternWhitespace = this.cbIgnorePatternWS.Checked;
            this.studioFile.Multiline = this.cbMultiline.Checked;
            this.studioFile.RightToLeft = this.cbRightToLeft.Checked;
            this.studioFile.Singleline = this.cbSingleline.Checked;
            this.studioFile.MatchText = this.InputText;
            this.studioFile.Pattern = this.Pattern;
            this.studioFile.ReplacementString = this.ReplacementString;
            this.studioFile.Save(filePath);
        }

        private void tvOutput_GroupChanged(GroupChangedEventArgs e)
        {
            this.rTxtInput.SelectAll();
            this.rTxtInput.SelectionBackColor = Color.White;
            this.txtOutput.Text = e.Group.Value;
            this.rTxtInput.Select(e.Group.Index, e.Group.Length);
            this.rTxtInput.SelectionBackColor = Color.Yellow;
            this.rTxtInput.ScrollToCaret();
        }
        private void tvOutput_MatchChanged(MatchChangedEventArgs e)
        {
            this.rTxtInput.SelectAll();
            this.rTxtInput.SelectionBackColor = Color.White;
            this.txtOutput.Text = e.Match.Value;
            this.rTxtInput.Select(e.Match.Index, e.Match.Length);
            this.rTxtInput.SelectionBackColor = Color.Yellow;
            this.rTxtInput.ScrollToCaret();
        }

        private string InputText
        {
            get { return this.rTxtInput.Text.Trim(); }
            set { this.rTxtInput.Text = value; }
        }
        private string Pattern
        {
            get { return this.txtPattern.Text.Trim(); }
            set { this.txtPattern.Text = value; }
        }
        private string ReplacementString
        {
            get { return this.txtReplacementString.Text; }
            set { this.txtReplacementString.Text = value; }
        }
    }
}