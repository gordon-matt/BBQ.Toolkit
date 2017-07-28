using System.Drawing;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Models
{
    public class CircleHotSpot : ImageMapHotSpot
    {
        public Point Center { get; set; }

        public int Radius { get; set; }

        public override string ToString()
        {
            return string.Format(@"<area shape=""circle"" coords=""{0},{1},{2}"" href=""{3}"" alt=""{4}"" />",
                Center.X, Center.Y, Radius, Url, Title);
        }
    }
}