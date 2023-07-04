using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;

namespace BBQ.Toolkit.Views;

public partial class HostForm : KryptonForm
{
    [ImportMany(typeof(IPlugin))]
    private readonly ICollection<IPlugin> plugins = new List<IPlugin>();

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

    private void pluginTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (e.Node.Tag == null)
        { return; }

        var plugin = e.Node.Tag as IPlugin;

        if (plugin is IUserControlPlugin)
        {
            var control = ((IUserControlPlugin)plugin).Content;
            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
        else if (plugin is IFormPlugin)
        {
            var formPlugin = (IFormPlugin)plugin;
            var form = formPlugin.Content;

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

    private void mnuToolsPluginSettings_Click(object sender, EventArgs e)
    {
        new SettingsForm().ShowDialog();
    }

    private void mnuToolsChoosePlugins_Click(object sender, EventArgs e)
    {
    }
}