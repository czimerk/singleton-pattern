using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonTestApp.Singleton
{
    class MessageService : IMessageService
    {
       
        private MessageService()
        {
            
        }

        private static readonly Lazy<MessageService> lazy = new Lazy<MessageService>(() => new MessageService());
        public static MessageService Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public bool Send(string message)
        {

            return true;
        }
    }
}
