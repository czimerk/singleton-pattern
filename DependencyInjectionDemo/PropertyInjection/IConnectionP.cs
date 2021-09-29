namespace DependencyInjectionDemo
{
    public interface IConnectionP
    {
        bool IsOpen { get; }

        void Close();
        void Open();
    }
}