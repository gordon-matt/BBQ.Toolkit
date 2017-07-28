using System.Windows.Forms;

namespace BBQ.Toolkit.Common
{
    public interface IUserControlPlugin: IPlugin
    {
        UserControl Content { get; }
    }
}