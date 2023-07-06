using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Plugins.ImageMapEditor.Models;
using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    public partial class AddPolygonForm : KryptonForm
    {
        #region Private Members

        private readonly Image image;
        private bool inDrawingMode = false;
        private readonly Pen pen = new(Color.Blue, 2.0F);
        private List<Point> points;

        #endregion Private Members

        public PolygonHotSpot HotSpot { get; private set; }

        #region Constructor & Form Event Handlers

        public AddPolygonForm(Image image)
        {
            InitializeComponent();
            this.image = image;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            pen.Dispose();
        }

        private void AddPolygonForm_Load(object sender, EventArgs e)
        {
            points = new List<Point>();

            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;

            inDrawingMode = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        #endregion Constructor & Form Event Handlers

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnStart_Click(object sender, EventArgs e)
        {
            inDrawingMode = true;
            points = new List<Point>();
            pictureBox.Invalidate();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnStop_Click(object sender, EventArgs e)
        {
            inDrawingMode = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lblXCoordinateValue.Text = e.Location.X.ToString();
            lblYCoordinateValue.Text = e.Location.Y.ToString();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (inDrawingMode)
            {
                points.Add(e.Location);
                pictureBox.Invalidate();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            int count = points.Count;

            if (count > 1)
            {
                e.Graphics.DrawPolygon(pen, points.ToArray());
            }
            else if (count == 1)
            {
                var point = points[0];
                const int radius = 2;
                var rectangle = new Rectangle(point.X - radius, point.Y - radius, radius * 2, radius * 2);
                e.Graphics.DrawEllipse(pen, rectangle);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void tsBtnOK_Click(object sender, EventArgs e)
        {
            using var dialog = new HotSpotInputDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                HotSpot = new PolygonHotSpot
                {
                    Title = dialog.AlternateText,
                    Url = dialog.Url,
                    Coordinates = points
                };

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}