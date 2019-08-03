using System.Drawing;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Models
{
    public class CircleHotSpot : ImageMapHotSpot
    {
        public Point Center { get; set; }

        public int Radius { get; set; }

        public override string ToString()
        {
            return $@"<area shape=""circle"" coords=""{Center.X},{Center.Y},{Radius}"" href=""{Url}"" alt=""{Title}"" />";
        }
    }
}