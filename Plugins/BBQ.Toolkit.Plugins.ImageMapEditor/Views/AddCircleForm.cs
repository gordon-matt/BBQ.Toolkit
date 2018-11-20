﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BBQ.Toolkit.Plugins.ImageMapEditor.Models;
using ComponentFactory.Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    public partial class AddCircleForm : KryptonForm
    {
        #region Private Members

        private readonly Image image;
        private Point center { get; set; }
        private int radius = 20;

        private bool inDrawingMode = false;
        private bool isCompleted = false;

        private Pen pen = new Pen(Color.Blue, 2.0F);

        #endregion

        public CircleHotSpot HotSpot { get; private set; }

        #region Constructor & Form Event Handlers

        public AddCircleForm(Image image)
        {
            InitializeComponent();
            this.image = image;
        }

        private void AddCircleForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;

            inDrawingMode = true;
            lblRadiusValue.Text = radius.ToString();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            pen.Dispose();
        }

        #endregion

        private void tsBtnRetry_Click(object sender, EventArgs e)
        {
            center = default(Point);
            inDrawingMode = true;
            isCompleted = false;
            pictureBox.Invalidate();
        }

        private void tsBtnOK_Click(object sender, EventArgs e)
        {
            var dialog = new HotSpotInputDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                HotSpot = new CircleHotSpot
                {
                    Title = dialog.AlternateText,
                    Url = dialog.Url,
                    Center = center,
                    Radius = radius
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tsBtnRadius_Click(object sender, EventArgs e)
        {
            var dlgRadius = new RadiusInputDialog();
            dlgRadius.Radius = radius;

            if (dlgRadius.ShowDialog() == DialogResult.OK)
            {
                radius = dlgRadius.Radius;
                lblRadiusValue.Text = radius.ToString();
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lblXCoordinateValue.Text = e.Location.X.ToString();
            lblYCoordinateValue.Text = e.Location.Y.ToString();

            if (inDrawingMode)
            {
                center = e.Location;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (inDrawingMode)
            {
                isCompleted = true;
                inDrawingMode = false;

                pictureBox.Invalidate();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isCompleted)
            {
                var rectangle = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);
                e.Graphics.DrawEllipse(pen, rectangle);
            }
        }
    }
}