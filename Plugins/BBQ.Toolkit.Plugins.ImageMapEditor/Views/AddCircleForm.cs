using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Plugins.ImageMapEditor.Models;
using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    public partial class AddCircleForm : KryptonForm
    {
        #region Private Members

        private readonly Image image;
        private bool inDrawingMode = false;
        private bool isCompleted = false;
        private Pen pen = new Pen(Color.Blue, 2.0F);
        private int radius = 20;

        private Point center { get; set; }

        #endregion Private Members

        public CircleHotSpot HotSpot { get; private set; }

        #region Constructor & Form Event Handlers

        public AddCircleForm(Image image)
        {
            InitializeComponent();
            this.image = image;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            pen.Dispose();
        }

        private void AddCircleForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;

            inDrawingMode = true;
            lblRadiusValue.Text = radius.ToString();
        }

        #endregion Constructor & Form Event Handlers

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

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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

                DialogResult = DialogResult.OK;
                Close();
            }
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

        private void tsBtnRetry_Click(object sender, EventArgs e)
        {
            center = default(Point);
            inDrawingMode = true;
            isCompleted = false;
            pictureBox.Invalidate();
        }
    }
}