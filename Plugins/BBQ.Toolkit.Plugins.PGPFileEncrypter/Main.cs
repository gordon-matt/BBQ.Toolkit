﻿using System;
using System.IO;
using System.Windows.Forms;
using BBQ.Toolkit.Common.Properties;
using PgpCore;

namespace BBQ.Toolkit.Plugins.PGPFileEncrypter
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
            btnBrowseFile.Values.Image = CommonImages.Browse_32x32;
            btnBrowsePublicKeyFile.Values.Image = CommonImages.Browse_32x32;
            btnSave.Values.Image = CommonImages.Save_32x32;
        }

        private string FilePath
        {
            get => txtFile.Text;
            set => txtFile.Text = value;
        }

        private string PublicKeyFilePath
        {
            get => txtPublicKeyFile.Text;
            set => txtPublicKeyFile.Text = value;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                FilePath = dlgOpenFile.FileName;
            }
        }

        private void btnBrowsePublicKeyFile_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                PublicKeyFilePath = dlgOpenFile.FileName;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            using (var inputStream = File.OpenRead(FilePath))
            using (var outputStream = File.Create($"{FilePath}.pgp"))
            using (var pgp = new PGP())
            using (var publicKeyStream = new FileStream(PublicKeyFilePath, FileMode.Open))
            {
                await pgp.EncryptStreamAsync(inputStream, outputStream, publicKeyStream, true, true);
            }
        }
    }
}