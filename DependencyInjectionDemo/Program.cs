using DependencyInjectionDemo;
using System;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor Injection
            var msgService = new MessageServiceC(new ConnectionC());
            msgService.Send("hello");

            //Property Injection
            var svcP = new MessageServiceP();
            svcP.ActualConnection = new ConnectionP();
            svcP.Send("hello");
            //másik Connection beállítás
            svcP.ActualConnection = new ConnectionP();
            svcP.Send("hello 2");

            //Method Injection
            IMessageServiceM svcM = new MessageServiceM();
            IConnectionM connM = new ConnectionM();
            svcM.Send("hello", connM);
        }
    }
}
