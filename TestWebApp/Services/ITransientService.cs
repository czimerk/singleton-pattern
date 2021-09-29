namespace TestWebApp.Services
{
    public interface ITransientService
    {
        int InstanceCount { get; }

        string DoJob(string job);
    }
}