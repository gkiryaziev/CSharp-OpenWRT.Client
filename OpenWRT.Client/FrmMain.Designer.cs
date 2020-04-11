namespace OpenWRT.Client
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkBoxAuto = new System.Windows.Forms.CheckBox();
            this.cirPbSignal = new CircularProgressBar.CircularProgressBar();
            this.grpBoxConnection = new System.Windows.Forms.GroupBox();
            this.grpBoxCommand = new System.Windows.Forms.GroupBox();
            this.grpBoxSignal = new System.Windows.Forms.GroupBox();
            this.grpBoxLog = new System.Windows.Forms.GroupBox();
            this.grpBoxTXBitrate = new System.Windows.Forms.GroupBox();
            this.cirPbTXBitrate = new CircularProgressBar.CircularProgressBar();
            this.grpBoxRXBitrate = new System.Windows.Forms.GroupBox();
            this.cirPbRXBitrate = new CircularProgressBar.CircularProgressBar();
            this.grpBoxConnection.SuspendLayout();
            this.grpBoxCommand.SuspendLayout();
            this.grpBoxSignal.SuspendLayout();
            this.grpBoxLog.SuspendLayout();
            this.grpBoxTXBitrate.SuspendLayout();
            this.grpBoxRXBitrate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(430, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(636, 100);
            this.txtLog.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(536, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(106, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(536, 17);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(106, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(6, 19);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "192.168.20.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(112, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "22";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(218, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "root";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(324, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "wrtAdm1n";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(6, 17);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(524, 20);
            this.txtCommand.TabIndex = 9;
            this.txtCommand.Text = "pwd";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // chkBoxAuto
            // 
            this.chkBoxAuto.AutoSize = true;
            this.chkBoxAuto.Location = new System.Drawing.Point(6, 206);
            this.chkBoxAuto.Name = "chkBoxAuto";
            this.chkBoxAuto.Size = new System.Drawing.Size(48, 17);
            this.chkBoxAuto.TabIndex = 10;
            this.chkBoxAuto.Text = "Auto";
            this.chkBoxAuto.UseVisualStyleBackColor = true;
            this.chkBoxAuto.CheckedChanged += new System.EventHandler(this.ChkBoxAuto_CheckedChanged);
            // 
            // cirPbSignal
            // 
            this.cirPbSignal.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cirPbSignal.AnimationSpeed = 500;
            this.cirPbSignal.BackColor = System.Drawing.Color.Transparent;
            this.cirPbSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.cirPbSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirPbSignal.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cirPbSignal.InnerMargin = 2;
            this.cirPbSignal.InnerWidth = -1;
            this.cirPbSignal.Location = new System.Drawing.Point(6, 19);
            this.cirPbSignal.MarqueeAnimationSpeed = 2000;
            this.cirPbSignal.Name = "cirPbSignal";
            this.cirPbSignal.OuterColor = System.Drawing.Color.Gray;
            this.cirPbSignal.OuterMargin = -25;
            this.cirPbSignal.OuterWidth = 26;
            this.cirPbSignal.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cirPbSignal.ProgressWidth = 26;
            this.cirPbSignal.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cirPbSignal.Size = new System.Drawing.Size(200, 200);
            this.cirPbSignal.StartAngle = 90;
            this.cirPbSignal.Step = 1;
            this.cirPbSignal.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbSignal.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbSignal.SubscriptText = "dBm";
            this.cirPbSignal.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbSignal.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbSignal.SuperscriptText = "";
            this.cirPbSignal.TabIndex = 11;
            this.cirPbSignal.Text = "-68";
            this.cirPbSignal.TextMargin = new System.Windows.Forms.Padding(0);
            this.cirPbSignal.Value = 68;
            // 
            // grpBoxConnection
            // 
            this.grpBoxConnection.Controls.Add(this.txtHost);
            this.grpBoxConnection.Controls.Add(this.txtPort);
            this.grpBoxConnection.Controls.Add(this.txtUsername);
            this.grpBoxConnection.Controls.Add(this.txtPassword);
            this.grpBoxConnection.Controls.Add(this.btnDisconnect);
            this.grpBoxConnection.Controls.Add(this.btnConnect);
            this.grpBoxConnection.Location = new System.Drawing.Point(12, 12);
            this.grpBoxConnection.Name = "grpBoxConnection";
            this.grpBoxConnection.Size = new System.Drawing.Size(648, 51);
            this.grpBoxConnection.TabIndex = 12;
            this.grpBoxConnection.TabStop = false;
            this.grpBoxConnection.Text = "Connection";
            // 
            // grpBoxCommand
            // 
            this.grpBoxCommand.Controls.Add(this.txtCommand);
            this.grpBoxCommand.Controls.Add(this.btnSend);
            this.grpBoxCommand.Location = new System.Drawing.Point(12, 69);
            this.grpBoxCommand.Name = "grpBoxCommand";
            this.grpBoxCommand.Size = new System.Drawing.Size(648, 47);
            this.grpBoxCommand.TabIndex = 13;
            this.grpBoxCommand.TabStop = false;
            this.grpBoxCommand.Text = "Command";
            // 
            // grpBoxSignal
            // 
            this.grpBoxSignal.Controls.Add(this.chkBoxAuto);
            this.grpBoxSignal.Controls.Add(this.cirPbSignal);
            this.grpBoxSignal.Location = new System.Drawing.Point(12, 122);
            this.grpBoxSignal.Name = "grpBoxSignal";
            this.grpBoxSignal.Size = new System.Drawing.Size(212, 229);
            this.grpBoxSignal.TabIndex = 14;
            this.grpBoxSignal.TabStop = false;
            this.grpBoxSignal.Text = "Signal";
            // 
            // grpBoxLog
            // 
            this.grpBoxLog.Controls.Add(this.txtLog);
            this.grpBoxLog.Location = new System.Drawing.Point(12, 357);
            this.grpBoxLog.Name = "grpBoxLog";
            this.grpBoxLog.Size = new System.Drawing.Size(648, 128);
            this.grpBoxLog.TabIndex = 15;
            this.grpBoxLog.TabStop = false;
            this.grpBoxLog.Text = "Log";
            // 
            // grpBoxTXBitrate
            // 
            this.grpBoxTXBitrate.Controls.Add(this.cirPbTXBitrate);
            this.grpBoxTXBitrate.Location = new System.Drawing.Point(448, 122);
            this.grpBoxTXBitrate.Name = "grpBoxTXBitrate";
            this.grpBoxTXBitrate.Size = new System.Drawing.Size(212, 229);
            this.grpBoxTXBitrate.TabIndex = 15;
            this.grpBoxTXBitrate.TabStop = false;
            this.grpBoxTXBitrate.Text = "TX Bitrate";
            // 
            // cirPbTXBitrate
            // 
            this.cirPbTXBitrate.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cirPbTXBitrate.AnimationSpeed = 500;
            this.cirPbTXBitrate.BackColor = System.Drawing.Color.Transparent;
            this.cirPbTXBitrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.cirPbTXBitrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirPbTXBitrate.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cirPbTXBitrate.InnerMargin = 2;
            this.cirPbTXBitrate.InnerWidth = -1;
            this.cirPbTXBitrate.Location = new System.Drawing.Point(6, 19);
            this.cirPbTXBitrate.MarqueeAnimationSpeed = 2000;
            this.cirPbTXBitrate.Maximum = 300;
            this.cirPbTXBitrate.Name = "cirPbTXBitrate";
            this.cirPbTXBitrate.OuterColor = System.Drawing.Color.Gray;
            this.cirPbTXBitrate.OuterMargin = -25;
            this.cirPbTXBitrate.OuterWidth = 26;
            this.cirPbTXBitrate.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cirPbTXBitrate.ProgressWidth = 26;
            this.cirPbTXBitrate.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cirPbTXBitrate.Size = new System.Drawing.Size(200, 200);
            this.cirPbTXBitrate.StartAngle = 90;
            this.cirPbTXBitrate.Step = 1;
            this.cirPbTXBitrate.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbTXBitrate.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbTXBitrate.SubscriptText = "MBit/s";
            this.cirPbTXBitrate.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbTXBitrate.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbTXBitrate.SuperscriptText = "";
            this.cirPbTXBitrate.TabIndex = 11;
            this.cirPbTXBitrate.Text = "1";
            this.cirPbTXBitrate.TextMargin = new System.Windows.Forms.Padding(0);
            this.cirPbTXBitrate.Value = 1;
            // 
            // grpBoxRXBitrate
            // 
            this.grpBoxRXBitrate.Controls.Add(this.cirPbRXBitrate);
            this.grpBoxRXBitrate.Location = new System.Drawing.Point(230, 122);
            this.grpBoxRXBitrate.Name = "grpBoxRXBitrate";
            this.grpBoxRXBitrate.Size = new System.Drawing.Size(212, 229);
            this.grpBoxRXBitrate.TabIndex = 16;
            this.grpBoxRXBitrate.TabStop = false;
            this.grpBoxRXBitrate.Text = "RX Bitrate";
            // 
            // cirPbRXBitrate
            // 
            this.cirPbRXBitrate.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cirPbRXBitrate.AnimationSpeed = 500;
            this.cirPbRXBitrate.BackColor = System.Drawing.Color.Transparent;
            this.cirPbRXBitrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.cirPbRXBitrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirPbRXBitrate.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cirPbRXBitrate.InnerMargin = 2;
            this.cirPbRXBitrate.InnerWidth = -1;
            this.cirPbRXBitrate.Location = new System.Drawing.Point(6, 19);
            this.cirPbRXBitrate.MarqueeAnimationSpeed = 2000;
            this.cirPbRXBitrate.Maximum = 300;
            this.cirPbRXBitrate.Name = "cirPbRXBitrate";
            this.cirPbRXBitrate.OuterColor = System.Drawing.Color.Gray;
            this.cirPbRXBitrate.OuterMargin = -25;
            this.cirPbRXBitrate.OuterWidth = 26;
            this.cirPbRXBitrate.ProgressColor = System.Drawing.Color.Blue;
            this.cirPbRXBitrate.ProgressWidth = 26;
            this.cirPbRXBitrate.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cirPbRXBitrate.Size = new System.Drawing.Size(200, 200);
            this.cirPbRXBitrate.StartAngle = 90;
            this.cirPbRXBitrate.Step = 1;
            this.cirPbRXBitrate.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbRXBitrate.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbRXBitrate.SubscriptText = "MBit/s";
            this.cirPbRXBitrate.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbRXBitrate.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbRXBitrate.SuperscriptText = "";
            this.cirPbRXBitrate.TabIndex = 11;
            this.cirPbRXBitrate.Text = "1";
            this.cirPbRXBitrate.TextMargin = new System.Windows.Forms.Padding(0);
            this.cirPbRXBitrate.Value = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 495);
            this.Controls.Add(this.grpBoxRXBitrate);
            this.Controls.Add(this.grpBoxTXBitrate);
            this.Controls.Add(this.grpBoxLog);
            this.Controls.Add(this.grpBoxSignal);
            this.Controls.Add(this.grpBoxCommand);
            this.Controls.Add(this.grpBoxConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenWRT Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpBoxConnection.ResumeLayout(false);
            this.grpBoxConnection.PerformLayout();
            this.grpBoxCommand.ResumeLayout(false);
            this.grpBoxCommand.PerformLayout();
            this.grpBoxSignal.ResumeLayout(false);
            this.grpBoxSignal.PerformLayout();
            this.grpBoxLog.ResumeLayout(false);
            this.grpBoxLog.PerformLayout();
            this.grpBoxTXBitrate.ResumeLayout(false);
            this.grpBoxRXBitrate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkBoxAuto;
        private CircularProgressBar.CircularProgressBar cirPbSignal;
        private System.Windows.Forms.GroupBox grpBoxConnection;
        private System.Windows.Forms.GroupBox grpBoxCommand;
        private System.Windows.Forms.GroupBox grpBoxSignal;
        private System.Windows.Forms.GroupBox grpBoxLog;
        private System.Windows.Forms.GroupBox grpBoxTXBitrate;
        private CircularProgressBar.CircularProgressBar cirPbTXBitrate;
        private System.Windows.Forms.GroupBox grpBoxRXBitrate;
        private CircularProgressBar.CircularProgressBar cirPbRXBitrate;
    }
}

