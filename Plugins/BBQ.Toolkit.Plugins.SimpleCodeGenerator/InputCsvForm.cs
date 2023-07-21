using System;
using System.Data;
using System.Windows.Forms;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator;

public partial class InputCsvForm : Form, IDataInputForm<DataTable>
{
    public InputCsvForm()
    {
        InitializeComponent();
    }

    public string ModelStructure => throw new NotImplementedException();

    public DataTable Data => throw new NotImplementedException();
}