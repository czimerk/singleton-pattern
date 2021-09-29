using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Services
{
    public class TransientService : ITransientService
    {
        private static int _instanceCount = 0;

        public TransientService()
        {
            _instanceCount++;
        }

        public int InstanceCount { get => _instanceCount;}


        public string DoJob(string job)
        {
            job += "'s done, instance count: " + _instanceCount;
            return job;
        }
    }
}
