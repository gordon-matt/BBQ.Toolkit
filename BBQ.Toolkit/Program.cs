using BBQ.Toolkit.Common.Plugins;

namespace BBQ.Toolkit;

internal class Program
{
    public static IEnumerable<IPlugin> Plugins { get; set; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.SetCompatibleTextRenderingDefault(false);

        using var form = new Views.HostForm();
        Application.Run(form);
    }
}