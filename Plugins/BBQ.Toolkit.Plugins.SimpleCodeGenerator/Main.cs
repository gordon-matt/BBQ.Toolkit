using BBQ.Toolkit.Common.Properties;
using Extenso;
using FastColoredTextBoxNS;
using Fluid;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator;

[ToolboxItem(false)]
public partial class Main : UserControl
{
    private static readonly FluidParser parser;
    private static readonly TemplateOptions templateOptions;
    private object model = null;

    static Main()
    {
        parser = new FluidParser();
        templateOptions = new TemplateOptions
        {
            MemberAccessStrategy = new UnsafeMemberAccessStrategy()
        };
    }

    public Main()
    {
        InitializeComponent();
        tsBtnOpenTemplate.Image = CommonImages.OpenFolder_32x32;
        tsBtnNewTemplate.Image = CommonImages.AddFile_32x32;
        tsBtnSaveResult.Image = CommonImages.Save_32x32;

        foreach (var lang in EnumExtensions.GetValues<Language>())
        {
            var toolStripMenuItem = new ToolStripMenuItem
            {
                Name = $"tsMenuItem_{lang}",
                Size = new Size(180, 22),
                Text = lang.ToString(),
                Tag = lang
            };

            tsDDBtnLanguage.DropDownItems.Add(toolStripMenuItem);
            toolStripMenuItem.Click += LanguageMenuItem_Click;
        }
    }

    private void LanguageMenuItem_Click(object sender, System.EventArgs e)
    {
        var lang = (Language)((ToolStripMenuItem)sender).Tag;
        ChangeLanguage(fctTemplate, lang);
        ChangeLanguage(fctResults, lang);
    }

    private static void ChangeLanguage(FastColoredTextBox fctb, Language lang)
    {
        fctb.Language = lang;
        fctb.ClearStylesBuffer();
        fctb.Range.ClearStyle(StyleIndex.All);
        fctb.OnSyntaxHighlight(new TextChangedEventArgs(fctb.Range));
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void tsBtnOpenTemplate_Click(object sender, System.EventArgs e)
    {
        if (dlgOpenFile.ShowDialog() == DialogResult.OK)
        {
            fctTemplate.Text = File.ReadAllText(dlgOpenFile.FileName);
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void tsBtnNewTemplate_Click(object sender, System.EventArgs e)
    {
        fctTemplate.Text = null;
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void tsBtnSaveResult_Click(object sender, System.EventArgs e)
    {
        if (dlgSaveFile.ShowDialog() == DialogResult.OK)
        {
            fctTemplate.Text.ToFile(dlgSaveFile.FileName);
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void tsBtnGenerateCode_Click(object sender, System.EventArgs e)
    {
        if (model == null)
        {
            MessageBox.Show("Add some data first!", "No data!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        if (parser.TryParse(fctTemplate.Text, out var template, out string error))
        {
            var context = new TemplateContext(model, templateOptions);
            fctResults.Text = template.Render(context);
            tabControl.SelectTab(1);
        }
        else
        {
            MessageBox.Show(
                $"Unable to parse the template. Please check and fix any errors. {error}.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void tsDDBtnDataListStrings_Click(object sender, System.EventArgs e)
    {
        using var form = new InputStringsForm();
        if (form.ShowDialog() == DialogResult.OK)
        {
            txtModelHelp.Text = form.ModelStructure;
            model = new { Model = form.Data };
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void tsDDBtnDataCSV_Click(object sender, System.EventArgs e)
    {
        using var form = new InputCsvForm();
        if (form.ShowDialog() == DialogResult.OK)
        {
            txtModelHelp.Text = form.ModelStructure;
            model = new { Model = form.Data };
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void tsDDBtnDataJSON_Click(object sender, System.EventArgs e)
    {
        using var form = new InputJsonForm();
        if (form.ShowDialog() == DialogResult.OK)
        {
            txtModelHelp.Text = form.ModelStructure;
            model = new { Model = form.Data };
        }
    }
}