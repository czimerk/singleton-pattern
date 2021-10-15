using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonTestApp.Singleton
{
    public sealed class TestSingletonWithParam
    {
        private static int _singletonCount = 0;
        public static int SingletonCount { get => _singletonCount; }
        private static TestSingletonWithParam _singleton = null;
        private static object lockObject = new object();
        private TestSingletonWithParam(string arg)
        {
            _arg = arg;
            _singletonCount++;
        }

        private string _arg;
        public static TestSingletonWithParam GetInstance(string arg)
        {
            lock (lockObject)
            {
                if (_singleton == null)
                {
                    _singleton = new TestSingletonWithParam(arg);
                }
                return _singleton;
            }

        }
    }
}
