using System.Windows.Forms;

namespace BBQ.Toolkit.Common
{
    public enum ShowAs
    {
        Normal,
        Dialog
    }
    public interface IFormPlugin: IPlugin
    {
        Form Content { get; }
        ShowAs ShowAs { get; }
    }
}