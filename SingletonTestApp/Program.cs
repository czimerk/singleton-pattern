using SingletonTestApp.Singleton;
using System;
using System.Threading.Tasks;

namespace SingletonTestApp
{
    //class Te : TestSingletonLazy
    //{
    //    private Te()
    //    {

    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton lekérése előtt példányok száma:");

            Console.WriteLine(TestSingleton.SingletonCount);
            TestSingleton s1 = TestSingleton.GetInstance();
            TestSingleton s2 = TestSingleton.GetInstance();

            Console.WriteLine("Singleton lekérése után példányok száma:");
            Console.WriteLine(TestSingleton.SingletonCount);
            Console.WriteLine("Azonos példány? " + (ReferenceEquals(s1, s2) ? "igen" : "nem (upszi)"));


            //Lazy loading nem szálbiztos singletonnal
            TestSingletonLazy s4 = null;
            TestSingletonLazy s5 = null;
            var t1 = Task.Factory.StartNew(() => s4 = TestSingletonLazy.Instance);
            var t2 = Task.Factory.StartNew(() => s5 = TestSingletonLazy.Instance);
            Task.WaitAll(new Task[2]{ t1, t2 });
            Console.WriteLine("Azonos példány? " + (ReferenceEquals(s4, s5) ? "igen" : "nem (upszi)"));
            Console.WriteLine("Singletonok száma: " + TestSingletonLazy.SingletonCount);


            //Thread-safe singleton
            TestSingletonLazyT s6 = null;
            TestSingletonLazyT s7 = null;
            var t3 = Task.Factory.StartNew(() => s6 = TestSingletonLazyT.GetInstance());
            var t4 = Task.Factory.StartNew(() => s7 = TestSingletonLazyT.GetInstance());
            Task.WaitAll(new Task[2] { t3, t4 });
            Console.WriteLine("Azonos példány? " + (ReferenceEquals(s6, s7) ? "igen" : "nem (upszi)"));
            Console.WriteLine("Singletonok száma: " + TestSingletonLazyT.SingletonCount);


            //Built in lazy
            TestSingletonLazyB s8 = null;
            TestSingletonLazyB s9 = null;
            var t5 = Task.Factory.StartNew(() => s8 = TestSingletonLazyB.Instance);
            var t6 = Task.Factory.StartNew(() => s9 = TestSingletonLazyB.Instance);
            Task.WaitAll(new Task[2] { t5, t6 });
            Console.WriteLine("Azonos példány? " + (ReferenceEquals(s8, s9) ? "igen" : "nem (upszi)"));
            Console.WriteLine("Singletonok száma: " + TestSingletonLazyB.SingletonCount);


            //Connection, MessageService
            var conn = Connection.Instance;
            conn.Open();
            var msgSvc = MessageServiceNew.Instance;
            msgSvc.Send("Hello");
            conn.Close();

        }

    }
}
