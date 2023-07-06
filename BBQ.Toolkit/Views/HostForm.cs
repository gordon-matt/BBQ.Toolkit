using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using BBQ.Toolkit.Common.Plugins;

namespace BBQ.Toolkit.Views;

public partial class HostForm : KryptonForm
{
    [ImportMany(typeof(IPlugin))]
    private readonly ICollection<IPlugin> plugins = new List<IPlugin>();

    private Dictionary<string, UserControl> userControls = new();

    public HostForm()
    {
        InitializeComponent();

        string pluginsPath = Path.Combine(Application.StartupPath, "Plugins");
        if (!Directory.Exists(pluginsPath))
        {
            Directory.CreateDirectory(pluginsPath);
        }

        using var mainAssemblyCatalog = new AssemblyCatalog(typeof(Program).Assembly);
        using var pluginsDirectoryCatalog = new DirectoryCatalog(pluginsPath);
        using var aggregateCatalog = new AggregateCatalog(mainAssemblyCatalog, pluginsDirectoryCatalog);
        using var container = new CompositionContainer(aggregateCatalog);
        container.ComposeParts(this);

        Program.Plugins = plugins;
        plugins = null;

        foreach (var plugin in Program.Plugins)
        {
            pluginTreeView.AddPlugin(plugin);
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void pluginTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (e.Node.Tag == null)
        { return; }

        var plugin = e.Node.Tag as IPlugin;

        if (plugin is IUserControlPlugin userControlPlugin)
        {
            UserControl control;
            if (userControls.ContainsKey(plugin.Title))
            {
                control = userControls[plugin.Title];
            }
            else
            {
#pragma warning disable DF0010 // Disposed when userControls dictionary is disposed
                control = userControlPlugin.GetContent();
#pragma warning restore DF0010 // 

                userControls.Add(plugin.Title, control);
            }

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
        else if (plugin is IFormPlugin formPlugin)
        {
            using var form = formPlugin.Content;
            if (formPlugin.ShowAs == ShowAs.Dialog)
            {
                form.ShowDialog();
            }
            else
            {
                form.Show();
            }
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void mnuToolsPluginSettings_Click(object sender, EventArgs e)
    {
        using var form = new SettingsForm();
        form.ShowDialog();
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void mnuToolsChoosePlugins_Click(object sender, EventArgs e)
    {
    }
}