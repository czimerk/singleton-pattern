﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Services
{
    public class ScopedService : IScopedService
    {
       
        public string DoJob(string job)
        {
            job += "'s done";
            return job;
        }
    }
}