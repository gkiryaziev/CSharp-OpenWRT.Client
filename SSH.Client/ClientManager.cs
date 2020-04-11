using Renci.SshNet;
using System;

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

        public DataModel GetData()
        {
            DataModel data = new DataModel();
			
			// get raw data
            string raw_data = Send("iw dev wlan0 station dump");
			// split raw data by lines
            string[] array_data = raw_data.Split('\n');
			// trim raw lines
            for (int i = 0; i < array_data.Length; ++i)
            {
                array_data[i] = array_data[i].Trim();
            }

            // get 'signal'
            data.Signal = GetSignal(array_data);
            // get 'tx bitrate'
            data.TX_Bitrate = GetTX_Bitrate(array_data);
            // get 'rx bitrate'
            data.RX_Bitrate = GetRX_Bitrate(array_data);

            return data;
        }

        private string GetSignal(string[] data)
        {
            // get raw line 'signal'
            int index = Array.FindIndex(data, row => row.StartsWith("signal:"));
            // split, trim raw line 'signal'
            if (index >= 0)
                return data[index].Split(':')[1].Split('[')[0].Trim();
            else
                return string.Empty;
        }

        private string GetTX_Bitrate(string[] data)
        {
            int index = Array.FindIndex(data, row => row.StartsWith("tx bitrate:"));
            // split, trim raw line 'tx bitrate'
            if (index >= 0)
                return data[index].Split(':')[1].Trim().Split(' ')[0].Trim().Split('.')[0];
            else
                return string.Empty;
        }

        private string GetRX_Bitrate(string[] data)
        {
            int index = Array.FindIndex(data, row => row.StartsWith("rx bitrate:"));
            // split, trim raw line 'rx bitrate'
            if (index >= 0)
                return data[index].Split(':')[1].Trim().Split(' ')[0].Trim().Split('.')[0];
            else
                return string.Empty;
        }
    }
}
