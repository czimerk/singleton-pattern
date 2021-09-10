using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonTestApp
{
    /// <summary>
    /// Thread safe version of singleton
    /// </summary>
    public sealed class TestSingletonLazyT
    {
        private static int _singletonCount = 0;
        public static int SingletonCount { get => _singletonCount; }

        private TestSingletonLazyT()
        {
            Thread.Sleep(200);
            _singletonCount++;
        }

        private static TestSingletonLazyT _singleton = null;
        private static object lockObject = new object();

        public static TestSingletonLazyT GetInstance()
        {
            lock (lockObject)
            {
                if (_singleton == null)
                {
                    _singleton = new TestSingletonLazyT();
                }
                return _singleton;
            }
           
        }
    }
}
