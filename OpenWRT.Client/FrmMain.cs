using SSH.Client;
using System;
using System.Windows.Forms;

namespace OpenWRT.Client
{
    public partial class FrmMain : Form
    {
        readonly ClientManager clientManager = new ClientManager();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            clientManager.Connect(txtHost.Text, txtUsername.Text, txtPassword.Text, int.Parse(txtPort.Text));

            txtLog.Text += clientManager.IsConnected ? "Connected." : clientManager.Message;
            txtLog.Text += Environment.NewLine;
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            clientManager.Disconnect();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            txtLog.Text += clientManager.Send(txtCommand.Text).Trim();
            txtLog.Text += Environment.NewLine;
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (clientManager.IsConnected)
            {
                DataModel data = clientManager.GetData();

                if (int.TryParse(data.Signal, out int signal))
                {
                    cirPbSignal.Value = signal + 100;
                    cirPbSignal.Text = data.Signal;
                }

                if (int.TryParse(data.TX_Bitrate, out int txBitrate))
                {
                    cirPbTXBitrate.Value = txBitrate;
                    cirPbTXBitrate.Text = data.TX_Bitrate;
                }

                if (int.TryParse(data.RX_Bitrate, out int rxBitrate))
                {
                    cirPbRXBitrate.Value = rxBitrate;
                    cirPbRXBitrate.Text = data.RX_Bitrate;
                }
            }
        }

        private void ChkBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = chkBoxAuto.Checked;
            btnSend.Enabled = !chkBoxAuto.Checked;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientManager.Disconnect();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            chkBoxAuto.Checked = true;

            timer1.Enabled = chkBoxAuto.Checked;
            btnSend.Enabled = !chkBoxAuto.Checked;
        }
    }
}
