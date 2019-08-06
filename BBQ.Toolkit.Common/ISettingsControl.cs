using System.Windows.Forms;

namespace BBQ.Toolkit.Common
{
    public interface ISettingsControl
    {
        UserControl ControlContent { get; }

        void Save();
    }
}