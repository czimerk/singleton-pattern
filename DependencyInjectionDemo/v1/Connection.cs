using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public sealed class Connection
    {

        private Connection()
        {

        }

        private static readonly Lazy<Connection> lazy = new Lazy<Connection>(() => new Connection());
        private bool isOpen;

        public static Connection Instance
        {
            get
            {
                return lazy.Value;
            }
        }

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
