using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BBQ.Toolkit.Plugins.ImageMapEditor.Models;
using Krypton.Toolkit;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Views
{
    public partial class AddRectangleForm : KryptonForm
    {
        #region Private Members

        private readonly Image image;
        private bool inDrawingMode = false;
        private bool isCompleted = false;
        private bool isDragging = false;
        private readonly Pen pen = new(Color.Blue, 2.0F);

        private Point bottomRight;
        private Point topLeft;

        #endregion Private Members

        public RectangleHotSpot HotSpot { get; private set; }

        #region Constructor & Form Event Handlers

        public AddRectangleForm(Image image)
        {
            InitializeComponent();
            this.image = image;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            pen.Dispose();
        }

        private void AddRectangleForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;

            inDrawingMode = true;
        }

        #endregion Constructor & Form Event Handlers

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                bottomRight = e.Location;
                pictureBox.Invalidate();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isDragging || isCompleted)
            {
                e.Graphics.DrawRectangle(pen, Rectangle.FromLTRB(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y));
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
                HotSpot = new RectangleHotSpot
                {
                    Title = dialog.AlternateText,
                    Url = dialog.Url,
                    TopLeft = topLeft,
                    BottomRight = bottomRight
                };

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void tsBtnRetry_Click(object sender, EventArgs e)
        {
            topLeft = default;
            bottomRight = default;
            inDrawingMode = true;
            isCompleted = false;
            isDragging = false;
            pictureBox.Invalidate();
        }
    }
}