using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH.Client
{
    interface IClientManager
    {
        void Connect(string host, string username, string password, int port);
        void Disconnect();
        string Send(string command);
    }
}
