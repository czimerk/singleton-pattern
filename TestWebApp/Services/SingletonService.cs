using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Services
{
    public class SingletonService : ISingletonService
    {
        public SingletonService(ITransientService transient)
        {

        }
        //runtime error: cannot consume scoped service from singleton
        //public SingletonService(IScopedService scoped)
        //{

        //}
        public string DoJob(string job)
        {
            job += "'s done";
            return job;
        }
    }
}
