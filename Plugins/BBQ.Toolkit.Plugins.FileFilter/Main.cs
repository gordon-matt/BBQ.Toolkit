using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kore;
using System.IO;
using Kore.IO;
using Kore.Collections;

namespace BBQ.Toolkit.Plugins.FileDiffOutput
{
    public enum OutputType
    {
        File1Differences,
        File2Differences
    }

    public partial class Main : UserControl
    {
        private OutputType OutputType
        {
            get
            {
                if (rbFile1.Checked)
                {
                    return OutputType.File1Differences;
                }
                return OutputType.File2Differences;
            }
            set
            {
                switch (value)
                {
                    case OutputType.File1Differences: rbFile1.Checked = true; break;
                    case OutputType.File2Differences: rbFile2.Checked = true; break;
                }
            }
        }
        private string File1
        {
            get { return txtFile1.Text.Trim(); }
            set { txtFile1.Text = value; }
        }
        private string File2
        {
            get { return txtFile2.Text.Trim(); }
            set { txtFile2.Text = value; }
        }
        private string OutputFile
        {
            get { return txtOutput.Text.Trim(); }
            set { txtOutput.Text = value; }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnBrowseFile1_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                File1 = dlgOpenFile.FileName;
            }
        }

        private void btnBrowseFile2_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                File2 = dlgOpenFile.FileName;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                OutputFile = dlgSaveFile.FileName;
            }
        }

        private void OutputDifferences(string inputFile1, string inputFile2)
        {
            var file1Lines = new FileInfo(inputFile1).GetText().ToLines();
            var file2Lines = new FileInfo(inputFile2).GetText().ToLines();

            List<string> newLines = new List<string>();
            foreach (string line in file1Lines)
            {
                if (!file2Lines.Contains(line))
                {
                    newLines.Add(line);
                }
            }
            newLines.Join(Environment.NewLine).ToFile(OutputFile);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            switch (OutputType)
            {
                case OutputType.File1Differences: OutputDifferences(File1, File2); break;
                case OutputType.File2Differences: OutputDifferences(File2, File1); break;
                default: break;
            }
        }
    }
}
