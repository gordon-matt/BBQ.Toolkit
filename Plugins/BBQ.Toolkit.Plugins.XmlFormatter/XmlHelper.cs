using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace BBQ.Toolkit.Plugins.XmlFormatter
{
    public static class XmlHelper
    {
        public static string EscapeXML(string xml)
        {
            string text = xml;

            text = text.Replace("&", "&amp;");
            text = text.Replace("<", "&lt;");
            text = text.Replace(">", "&gt;");
            text = text.Replace("\"", "&quot;");
            text = text.Replace("'", "&apos;");

            return text;
        }
        public static string UnEscapeXML(string xml)
        {
            string text = xml;

            text = text.Replace("&amp;", "&");
            text = text.Replace("&lt;", "<");
            text = text.Replace("&gt;", ">");
            text = text.Replace("&quot;", "\"");
            text = text.Replace("&apos;", "'");

            return text;
        }
        public static string PrettyPrint(string xml)
        {
            //load unformatted xml into a dom
            XDocument document = XDocument.Parse(xml);

            //will hold formatted xml
            StringBuilder stringBuilder = new StringBuilder();

            //pumps the formatted xml into the StringBuilder above
            StringWriter stringWriter = new StringWriter(stringBuilder);

            //does the formatting
            XmlTextWriter xmlTextWriter = null;

            try
            {
                //point the xmlTextWriter at the StringWriter
                xmlTextWriter = new XmlTextWriter(stringWriter);

                //we want the output formatted
                xmlTextWriter.Formatting = Formatting.Indented;

                //get the dom to dump its contents into the xmlTextWriter 
                document.WriteTo(xmlTextWriter);
            }
            finally
            {
                //clean up even if error
                if (xmlTextWriter != null)
                {
                    xmlTextWriter.Close();
                }
            }

            //return the formatted xml
            return stringBuilder.ToString();
        }
    }
}
