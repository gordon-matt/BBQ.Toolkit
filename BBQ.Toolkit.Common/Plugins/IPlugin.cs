using BBQ.Toolkit.Common.Forms;

namespace BBQ.Toolkit.Common.Plugins;

public interface IPlugin
{
    string Title { get; }

    string Description { get; }

    string Group { get; }

    string SubGroup { get; }

    Image Icon { get; }

    ISettingsControl SettingsControl { get; }
}