namespace DependencyInjectionDemo
{
    public interface IConnectionM
    {
        bool IsOpen { get; }

        void Close();
        void Open();
    }
}