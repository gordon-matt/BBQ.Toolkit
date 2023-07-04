namespace BBQ.Toolkit.Common;

public interface ISettingsControl
{
    UserControl ControlContent { get; }

    void Save();
}