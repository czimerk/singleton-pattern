using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Services
{
    public class ScopedService : IScopedService
    {
        private static int _instanceCount = 0;
        //private readonly ITransientService _transientService;
        //public ScopedService(ITransientService transient)
        public ScopedService()
        {
            _instanceCount++;
            //_transientService = transient;
        }
        public string DoJob(string job)
        {
            job += "'s done, instance count: " + _instanceCount;
            return job;
        }
    }
}
