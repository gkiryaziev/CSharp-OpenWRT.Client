using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSH.Client;
using Xunit;

namespace SSH.Client.Tests
{
    public class ClientManagerTests
    {
        private ClientManager clientManager = new ClientManager();

        [Fact]
        public void Connect()
        {
            clientManager.Connect("192.168.20.1", "root", "wrtAdm1n", 22);

            bool expected = true;

            bool actual = clientManager.IsConnected;

            clientManager.Disconnect();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Send()
        {
            clientManager.Connect("192.168.20.1", "root", "wrtAdm1n", 22);

            string expected = "/root\n";

            string actual = clientManager.Send("pwd");

            clientManager.Disconnect();

            Assert.Equal(expected, actual);
        }
    }
}
