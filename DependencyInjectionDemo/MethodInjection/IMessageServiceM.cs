namespace DependencyInjectionDemo
{
    public interface IMessageServiceM
    {
        bool Send(string message, IConnectionM connection);
    }
}