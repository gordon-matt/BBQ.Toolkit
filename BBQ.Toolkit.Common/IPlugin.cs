namespace BBQ.Toolkit.Common;

public interface IPlugin
{
    string Title { get; }

    string Description { get; }

    string Group { get; }

    string SubGroup { get; }

    Image Icon { get; }

    ISettingsControl SettingsControl { get; }
}