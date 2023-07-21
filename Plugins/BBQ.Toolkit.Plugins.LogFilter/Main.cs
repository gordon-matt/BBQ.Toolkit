using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BBQ.Toolkit.Common.Properties;
using Extenso;
using Extenso.Collections;
using Extenso.IO;

namespace BBQ.Toolkit.Plugins.LogFilter
{
    public enum OutputType : byte
    {
        Distinct,
        Matching
    }

    [ToolboxItem(false)]
    public partial class Main : UserControl
    {
        private string InputFile
        {
            get { return txtInput.Text.Trim(); }
            set { txtInput.Text = value; }
        }

        private string OutputFile
        {
            get { return txtOutput.Text.Trim(); }
            set { txtOutput.Text = value; }
        }

        private OutputType OutputType
        {
            get
            {
                if (rbOutputDistinct.Checked)
                {
                    return OutputType.Distinct;
                }
                return OutputType.Matching;
            }
            set
            {
                switch (value)
                {
                    case OutputType.Distinct: rbOutputDistinct.Checked = true; break;
                    case OutputType.Matching: rbOutputMatching.Checked = true; break;
                }
            }
        }

        private string Matching
        {
            get { return txtMatching.Text; }
            set { txtMatching.Text = value; }
        }

        public Main()
        {
            InitializeComponent();
            btnRun.Values.Image = CommonImages.Play_32x32;
            btnBrowseInput.Values.Image = CommonImages.Browse_32x32;
            btnBrowseOutput.Values.Image = CommonImages.Browse_32x32;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                InputFile = dlgOpenFile.FileName;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                OutputFile = dlgSaveFile.FileName;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (OutputType == OutputType.Distinct)
            {
                var lines = new FileInfo(InputFile).ReadAllText().ToLines();
                lines.Distinct().Join(Environment.NewLine).ToFile(OutputFile);
            }
            else
            {
                var lines = new FileInfo(InputFile).ReadAllText().ToLines();
                var matching = lines.Where(x => x.Contains(Matching));//TODO: support Regex
                matching.Join(Environment.NewLine).ToFile(OutputFile);
            }
        }
    }
}