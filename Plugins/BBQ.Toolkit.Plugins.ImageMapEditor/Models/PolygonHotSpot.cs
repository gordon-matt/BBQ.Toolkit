using System.Drawing;
using System.Text;
using System.Collections.Generic;

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

            return string.Format(@"<area shape=""polygon"" coords=""{0}"" href=""{1}"" alt=""{2}"" />", sb, Url, Title);
        }
    }
}