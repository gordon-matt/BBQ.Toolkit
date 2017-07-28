using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kore;
using Kore.IO;
using Kore.Collections;
using System.IO;

namespace BBQ.Toolkit.Plugins.LogFilter
{
    public enum OutputType
    {
        Distinct,
        Matching
    }
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
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                InputFile = dlgOpenFile.FileName;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                OutputFile = dlgSaveFile.FileName;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (OutputType == OutputType.Distinct)
            {
                var lines = new FileInfo(InputFile).GetText().ToLines();
                lines.Distinct().Join(Environment.NewLine).ToFile(OutputFile);
            }
            else
            {
                var lines = new FileInfo(InputFile).GetText().ToLines();
                var matching = lines.Where(x => x.Contains(Matching));//TODO: support Regex
                matching.Join(Environment.NewLine).ToFile(OutputFile);
            }
        }
    }
}
