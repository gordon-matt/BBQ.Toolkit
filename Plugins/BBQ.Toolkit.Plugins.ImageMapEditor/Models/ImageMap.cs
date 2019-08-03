using System.Collections.Generic;
using System.Text;

namespace BBQ.Toolkit.Plugins.ImageMapEditor.Models
{
    public class ImageMap
    {
        public ImageMap()
        {
            HotSpots = new List<ImageMapHotSpot>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public List<ImageMapHotSpot> HotSpots { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat(@"<map id=""{0}"" name=""{1}"">", Id, Name);

            foreach (var hotSpot in HotSpots)
            {
                sb.AppendLine();
                sb.Append("    ");
                sb.Append(hotSpot);
            }

            sb.AppendLine();
            sb.Append("</map>");
            return sb.ToString();
        }
    }
}