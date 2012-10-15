namespace Interfaces.ChangeFieldSizeWatcher
{
    public interface IChangeFieldSizeSender
    {
        void AddNewListener(IChangeFieldSizeListener listener);
        void RemoveListener(IChangeFieldSizeListener listener);
        void SendSizeChanged();
    }
}
