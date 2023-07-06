namespace BBQ.Toolkit.Common.Plugins;

public interface IUserControlPlugin : IPlugin
{
    UserControl GetContent();
}