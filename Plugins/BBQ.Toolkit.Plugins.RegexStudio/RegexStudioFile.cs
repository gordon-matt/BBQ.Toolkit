using System.IO;
using System.Xml.Serialization;
using Kore;
using Kore.IO;

namespace BBQ.Toolkit.Plugins.RegexStudio
{
    [XmlRoot(ElementName = "StudioFile")]
    public class RegexStudioFile
    {
        // Methods
        public static RegexStudioFile Load(string filePath)
        {
            var file = new FileInfo(filePath).XmlDeserialize<RegexStudioFile>();
            file.FilePath = filePath;
            return file;
        }

        public bool Save(string filePath)
        {
            FilePath = filePath;
            return this.XmlSerialize(filePath);
        }

        // Properties
        public bool Compiled { get; set; }

        public bool ECMAScript { get; set; }

        public bool ExplicitCapture { get; set; }

        [XmlIgnore]
        public string FilePath { get; set; }

        public bool IgnoreCase { get; set; }

        public bool IgnorePatternWhitespace { get; set; }

        public string MatchText { get; set; }

        public bool Multiline { get; set; }

        public string Pattern { get; set; }

        public string ReplacementString { get; set; }

        public bool RightToLeft { get; set; }

        public bool Singleline { get; set; }
    }
}