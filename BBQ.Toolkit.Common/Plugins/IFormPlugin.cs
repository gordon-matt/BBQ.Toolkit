namespace BBQ.Toolkit.Common.Plugins;

public enum ShowAs
{
    Normal,
    Dialog
}

public interface IFormPlugin : IPlugin
{
    Form Content { get; }

    ShowAs ShowAs { get; }
}