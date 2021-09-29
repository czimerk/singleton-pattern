using SingletonTestApp.Singleton;
using System;
using Xunit;

namespace SingletonTestApp_Test
{
    public class MessageServiceTests
    {
        [Fact]
        public void MessageServiceTest_Send()
        {
            var msgSvc = MessageServiceNew.Instance;
            Assert.True(msgSvc.Send("hello"));
        }

        [Fact]
        public void NemCsakMessageServiceTest_HanemMindenAmiAlattaVan()
        {
            var conn = Connection.Instance;
            conn.Open();
            var msgSvc = MessageServiceNew.Instance;
            msgSvc.Send("Hello");
            conn.Close();
        }
    }
}
