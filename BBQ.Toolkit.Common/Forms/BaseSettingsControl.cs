namespace BBQ.Toolkit.Common.Forms;

public abstract class BaseSettingsControl : ISettingsControl
{
    private bool isDisposed;

    public BaseSettingsControl()
    {
        ControlContent = GetContent();
    }

    public virtual UserControl ControlContent { get; protected set; }

    public abstract void Save();

    #region IDisposable Members

    protected virtual void Dispose(bool disposing)
    {
        if (!isDisposed)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                ControlContent?.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            isDisposed = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~BaseUserControlPlugin()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    #endregion IDisposable Members

    protected abstract UserControl GetContent();
}