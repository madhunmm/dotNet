using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace Snooper
{
    public partial class Agent : Form
    {
        Server server;
        Client client;

        public Agent()
        {
            InitializeComponent();
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            niStatus.ContextMenuStrip = cmsMenu;
            if (!Settings.Instance().Agent)
            {
                StartServer();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(server != null)
                StopServer();
            Close();
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Configure().Show();
        }

        private void uploadToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Instance().Agent)
            {
                String strCachePath = Settings.Instance().CacheDir;

                // The share is writable
                bool bSuccess = true;
                if (strCachePath.Length > 0)
                {
                    String[] strFiles = Directory.GetFiles(strCachePath);
                    FileInfo fi = null;

                    // Create a client
                    client = new Client();
                    String strReturn = "";
                    foreach (String strFile in strFiles)
                    {
                        fi = new FileInfo(strFile);
                        if (fi.Extension == ".txt")
                        {
                            try
                            {
                                strReturn = client.SendFile(strFile);
                                if (!strReturn.Equals(""))
                                {
                                    niStatus.ShowBalloonTip(3000, "Unable to upload " + fi.Name, strReturn, ToolTipIcon.Error);
                                    bSuccess = false;
                                    break;
                                }
                            }
                            catch (Exception)
                            {
                                niStatus.ShowBalloonTip(3000, "Upload failed", "Unable to upload " + fi.Name, ToolTipIcon.Error);
                                bSuccess = false;
                            }

                            // delete the file
                            try
                            {
                                File.Delete(strFile);
                            }
                            catch (Exception)
                            {
                                niStatus.ShowBalloonTip(3000, "Delete failed", "Please clean up cache folder manually ", ToolTipIcon.Warning);
                                bSuccess = false;
                            }
                        }
                    }
                    //client.SendEndOfMessage();
                }
                if (bSuccess)
                {
                    niStatus.ShowBalloonTip(3000, "Upload successful", "Uploaded entries to server successfully!", ToolTipIcon.Info);
                }
            }
        }

        private void updateDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Instance().Agent)
            {
                // Send message to server asking for the latest DB
                if (client == null)
                {
                    client = new Client();
                }

                // Receive the file from the server and update it here.
                String strUpatedDB = client.ReceiveFile();
                MessageBox.Show(strUpatedDB);
                if (File.Exists(".\\Expenses.csv"))
                {
                    if(File.Exists(".\\Expenses.csv.backup"))
                        File.Delete(".\\Expenses.csv.backup");
                    File.Move(".\\Expenses.csv", ".\\Expenses.csv.backup");
                }
                File.Create(".\\Expenses.csv").Close();
                strUpatedDB = strUpatedDB.Remove(strUpatedDB.Length - 1);
                String[] strEntries = strUpatedDB.Split('|');
                File.WriteAllLines(".\\Expenses.csv", strEntries);
            }
        }

        private void StartServer()
        {
            server = new Server();
        }

        private void StopServer()
        {
            server.Stop();
        }
    }
}
