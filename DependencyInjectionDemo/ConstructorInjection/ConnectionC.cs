using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public sealed class ConnectionC : IConnectionC
    {
        private bool isOpen;

        public void Open()
        {
            isOpen = true;
        }
        public void Close()
        {
            isOpen = false;
        }

        public bool IsOpen { get => isOpen; }

    }
}
