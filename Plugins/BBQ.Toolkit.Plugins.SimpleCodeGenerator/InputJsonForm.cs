using System;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator;

public partial class InputJsonForm : Form, IDataInputForm<JsonObject>
{
    public InputJsonForm()
    {
        InitializeComponent();
    }

    public string ModelStructure => throw new NotImplementedException();

    public JsonObject Data => throw new NotImplementedException();
}