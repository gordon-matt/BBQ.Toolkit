using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BBQ.Toolkit.Common.Properties;
using Extenso;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator
{
    [ToolboxItem(false)]
    public partial class Main : UserControl
    {
        private readonly Regex rgxToLower = new(@"\[\[ToLower:(?<value>(?:(?!\[\[).)*)\]\]", RegexOptions.Compiled);
        private readonly Regex rgxToUpper = new(@"\[\[ToUpper:(?<value>(?:(?!\[\[).)*)\]\]", RegexOptions.Compiled);
        private readonly Regex rgxToPascal = new(@"\[\[ToPascal:(?<value>(?:(?!\[\[).)*)\]\]", RegexOptions.Compiled);
        private readonly Regex rgxToCamel = new(@"\[\[ToCamel:(?<value>(?:(?!\[\[).)*)\]\]", RegexOptions.Compiled);

        public Main()
        {
            InitializeComponent();
            btnCopy.Values.Image = CommonImages.Copy_32x32;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            string[] split = txtInput.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            int number = 1;
            foreach (string item in split)
            {
                string text = txtTemplate.Text.Replace("[[N]]", number.ToString());
                sb.Append($"{string.Format(text, item)}{Environment.NewLine}");
                number++;
            }

            string newText = sb.ToString();
            foreach (Match match in rgxToLower.Matches(sb.ToString()))
            {
                var rgxReplace = new Regex(match.Value);
                newText = rgxReplace.Replace(newText, match.Groups["value"].Value.ToLowerInvariant());
            }

            foreach (Match match in rgxToUpper.Matches(newText))
            {
                var rgxReplace = new Regex(match.Value);
                newText = rgxReplace.Replace(newText, match.Groups["value"].Value.ToUpperInvariant());
            }

            foreach (Match match in rgxToPascal.Matches(newText))
            {
                var rgxReplace = new Regex(match.Value);
                newText = rgxReplace.Replace(newText, match.Groups["value"].Value.ToPascalCase());
            }

            foreach (Match match in rgxToCamel.Matches(newText))
            {
                string camel = match.Groups["value"].Value.ToPascalCase();
                char c = camel[0];
                string lowerC = c.ToString().ToLowerInvariant();
                camel = camel.Remove(0, 1);
                camel = string.Concat(lowerC, camel); //TODO: Make more efficient

                newText = newText.Replace(match.Value, camel);
            }

            txtOutput.Text = newText;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetData("Text", txtOutput.Text);
        }
    }
}