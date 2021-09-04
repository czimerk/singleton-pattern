using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonTestApp
{
    class TestSingletonLazy
    {
        private static int _singletonCount = 0;
        public static int SingletonCount { get => _singletonCount; }

        private TestSingletonLazy()
        {
            _singletonCount++;
        }

        private static TestSingletonLazy _singleton = null;

        public static TestSingletonLazy GetInstance()
        {
            if (_singleton == null)
            {
                Thread.Sleep(200);
                _singleton = new TestSingletonLazy();
            }
            return _singleton;
        }
    }
}
