namespace BBQ.Toolkit.Common;

public interface IUserControlPlugin : IPlugin
{
    UserControl Content { get; }
}