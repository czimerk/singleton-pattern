using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonTestApp
{
    class TestSingleton
    {
        private static int _singletonCount = 0;
        public static int SingletonCount { get => _singletonCount; }

        private TestSingleton()
        {
            _singletonCount++;
        }

        private static TestSingleton _singleton = new TestSingleton();

        public static TestSingleton GetInstance() { return _singleton; }
    }
}
