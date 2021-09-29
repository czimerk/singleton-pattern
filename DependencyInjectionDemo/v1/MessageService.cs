using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public sealed class MessageService
    {
       
        private MessageService()
        {
            
        }

        private static readonly Lazy<MessageService> lazy 
            = new Lazy<MessageService>(() => new MessageService());
        public static MessageService Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        public bool Send(string message)
        {
            //Üzenet elküldése - függőség Connection
            var connection = Connection.Instance;
            return SendImpl(message, connection);
        }
        private bool SendImpl(string message, Connection conn)
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
