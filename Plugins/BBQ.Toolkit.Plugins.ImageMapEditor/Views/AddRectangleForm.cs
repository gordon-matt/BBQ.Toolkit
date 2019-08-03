using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Plugins.ImageMapEditor.Models;
using ComponentFactory.Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    public partial class AddRectangleForm : KryptonForm
    {
        #region Private Members

        private readonly Image image;
        private Point topLeft { get; set; }
        private Point bottomRight { get; set; }

        private bool inDrawingMode = false;
        private bool isCompleted = false;
        private bool isDragging = false;

        private Pen pen = new Pen(Color.Blue, 2.0F);

        #endregion Private Members

        public RectangleHotSpot HotSpot { get; private set; }

        #region Constructor & Form Event Handlers

        public AddRectangleForm(Image image)
        {
            InitializeComponent();
            this.image = image;
        }

        private void AddRectangleForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;

            inDrawingMode = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            pen.Dispose();
        }

        #endregion Constructor & Form Event Handlers

        private void tsBtnRetry_Click(object sender, EventArgs e)
        {
            topLeft = default(Point);
            bottomRight = default(Point);
            inDrawingMode = true;
            isCompleted = false;
            isDragging = false;
            pictureBox.Invalidate();
        }

        private void tsBtnOK_Click(object sender, EventArgs e)
        {
            var dialog = new HotSpotInputDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                HotSpot = new RectangleHotSpot
                {
                    Title = dialog.AlternateText,
                    Url = dialog.Url,
                    TopLeft = topLeft,
                    BottomRight = bottomRight
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

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lblXCoordinateValue.Text = e.Location.X.ToString();
            lblYCoordinateValue.Text = e.Location.Y.ToString();

            if (inDrawingMode)
            {
                topLeft = e.Location;
                isDragging = true;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                bottomRight = e.Location;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (inDrawingMode)
            {
                bottomRight = e.Location;

                isCompleted = true;
                inDrawingMode = false;
                isDragging = false;

                pictureBox.Invalidate();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isDragging || isCompleted)
            {
                e.Graphics.DrawRectangle(pen, Rectangle.FromLTRB(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y));
            }
        }
    }
}