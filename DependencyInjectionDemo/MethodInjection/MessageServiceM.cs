using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public sealed class MessageServiceM : IMessageServiceM
    {
        public bool Send(string message, IConnectionM connection)
        {
            return SendImpl(message, connection);
        }
        private bool SendImpl(string message, IConnectionM connection)
        {
            if (connection.IsOpen)
            {
                //üzenet küldés
                return true;
            }
            throw new InvalidOperationException("Cannot send message. Connection is not open");
        }
    }
}
