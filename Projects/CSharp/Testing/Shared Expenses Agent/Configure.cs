using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Snooper
{
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();
        }

        private void btnCacheBrowse_Click(object sender, EventArgs e)
        {
            fbdBrowse.ShowDialog();
            txtCache.Text = fbdBrowse.SelectedPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Instance().CacheDir = txtCache.Text;
            Settings.Instance().Interval = Int32.Parse(txtInterval.Text);
            Settings.Instance().ServerHostName = txtRemote.Text;
            Settings.Instance().ServerCacheDir = txtServerCache.Text;
            //Settings.Instance().Password = txtPassword.Text;
            Close();
        }

        private void Configure_Load(object sender, EventArgs e)
        {
            txtCache.Text = Settings.Instance().CacheDir;
            txtInterval.Text = Settings.Instance().Interval.ToString();
            txtRemote.Text = Settings.Instance().ServerHostName;
            txtServerCache.Text = Settings.Instance().ServerCacheDir;
            //txtPassword.Text = Settings.Instance().Password;
            if (Settings.Instance().Agent)
            {
                rdClient.Checked = true;
                rdbServer.Checked = false;
                grpServerConfigure.Enabled = false;
            }
            else
            {
                rdClient.Checked = false;
                rdbServer.Checked = true;
                grpClientConfigure.Enabled = false;
            }
        }

        private void rdClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rdClient.Checked)
            {
                grpClientConfigure.Enabled = true;
                grpServerConfigure.Enabled = false;
                Settings.Instance().Agent = true;
            }
        }

        private void rdbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbServer.Checked)
            {
                grpClientConfigure.Enabled = false;
                grpServerConfigure.Enabled = true;
                Settings.Instance().Agent = false;
            }
        }

        private void btnServerCacheBrowse_Click(object sender, EventArgs e)
        {
            fbdBrowse.ShowDialog();
            txtServerCache.Text = fbdBrowse.SelectedPath;
        }
    }
}
