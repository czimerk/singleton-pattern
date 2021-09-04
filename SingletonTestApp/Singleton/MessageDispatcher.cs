using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonTestApp.Singleton
{
    class MessageDispatcher
    {
        private readonly IMessageService _service;

        public MessageDispatcher(IMessageService service)
        {
            _service = service;
        }
    }
}
