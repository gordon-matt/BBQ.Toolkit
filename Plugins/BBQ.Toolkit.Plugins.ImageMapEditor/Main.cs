using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BBQ.Toolkit.Plugins.ImageMapEditor.Models;
using BBQ.Toolkit.Plugins.ImageMapEditor.Views;

namespace BBQ.Toolkit.Plugins.ImageMapEditor
{
    public partial class Main : UserControl
    {
        private Graphics g;
        private Image image;
        private ImageMap imageMap = new ImageMap();
        private Pen pen = new Pen(Color.Blue, 2.0F);

        public Main()
        {
            InitializeComponent();
        }

        private void AddHotSpot(ImageMapHotSpot hotSpot)
        {
            imageMap.HotSpots.Add(hotSpot);
            txtHtml.Text = imageMap.ToString();
        }

        private void DrawCircle(Point center, int radius)
        {
            var rectangle = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);
            g.DrawEllipse(pen, rectangle);
        }

        private void DrawPolygon(IEnumerable<Point> points)
        {
            if (points.Count() > 1)
            {
                g.DrawPolygon(pen, points.ToArray());
            }
        }

        private void DrawRectangle(Point topLeft, Point bottomRight)
        {
            var rectangle = Rectangle.FromLTRB(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y);
            g.DrawRectangle(pen, rectangle);
        }

        private void LoadImage()
        {
            var dialog = new FileNameInputDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(dialog.SelectedFileName);

                pictureBox.Image = image;
                pictureBox.Width = image.Width;
                pictureBox.Height = image.Height;
                g = pictureBox.CreateGraphics();
            }
            else
            {
                dialog.Dispose();
                LoadImage();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void tsBtnCircle_Click(object sender, EventArgs e)
        {
            var form = new AddCircleForm(image);

            if (form.ShowDialog() == DialogResult.OK)
            {
                AddHotSpot(form.HotSpot);
                DrawCircle(form.HotSpot.Center, form.HotSpot.Radius);
            }
        }

        private void tsBtnPolygon_Click(object sender, EventArgs e)
        {
            var form = new AddPolygonForm(image);

            if (form.ShowDialog() == DialogResult.OK)
            {
                AddHotSpot(form.HotSpot);
                DrawPolygon(form.HotSpot.Coordinates);
            }
        }

        private void tsBtnRectangle_Click(object sender, EventArgs e)
        {
            var form = new AddRectangleForm(image);

            if (form.ShowDialog() == DialogResult.OK)
            {
                AddHotSpot(form.HotSpot);
                DrawRectangle(form.HotSpot.TopLeft, form.HotSpot.BottomRight);
            }
        }
    }
}