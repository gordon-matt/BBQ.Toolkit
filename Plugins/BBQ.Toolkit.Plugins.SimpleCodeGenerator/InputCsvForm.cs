using BBQ.Toolkit.Common.Properties;
using CsvHelper;
using CsvHelper.Configuration;
using Extenso;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator;

public partial class InputCsvForm : Form, IDataInputForm<JArray>
{
    public InputCsvForm()
    {
        InitializeComponent();
        btnOK.Values.Image = CommonImages.OK_32x32;
        btnCancel.Values.Image = CommonImages.Cancel_32x32;
        btnBrowse.Values.Image = CommonImages.Browse_32x32;
    }

    public string ModelStructure { get; private set; }

    public JArray Data { get; private set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnBrowse_Click(object sender, EventArgs e)
    {
        if (dlgOpenFile.ShowDialog() == DialogResult.OK)
        {
            txtCsvFile.Text = dlgOpenFile.FileName;
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnCancel_Click(object sender, EventArgs e) => Close();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnOK_Click(object sender, EventArgs e)
    {
        var data = ReadCsv(dlgOpenFile.FileName);

        var sb = new StringBuilder();
        sb.AppendLine("Properties for each item in 'Model' are as follows: ");

        foreach (DataColumn column in data.Columns)
        {
            column.ColumnName = column.ColumnName.Trim().ToPascalCase();
            sb.AppendLine($"- {column.ColumnName}");
        }

        Data = JArray.Parse(data.JsonSerialize());
        ModelStructure = sb.ToString();

        Close();
    }

    private DataTable ReadCsv(string filePath)
    {
        using var fileStream = File.OpenRead(filePath);
        using var streamReader = new StreamReader(fileStream);
        using var csvReader = new CsvReader(streamReader, new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            TrimOptions = TrimOptions.Trim,
            HasHeaderRecord = cbHasHeaderRow.Enabled,
            Delimiter = txtDelimiter.Text
        });
        csvReader.Context.TypeConverterOptionsCache.GetOptions<string>().NullValues.Add(string.Empty);
        using var csvDataReader = new CsvDataReader(csvReader);

        var table = new DataTable();
        table.Load(csvDataReader);
        return table;
    }
}