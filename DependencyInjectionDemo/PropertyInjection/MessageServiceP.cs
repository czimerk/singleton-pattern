using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public sealed class MessageServiceP
    {
        public IConnectionP ActualConnection { get; set; }

        public MessageServiceP()
        {
            
        }
        public bool Send(string message)
        {
            return SendImpl(message);
        }
        private bool SendImpl(string message)
        {
            if (ActualConnection.IsOpen)
            {
                //üzenet küldés
                return true;
            }
            throw new InvalidOperationException("Cannot send message. Connection is not open");
        }
    }
}
