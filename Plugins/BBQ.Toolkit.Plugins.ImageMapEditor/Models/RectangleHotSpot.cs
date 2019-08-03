using System.Drawing;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Models
{
    public class RectangleHotSpot : ImageMapHotSpot
    {
        public Point TopLeft { get; set; }

        public Point BottomRight { get; set; }

        public override string ToString()
        {
            return $@"<area shape=""rect"" coords=""{TopLeft.X},{TopLeft.Y},{BottomRight.X},{BottomRight.Y}"" href=""{Url}"" alt=""{Title}"" />";
        }
    }
}