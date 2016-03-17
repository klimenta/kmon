﻿namespace kmon
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbServers = new System.Windows.Forms.ListBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.lblPort1 = new System.Windows.Forms.Label();
            this.lblPort2 = new System.Windows.Forms.Label();
            this.lblPort3 = new System.Windows.Forms.Label();
            this.lblPort4 = new System.Windows.Forms.Label();
            this.lblPort5 = new System.Windows.Forms.Label();
            this.cbPing = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblPort6 = new System.Windows.Forms.Label();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.tbTimeout = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbServers
            // 
            this.lbServers.FormattingEnabled = true;
            this.lbServers.Location = new System.Drawing.Point(16, 41);
            this.lbServers.Name = "lbServers";
            this.lbServers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbServers.Size = new System.Drawing.Size(133, 134);
            this.lbServers.TabIndex = 0;
            this.lbServers.SelectedIndexChanged += new System.EventHandler(this.lbServers_SelectedIndexChanged);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(240, 110);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(93, 13);
            this.lblInterval.TabIndex = 1;
            this.lblInterval.Text = "Time interval (sec)";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(335, 105);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(45, 20);
            this.tbInterval.TabIndex = 2;
            this.tbInterval.Text = "5";
            this.tbInterval.TextChanged += new System.EventHandler(this.tbInterval_TextChanged);
            // 
            // lblPort1
            // 
            this.lblPort1.AutoSize = true;
            this.lblPort1.Location = new System.Drawing.Point(155, 50);
            this.lblPort1.Name = "lblPort1";
            this.lblPort1.Size = new System.Drawing.Size(59, 13);
            this.lblPort1.TabIndex = 4;
            this.lblPort1.Text = "TCP Port 1";
            // 
            // lblPort2
            // 
            this.lblPort2.AutoSize = true;
            this.lblPort2.Location = new System.Drawing.Point(270, 50);
            this.lblPort2.Name = "lblPort2";
            this.lblPort2.Size = new System.Drawing.Size(59, 13);
            this.lblPort2.TabIndex = 5;
            this.lblPort2.Text = "TCP Port 2";
            // 
            // lblPort3
            // 
            this.lblPort3.AutoSize = true;
            this.lblPort3.Location = new System.Drawing.Point(385, 50);
            this.lblPort3.Name = "lblPort3";
            this.lblPort3.Size = new System.Drawing.Size(59, 13);
            this.lblPort3.TabIndex = 6;
            this.lblPort3.Text = "TCP Port 3";
            // 
            // lblPort4
            // 
            this.lblPort4.AutoSize = true;
            this.lblPort4.Location = new System.Drawing.Point(155, 80);
            this.lblPort4.Name = "lblPort4";
            this.lblPort4.Size = new System.Drawing.Size(59, 13);
            this.lblPort4.TabIndex = 7;
            this.lblPort4.Text = "TCP Port 4";
            // 
            // lblPort5
            // 
            this.lblPort5.AutoSize = true;
            this.lblPort5.Location = new System.Drawing.Point(270, 80);
            this.lblPort5.Name = "lblPort5";
            this.lblPort5.Size = new System.Drawing.Size(59, 13);
            this.lblPort5.TabIndex = 8;
            this.lblPort5.Text = "TCP Port 5";
            // 
            // cbPing
            // 
            this.cbPing.AutoSize = true;
            this.cbPing.Location = new System.Drawing.Point(158, 110);
            this.cbPing.Name = "cbPing";
            this.cbPing.Size = new System.Drawing.Size(47, 17);
            this.cbPing.TabIndex = 16;
            this.cbPing.Text = "Ping";
            this.cbPing.UseVisualStyleBackColor = true;
            this.cbPing.CheckedChanged += new System.EventHandler(this.cbPing_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(45, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.SystemColors.Control;
            this.btnMonitor.Location = new System.Drawing.Point(293, 126);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(200, 51);
            this.btnMonitor.TabIndex = 19;
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.HideSelection = false;
            this.rtbLog.Location = new System.Drawing.Point(16, 181);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(477, 149);
            this.rtbLog.TabIndex = 20;
            this.rtbLog.Text = "";
            // 
            // lblPort6
            // 
            this.lblPort6.AutoSize = true;
            this.lblPort6.Location = new System.Drawing.Point(385, 80);
            this.lblPort6.Name = "lblPort6";
            this.lblPort6.Size = new System.Drawing.Size(59, 13);
            this.lblPort6.TabIndex = 21;
            this.lblPort6.Text = "TCP Port 6";
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(380, 110);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(67, 13);
            this.lblTimeout.TabIndex = 22;
            this.lblTimeout.Text = "Timeout (ms)";
            // 
            // tbTimeout
            // 
            this.tbTimeout.Location = new System.Drawing.Point(449, 105);
            this.tbTimeout.Name = "tbTimeout";
            this.tbTimeout.Size = new System.Drawing.Size(45, 20);
            this.tbTimeout.TabIndex = 23;
            this.tbTimeout.Text = "100";
            this.tbTimeout.TextChanged += new System.EventHandler(this.tbTimeout_TextChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::kmon.Properties.Resources.copy1;
            this.btnCopy.Location = new System.Drawing.Point(247, 135);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(40, 40);
            this.btnCopy.TabIndex = 26;
            this.btnCopy.Text = "CPY";
            this.toolTip1.SetToolTip(this.btnCopy, "Copy to Clipboard");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Image = global::kmon.Properties.Resources.Clear;
            this.btnClearLog.Location = new System.Drawing.Point(201, 135);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(40, 40);
            this.btnClearLog.TabIndex = 25;
            this.btnClearLog.Text = "CLR";
            this.toolTip1.SetToolTip(this.btnClearLog, "Clear Log");
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = global::kmon.Properties.Resources.SelectAll;
            this.btnSelectAll.Location = new System.Drawing.Point(155, 135);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(40, 40);
            this.btnSelectAll.TabIndex = 24;
            this.btnSelectAll.Text = "SA";
            this.toolTip1.SetToolTip(this.btnSelectAll, "Select All");
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "kmon";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 54);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Image = global::kmon.Properties.Resources.restore_icon;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::kmon.Properties.Resources.close_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 341);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.tbTimeout);
            this.Controls.Add(this.lblTimeout);
            this.Controls.Add(this.lblPort6);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbPing);
            this.Controls.Add(this.lblPort5);
            this.Controls.Add(this.lblPort4);
            this.Controls.Add(this.lblPort3);
            this.Controls.Add(this.lblPort2);
            this.Controls.Add(this.lblPort1);
            this.Controls.Add(this.tbInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lbServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "kmon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbServers;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label lblPort1;
        private System.Windows.Forms.Label lblPort2;
        private System.Windows.Forms.Label lblPort3;
        private System.Windows.Forms.Label lblPort4;
        private System.Windows.Forms.Label lblPort5;
        private System.Windows.Forms.CheckBox cbPing;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblPort6;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.TextBox tbTimeout;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

