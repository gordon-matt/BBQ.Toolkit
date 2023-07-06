namespace BBQ.Toolkit.Common.Forms;

public interface ISettingsControl : IDisposable
{
    UserControl ControlContent { get; }

    void Save();
}