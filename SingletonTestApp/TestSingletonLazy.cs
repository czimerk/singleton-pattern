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
            Thread.Sleep(200);
            _singletonCount++;
        }

        private static TestSingletonLazy _singleton = null;
        public static TestSingletonLazy Instance
        {
            get
            {
                if (_singleton == null)
                {
                    _singleton = new TestSingletonLazy();
                }
                return _singleton;
            }

        }
    }
}
