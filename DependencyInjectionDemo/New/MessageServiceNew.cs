using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public sealed class MessageServiceNew
    {
        public bool Send(string message)
        {
            var connection = new ConnectionNew();
            return SendImpl(message, connection);
        }
        private bool SendImpl(string message, ConnectionNew conn)
        {
            if (conn.IsOpen)
            {
                //üzenet küldés
                return true;
            }
            throw new InvalidOperationException("Cannot send message. Connection is not open");
        }
    }
}
