namespace DependencyInjectionDemo
{
    public interface IConnectionC
    {
        bool IsOpen { get; }

        void Close();
        void Open();
    }
}