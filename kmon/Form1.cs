﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace kmon
{


    public partial class frmMain : Form
    {

        private BackgroundWorker bw = new BackgroundWorker();
        double dPingTimeAverage;
        bool bCheckOpenTCPPort;
        const int iNumberOfPorts = 6;
        List<TextBox> tbPort = new List<TextBox>();
        public int intCounter = 0;
        int intTimeout = 50; //Default = 50ms
        int intTimeInterval = 5000; //Default 5sec

        public static bool CheckOpenTCPPort(string host, int port, int intTimeout)
        {
            bool bOpenPort = false;
            try
            {            
                TcpClient tcpClient = new TcpClient();
                tcpClient.ReceiveTimeout = intTimeout;
                tcpClient.SendTimeout = intTimeout;
                var AsyncResult = tcpClient.BeginConnect(host, port, null, null);
                var waitHandle = AsyncResult.AsyncWaitHandle;
                try
                {
                    if (!AsyncResult.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(intTimeout), false))
                {
                        // wait handle didn't came back in time
                        tcpClient.Close();
                    }
                    else
                    {
                        // The result was positiv
                        bOpenPort = tcpClient.Connected;
                    }
                    // ensure the ending-call
                    tcpClient.EndConnect(AsyncResult);
                }
                finally
                {
                    // Ensure to close the wait handle.
                    waitHandle.Close();
                }
            }
            catch
            {
            }
            return bOpenPort;
        }

        public static double PingTimeAverage(string host, int timeout)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            //int timeout = 
            PingReply reply = pingSender.Send(host, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                return reply.RoundtripTime;
            }
            else
            { return -1.0; }
        }

        public class Server
        {
            //Server name
            public string strServerName { get; set; }
            //Ping monitoring 
            public bool bPing { get; set; }
            //TCP Ports
            public List<int> lstPorts = new List<int>();
        }

        //Initialize a list of server objects
        List<Server> srvServer = new List<Server>();
        private bool bMonitor = false;
        
        public frmMain()
        {
            InitializeComponent();
            btnMonitor.BackColor = System.Drawing.Color.Red;
            btnMonitor.Text = "Not Monitoring";
            
            for (int i = 0; i < iNumberOfPorts; i++)
            {
                TextBox newTextBox = new TextBox();
                tbPort.Add(newTextBox);
                tbPort[i].Width = 45;
                tbPort[i].Height = 20;
                
                //tbPort[i].KeyUp += new EventHandler(tbPort_KeyUp);
                tbPort[i].TabIndex = i + 10;
                tbPort[i].Text = "0";
                tbPort[i].Name = "tbPort" + i.ToString();
                tbPort[i].Tag= i;
                tbPort[i].TextChanged += new EventHandler(tbPort_TextChanged);
                this.Controls.Add(newTextBox);
            }
            tbPort[0].Top = 45; tbPort[1].Top = 45; tbPort[2].Top = 45;
            tbPort[3].Top = 75; tbPort[4].Top = 75; tbPort[5].Top = 75;
            tbPort[0].Left = 221; tbPort[3].Left = 221;
            tbPort[1].Left = 335; tbPort[4].Left = 335;
            tbPort[2].Left = 449; tbPort[5].Left = 449;


            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);            
        }

        protected void tbPort_TextChanged(object sender, EventArgs e)
        {
            int intPort;
            int intCheck = lbServers.SelectedIndices.Count;
            
            if (lbServers.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a server on the left side", "Error");
                return;
            }
            try
            {                
                intPort = Convert.ToInt32((sender as TextBox).Text.Trim());
                if (intPort > 65535) intPort = 65535;           
            }
            catch (Exception)
            {
                (sender as TextBox).Text = "0";
                return;
            }
            srvServer[lbServers.SelectedIndex].lstPorts[Convert.ToInt32((sender as TextBox).Tag)] = intPort;            
        }       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddServer frm2 = new frmAddServer();
            frm2.ShowDialog();
            //Prevent duplicates
            if (frmAddServer.strServerName == null || frmAddServer.strServerName == "") return;
            if (!lbServers.Items.Contains(frmAddServer.strServerName))
            {
                lbServers.Items.Add(frmAddServer.strServerName);
                srvServer.Add(new Server { strServerName = frmAddServer.strServerName, bPing = false, lstPorts = new List<int>(iNumberOfPorts) { 0, 0, 0, 0, 0, 0 } });                
            }
            else
            {
                MessageBox.Show("Duplicate entry. Please re-enter.", "kmon");
            }            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int intCounter = lbServers.SelectedIndices.Count - 1; intCounter >= 0; intCounter--)
            {
                int intIndex = lbServers.SelectedIndices[intCounter];
                lbServers.Items.RemoveAt(intIndex);
                srvServer.RemoveAt(intIndex);
            }
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tbPort[0].Text);
            if (bMonitor)
            {
                bMonitor = false;
                btnMonitor.BackColor = Color.Red;
                btnMonitor.Text = "Not Monitoring";               
                if (bw.WorkerSupportsCancellation == true)
                {
                    bw.CancelAsync();
                }
            }
            else
            {
                bMonitor = true;
                btnMonitor.BackColor = Color.Green;
                btnMonitor.Text = "Monitoring";               
                if (bw.IsBusy != true)
                {
                    bw.RunWorkerAsync();
                }
            }
        }

        private void tbInterval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                intTimeInterval = Convert.ToInt32(tbInterval.Text.Trim()) * 1000;                
            }
            catch (Exception)
            {
                tbInterval.Text = "5";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void lbServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("You clicked on " + lbServers.SelectedItem.ToString());
            try
            {               
                for (int i = 0; i < iNumberOfPorts; i++)
                {
                    tbPort[i].Text = srvServer[lbServers.SelectedIndex].lstPorts[i].ToString();
                }                    
                cbPing.Checked = srvServer[lbServers.SelectedIndex].bPing;
            }
            catch (Exception)
            { }            
        }

        private void cbPing_CheckedChanged(object sender, EventArgs e)
        {
            int intCheck = lbServers.SelectedIndices.Count;
            if (lbServers.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a server on the left side", "Error");
                return;
            }
            srvServer[lbServers.SelectedIndex].bPing = cbPing.Checked;       
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while ( true )
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(intTimeInterval); //Time interval between each thread
                    worker.ReportProgress(0);
                }
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {                
                rtbLog.AppendText(DateTime.Now + " ", Color.Blue);                
                rtbLog.AppendText("NOT MONITORING!" + Environment.NewLine, Color.Red);
            }

            else if (!(e.Error == null))
            {
                rtbLog.AppendText(DateTime.Now + " ", Color.Blue);
                rtbLog.AppendText("Error: " + e.Error.Message, Color.Red);
            }

            else
            {
                rtbLog.AppendText(DateTime.Now + " ", Color.Blue);
                rtbLog.AppendText("Done!", Color.Green);
            }
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Color cColor;
            for (int j = 0; j < srvServer.Count; j++)
            {
                if (srvServer[j].bPing) {
                    dPingTimeAverage = PingTimeAverage(srvServer[j].strServerName, intTimeout);
                    rtbLog.AppendText(DateTime.Now + " ", Color.Blue);
                    if (dPingTimeAverage == -1)
                    {
                        cColor = Color.Red;
                    }
                    else
                    {
                        cColor = Color.Green;
                    }
                    string strPingTimeAverage = dPingTimeAverage.ToString();
                    if (strPingTimeAverage == "-1")
                    {
                        strPingTimeAverage = "NOT REACHABLE ";
                    }
                    rtbLog.AppendText(srvServer[j].strServerName + " " + strPingTimeAverage + "ms reply time " + Environment.NewLine, cColor);
                }
                int i = 0;
                while (srvServer[j].lstPorts[i] != 0) {
                    bCheckOpenTCPPort = CheckOpenTCPPort(srvServer[j].strServerName, srvServer[j].lstPorts[i], intTimeout);
                    rtbLog.AppendText(DateTime.Now + " ", Color.Blue);
                    if (bCheckOpenTCPPort)
                    {
                        cColor = Color.Green;
                    }
                    else
                    {
                        cColor = Color.Red;
                    }
                    string strPort;
                    if (bCheckOpenTCPPort)
                    {
                        strPort = " opened";
                    }
                    else {
                        strPort = " CLOSED";
                    }
                    rtbLog.AppendText(srvServer[j].strServerName + " has port " + srvServer[j].lstPorts[i].ToString() + strPort + Environment.NewLine, cColor);
                    i++;
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            rtbLog.SelectAll();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbLog.SelectedRtf, TextDataFormat.Rtf);
        }

        private void tbTimeout_TextChanged(object sender, EventArgs e)
        {
            try
            {
                intTimeout = Convert.ToInt32(tbTimeout.Text.Trim());
            }
            catch (Exception)
            {
                tbTimeout.Text = "100";
            }            
        }
    }
}

public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;
        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }
}
