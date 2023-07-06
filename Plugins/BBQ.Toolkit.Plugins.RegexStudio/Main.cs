using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BBQ.Toolkit.Plugins.RegexStudio.Controls;
using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.RegexStudio
{
    [ToolboxItem(false)]
    public partial class Main : UserControl
    {
        #region Constructor and UserControl Event Handlers

        public Main()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rTxtInput.Text = "This is a test: Project test EndProject";
            txtOutput.Text = "This is for the output";
            studioFile = new RegexStudioFile();
        }

        #endregion Constructor and UserControl Event Handlers

        private string InputText
        {
            get { return rTxtInput.Text.Trim(); }
            set { rTxtInput.Text = value; }
        }

        private string Pattern
        {
            get { return txtPattern.Text.Trim(); }
            set { txtPattern.Text = value; }
        }

        private string ReplacementString
        {
            get { return txtReplacementString.Text; }
            set { txtReplacementString.Text = value; }
        }

        private string BuildCSharpCode()
        {
            var regex = BuildRegex();

            if (regex == null)
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            builder.Append("Regex regex = new Regex(");
            builder.Append(Environment.NewLine);
            builder.Append("@\"");
            builder.Append(regex.ToString());
            builder.Append("\",");
            builder.Append(Environment.NewLine);

            bool flag = false;
            if (cbCompiled.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.Compiled");
                flag = true;
            }

            if (cbECMAScript.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.ECMAScript");
                flag = true;
            }

            if (cbExplicitCapture.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.ExplicitCapture");
                flag = true;
            }

            if (cbIgnoreCase.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.IgnoreCase");
                flag = true;
            }

            if (cbIgnorePatternWS.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.IgnorePatternWhitespace");
                flag = true;
            }

            if (cbMultiline.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.Multiline");
                flag = true;
            }

            if (cbRightToLeft.Checked)
            {
                if (flag)
                {
                    builder.Append('|');
                    flag = false;
                }
                builder.Append("RegexOptions.RightToLeft");
                flag = true;
            }

            if (cbSingleline.Checked)
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
            var none = RegexOptions.None;

            if (cbCompiled.Checked) { none |= RegexOptions.Compiled; }
            if (cbECMAScript.Checked) { none |= RegexOptions.ECMAScript; }
            if (cbExplicitCapture.Checked) { none |= RegexOptions.ExplicitCapture; }
            if (cbIgnoreCase.Checked) { none |= RegexOptions.IgnoreCase; }
            if (cbIgnorePatternWS.Checked) { none |= RegexOptions.IgnorePatternWhitespace; }
            if (cbMultiline.Checked) { none |= RegexOptions.Multiline; }
            if (cbRightToLeft.Checked) { none |= RegexOptions.RightToLeft; }
            if (cbSingleline.Checked) { none |= RegexOptions.Singleline; }

            try
            {
                return new Regex(Pattern, none);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return null;
            }
        }

        private void Clear()
        {
            ClearMatches();
            rTxtInput.Clear();
            Pattern = string.Empty;
            ReplacementString = string.Empty;
            cbCompiled.Checked = true;
            cbECMAScript.Checked = false;
            cbExplicitCapture.Checked = false;
            cbIgnoreCase.Checked = true;
            cbIgnorePatternWS.Checked = false;
            cbMultiline.Checked = true;
            cbRightToLeft.Checked = false;
            cbSingleline.Checked = false;
        }

        private void ClearMatches()
        {
            tvOutput.Nodes.Clear();
            txtOutput.Clear();
            rTxtInput.SelectAll();
            rTxtInput.SelectionBackColor = Color.White;
        }

        private void LoadStudioFile()
        {
            cbCompiled.Checked = studioFile.Compiled;
            cbECMAScript.Checked = studioFile.ECMAScript;
            cbExplicitCapture.Checked = studioFile.ExplicitCapture;
            cbIgnoreCase.Checked = studioFile.IgnoreCase;
            cbIgnorePatternWS.Checked = studioFile.IgnorePatternWhitespace;
            cbMultiline.Checked = studioFile.Multiline;
            cbRightToLeft.Checked = studioFile.RightToLeft;
            cbSingleline.Checked = studioFile.Singleline;
            InputText = studioFile.MatchText;
            Pattern = studioFile.Pattern;
            ReplacementString = studioFile.ReplacementString;
        }

        private void SaveStudioFile(string filePath)
        {
            studioFile.Compiled = cbCompiled.Checked;
            studioFile.ECMAScript = cbECMAScript.Checked;
            studioFile.ExplicitCapture = cbExplicitCapture.Checked;
            studioFile.IgnoreCase = cbIgnoreCase.Checked;
            studioFile.IgnorePatternWhitespace = cbIgnorePatternWS.Checked;
            studioFile.Multiline = cbMultiline.Checked;
            studioFile.RightToLeft = cbRightToLeft.Checked;
            studioFile.Singleline = cbSingleline.Checked;
            studioFile.MatchText = InputText;
            studioFile.Pattern = Pattern;
            studioFile.ReplacementString = ReplacementString;
            studioFile.Save(filePath);
        }

        #region Control Event Handlers

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnFindMatches_Click(object sender, EventArgs e)
        {
            var regex = BuildRegex();
            if (regex != null)
            {
                ClearMatches();
                foreach (Match match in regex.Matches(InputText))
                {
                    tvOutput.AddMatch(regex, match);
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtOutput.Text = BuildRegex().Replace(InputText, ReplacementString);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnShowCSharpCode_Click(object sender, EventArgs e)
        {
            txtOutput.Text = BuildCSharpCode();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void cbECMAScript_CheckedChanged(object sender, EventArgs e)
        {
            if (cbECMAScript.Checked)
            {
                cbSingleline.Checked = false;
                cbExplicitCapture.Checked = false;
                cbRightToLeft.Checked = false;
                cbIgnorePatternWS.Checked = false;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void cbNonECMAOptions_CheckedChanged(object sender, EventArgs e)
        {
            var box = sender as KryptonCheckBox;
            if (box.Checked)
            {
                cbECMAScript.Checked = false;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void mnuMainFileNew_Click(object sender, EventArgs e) => Clear();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void mnuMainFileOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                studioFile = RegexStudioFile.Load(dlgOpenFile.FileName);
                Clear();
                LoadStudioFile();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void mnuMainFileSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(studioFile.FilePath))
            {
                SaveStudioFile(studioFile.FilePath);
            }
            else if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                SaveStudioFile(dlgSaveFile.FileName);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void mnuMainFileSaveAs_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                SaveStudioFile(dlgSaveFile.FileName);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void rTxtInput_Enter(object sender, EventArgs e)
        {
            if (rTxtInput.Text.Equals("This is a test: Project test EndProject", StringComparison.OrdinalIgnoreCase))
            {
                rTxtInput.Clear();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void tvOutput_GroupChanged(GroupChangedEventArgs e)
        {
            rTxtInput.SelectAll();
            rTxtInput.SelectionBackColor = Color.White;
            txtOutput.Text = e.Group.Value;
            rTxtInput.Select(e.Group.Index, e.Group.Length);
            rTxtInput.SelectionBackColor = Color.Yellow;
            rTxtInput.ScrollToCaret();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void tvOutput_MatchChanged(MatchChangedEventArgs e)
        {
            rTxtInput.SelectAll();
            rTxtInput.SelectionBackColor = Color.White;
            txtOutput.Text = e.Match.Value;
            rTxtInput.Select(e.Match.Index, e.Match.Length);
            rTxtInput.SelectionBackColor = Color.Yellow;
            rTxtInput.ScrollToCaret();
        }

        #endregion Control Event Handlers
    }
}