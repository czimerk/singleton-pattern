using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Services
{
    public class SingletonService : ISingletonService
    {
        private static int _instanceCount = 0;
        private readonly ITransientService _transientService;
        //public SingletonService(ITransientService transient)
        //{
        //    _instanceCount++;
        //    _transientService = transient;
        //}
        //runtime error: cannot consume
        //scoped service from singleton
        public SingletonService(ITransientService transientService)
        {
            _instanceCount++;
            _transientService = transientService;
        }
        public string DoJob(string job)
        {
            job += "'s done, instance count: " + _instanceCount;
            job += "   transient instance count: " + _transientService.InstanceCount;
            return job;
        }
    }
}
