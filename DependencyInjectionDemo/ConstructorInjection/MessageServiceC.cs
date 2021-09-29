using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public sealed class MessageServiceC
    {
        private readonly IConnectionC _connection;

        public MessageServiceC(IConnectionC connection)
        {
            _connection = connection;
        }
        public bool Send(string message)
        {
            return SendImpl(message);
        }
        private bool SendImpl(string message)
        {
            if (_connection.IsOpen)
            {
                //üzenet küldés
                return true;
            }
            throw new InvalidOperationException("Cannot send message. Connection is not open");
        }
    }
}
