namespace Shared_Expenses_Agent
{
    partial class Configure
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
            this.grpClientConfigure = new System.Windows.Forms.GroupBox();
            this.btnCacheBrowse = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtCache = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblCache = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.fbdBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.grpServerConfigure = new System.Windows.Forms.GroupBox();
            this.btnServerCacheBrowse = new System.Windows.Forms.Button();
            this.txtServerCache = new System.Windows.Forms.TextBox();
            this.lblServerCache = new System.Windows.Forms.Label();
            this.rdClient = new System.Windows.Forms.RadioButton();
            this.rdbServer = new System.Windows.Forms.RadioButton();
            this.txtRemote = new System.Windows.Forms.TextBox();
            this.lblRemote = new System.Windows.Forms.Label();
            this.grpClientConfigure.SuspendLayout();
            this.grpServerConfigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpClientConfigure
            // 
            this.grpClientConfigure.Controls.Add(this.txtRemote);
            this.grpClientConfigure.Controls.Add(this.lblRemote);
            this.grpClientConfigure.Controls.Add(this.btnCacheBrowse);
            this.grpClientConfigure.Controls.Add(this.txtInterval);
            this.grpClientConfigure.Controls.Add(this.txtCache);
            this.grpClientConfigure.Controls.Add(this.lblInterval);
            this.grpClientConfigure.Controls.Add(this.lblCache);
            this.grpClientConfigure.Location = new System.Drawing.Point(12, 49);
            this.grpClientConfigure.Name = "grpClientConfigure";
            this.grpClientConfigure.Size = new System.Drawing.Size(273, 123);
            this.grpClientConfigure.TabIndex = 0;
            this.grpClientConfigure.TabStop = false;
            this.grpClientConfigure.Text = "Client Configurations";
            // 
            // btnCacheBrowse
            // 
            this.btnCacheBrowse.Location = new System.Drawing.Point(241, 22);
            this.btnCacheBrowse.Name = "btnCacheBrowse";
            this.btnCacheBrowse.Size = new System.Drawing.Size(26, 20);
            this.btnCacheBrowse.TabIndex = 1;
            this.btnCacheBrowse.Text = "...";
            this.btnCacheBrowse.UseVisualStyleBackColor = true;
            this.btnCacheBrowse.Click += new System.EventHandler(this.btnCacheBrowse_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(116, 53);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(119, 20);
            this.txtInterval.TabIndex = 6;
            // 
            // txtCache
            // 
            this.txtCache.Location = new System.Drawing.Point(116, 22);
            this.txtCache.Name = "txtCache";
            this.txtCache.Size = new System.Drawing.Size(119, 20);
            this.txtCache.TabIndex = 4;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(25, 56);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(79, 13);
            this.lblInterval.TabIndex = 3;
            this.lblInterval.Text = "Update interval";
            // 
            // lblCache
            // 
            this.lblCache.AutoSize = true;
            this.lblCache.Location = new System.Drawing.Point(25, 25);
            this.lblCache.Name = "lblCache";
            this.lblCache.Size = new System.Drawing.Size(67, 13);
            this.lblCache.TabIndex = 1;
            this.lblCache.Text = "Cache folder";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fbdBrowse
            // 
            this.fbdBrowse.Description = "Select the cache folder for temporary storage";
            // 
            // grpServerConfigure
            // 
            this.grpServerConfigure.Controls.Add(this.btnServerCacheBrowse);
            this.grpServerConfigure.Controls.Add(this.txtServerCache);
            this.grpServerConfigure.Controls.Add(this.lblServerCache);
            this.grpServerConfigure.Location = new System.Drawing.Point(12, 178);
            this.grpServerConfigure.Name = "grpServerConfigure";
            this.grpServerConfigure.Size = new System.Drawing.Size(273, 63);
            this.grpServerConfigure.TabIndex = 2;
            this.grpServerConfigure.TabStop = false;
            this.grpServerConfigure.Text = "Server Configurations";
            // 
            // btnServerCacheBrowse
            // 
            this.btnServerCacheBrowse.Location = new System.Drawing.Point(241, 22);
            this.btnServerCacheBrowse.Name = "btnServerCacheBrowse";
            this.btnServerCacheBrowse.Size = new System.Drawing.Size(26, 20);
            this.btnServerCacheBrowse.TabIndex = 1;
            this.btnServerCacheBrowse.Text = "...";
            this.btnServerCacheBrowse.UseVisualStyleBackColor = true;
            this.btnServerCacheBrowse.Click += new System.EventHandler(this.btnServerCacheBrowse_Click);
            // 
            // txtServerCache
            // 
            this.txtServerCache.Location = new System.Drawing.Point(116, 22);
            this.txtServerCache.Name = "txtServerCache";
            this.txtServerCache.Size = new System.Drawing.Size(119, 20);
            this.txtServerCache.TabIndex = 4;
            // 
            // lblServerCache
            // 
            this.lblServerCache.AutoSize = true;
            this.lblServerCache.Location = new System.Drawing.Point(25, 25);
            this.lblServerCache.Name = "lblServerCache";
            this.lblServerCache.Size = new System.Drawing.Size(67, 13);
            this.lblServerCache.TabIndex = 1;
            this.lblServerCache.Text = "Cache folder";
            // 
            // rdClient
            // 
            this.rdClient.AutoSize = true;
            this.rdClient.Location = new System.Drawing.Point(12, 19);
            this.rdClient.Name = "rdClient";
            this.rdClient.Size = new System.Drawing.Size(88, 17);
            this.rdClient.TabIndex = 7;
            this.rdClient.TabStop = true;
            this.rdClient.Text = "Run as Client";
            this.rdClient.UseVisualStyleBackColor = true;
            this.rdClient.CheckedChanged += new System.EventHandler(this.rdClient_CheckedChanged);
            // 
            // rdbServer
            // 
            this.rdbServer.AutoSize = true;
            this.rdbServer.Location = new System.Drawing.Point(197, 19);
            this.rdbServer.Name = "rdbServer";
            this.rdbServer.Size = new System.Drawing.Size(93, 17);
            this.rdbServer.TabIndex = 8;
            this.rdbServer.TabStop = true;
            this.rdbServer.Text = "Run as Server";
            this.rdbServer.UseVisualStyleBackColor = true;
            this.rdbServer.CheckedChanged += new System.EventHandler(this.rdbServer_CheckedChanged);
            // 
            // txtRemote
            // 
            this.txtRemote.Location = new System.Drawing.Point(117, 83);
            this.txtRemote.Name = "txtRemote";
            this.txtRemote.Size = new System.Drawing.Size(119, 20);
            this.txtRemote.TabIndex = 9;
            // 
            // lblRemote
            // 
            this.lblRemote.AutoSize = true;
            this.lblRemote.Location = new System.Drawing.Point(26, 86);
            this.lblRemote.Name = "lblRemote";
            this.lblRemote.Size = new System.Drawing.Size(78, 13);
            this.lblRemote.TabIndex = 8;
            this.lblRemote.Text = "Remote Server";
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 282);
            this.Controls.Add(this.rdbServer);
            this.Controls.Add(this.rdClient);
            this.Controls.Add(this.grpServerConfigure);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpClientConfigure);
            this.MaximizeBox = false;
            this.Name = "Configure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.Configure_Load);
            this.grpClientConfigure.ResumeLayout(false);
            this.grpClientConfigure.PerformLayout();
            this.grpServerConfigure.ResumeLayout(false);
            this.grpServerConfigure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientConfigure;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblCache;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtCache;
        private System.Windows.Forms.Button btnCacheBrowse;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowse;
        private System.Windows.Forms.GroupBox grpServerConfigure;
        private System.Windows.Forms.Button btnServerCacheBrowse;
        private System.Windows.Forms.TextBox txtServerCache;
        private System.Windows.Forms.Label lblServerCache;
        private System.Windows.Forms.RadioButton rdClient;
        private System.Windows.Forms.RadioButton rdbServer;
        private System.Windows.Forms.TextBox txtRemote;
        private System.Windows.Forms.Label lblRemote;
    }
}