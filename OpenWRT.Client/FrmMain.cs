using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSH.Client;

namespace OpenWRT.Client
{
    public partial class FrmMain : Form
    {
        ClientManager clientManager = new ClientManager();

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
                string value = clientManager.GetSignal();

                cirPbSignal.Value = int.Parse(value) + 100;
                cirPbSignal.Text = value;
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
            timer1.Enabled = chkBoxAuto.Checked;
            btnSend.Enabled = !chkBoxAuto.Checked;
        }
    }
}
