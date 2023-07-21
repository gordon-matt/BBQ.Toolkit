using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BBQ.Toolkit.Common.Properties;
using BBQ.Toolkit.Plugins.ImageMapEditor.Models;
using BBQ.Toolkit.Plugins.ImageMapEditor.Views;

namespace BBQ.Toolkit.Plugins.ImageMapEditor
{
    [ToolboxItem(false)]
    public partial class Main : UserControl
    {
        private Graphics g;
        private Image image;
        private readonly ImageMap imageMap = new();
        private readonly Pen pen = new(Color.Blue, 2.0F);

        public Main()
        {
            InitializeComponent();
            tsBtnOpen.Image = CommonImages.OpenFolder_32x32;
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
            using var dialog = new FileNameInputDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
#pragma warning disable DF0021 // This is in fact being disposed. See Dispose() in Main.Designer.cs
                image = Image.FromFile(dialog.SelectedFileName);
#pragma warning restore DF0021

                pictureBox.Image = image;
                pictureBox.Width = image.Width;
                pictureBox.Height = image.Height;

#pragma warning disable DF0021 // This is in fact being disposed. See Dispose() in Main.Designer.cs
                g = pictureBox.CreateGraphics();
#pragma warning restore DF0021
            }
            else
            {
                LoadImage();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void tsBtnCircle_Click(object sender, EventArgs e)
        {
            using var form = new AddCircleForm(image);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AddHotSpot(form.HotSpot);
                DrawCircle(form.HotSpot.Center, form.HotSpot.Radius);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void tsBtnPolygon_Click(object sender, EventArgs e)
        {
            using var form = new AddPolygonForm(image);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AddHotSpot(form.HotSpot);
                DrawPolygon(form.HotSpot.Coordinates);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void tsBtnRectangle_Click(object sender, EventArgs e)
        {
            using var form = new AddRectangleForm(image);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AddHotSpot(form.HotSpot);
                DrawRectangle(form.HotSpot.TopLeft, form.HotSpot.BottomRight);
            }
        }

        private void tsBtnOpen_Click(object sender, EventArgs e)
        {

        }
    }
}