using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonTestApp
{
    class TestSingletonLazyB
    {
        private static int _singletonCount = 0;
        public static int SingletonCount { get => _singletonCount; }

        private TestSingletonLazyB()
        {
            _singletonCount++;
        }

        private static readonly Lazy<TestSingletonLazyB> lazy = new Lazy<TestSingletonLazyB>(() => new TestSingletonLazyB());
        public static TestSingletonLazyB Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
