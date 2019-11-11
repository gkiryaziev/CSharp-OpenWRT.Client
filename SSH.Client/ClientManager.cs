using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH.Client
{
    public class ClientManager : IClientManager
    {
        private SshClient sshClient = null;

        public bool IsConnected = false;
        public string Message = string.Empty;

        public void Connect(string host, string username, string password, int port = 22)
        {
            try
            {
                if (sshClient == null)
                {
                    sshClient = new SshClient(host, port, username, password)
                    {
                        // KeepAliveInterval = new TimeSpan(0, 0, 20)
                    };
                }

                if (!sshClient.IsConnected)
                {
                    sshClient.Connect();
                    IsConnected = true;
                    Message = string.Empty;
                }
            }
            catch (Exception ex)
            {
                _disconnect();
                IsConnected = false;
                Message = ex.Message;
            }
        }

        public void Disconnect()
        {
            _disconnect();
            IsConnected = false;
        }

        private void _disconnect()
        {
            if (sshClient != null)
            {
                if (sshClient.IsConnected)
                {
                    sshClient.Disconnect();
                }

                sshClient.Dispose();
                sshClient = null;
            }
        }

        public string Send(string command)
        {
            if (sshClient != null && sshClient.IsConnected)
            {
                IsConnected = true;
                Message = sshClient.CreateCommand(command).Execute();
            }
            else
            {
                IsConnected = false;
                Message = "Not connected.";
            }

            return Message;
        }

        public string GetSignal()
        {
            string raw_data = Send("iw dev wlan0 station dump");

            string[] array_data = raw_data.Split('\n');

            for (int i = 0; i < array_data.Length; ++i)
            {
                array_data[i] = array_data[i].Trim();
            }

            int indexSignal = Array.FindIndex(array_data, row => row.StartsWith("signal:"));

            if (indexSignal >= 0)
            {
                return array_data[indexSignal].Split(':')[1].Split('[')[0].Trim();
            }
            else
                return string.Empty;
        }
    }
}
