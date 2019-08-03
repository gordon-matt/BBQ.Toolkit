using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Models
{
    public class PolygonHotSpot : ImageMapHotSpot
    {
        public PolygonHotSpot()
        {
            Coordinates = new List<Point>();
        }

        public IList<Point> Coordinates { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < Coordinates.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(",");
                }

                sb.AppendFormat("{0},{1}", Coordinates[i].X, Coordinates[i].Y);
            }

            return $@"<area shape=""polygon"" coords=""{sb}"" href=""{Url}"" alt=""{Title}"" />";
        }
    }
}