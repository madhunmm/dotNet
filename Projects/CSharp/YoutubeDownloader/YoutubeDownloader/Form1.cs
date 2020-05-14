using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        ArrayList alFileList;
        FileInfo fiFileFound;
        DateTime dtLastTime;
        double dSize;

        public Form1()
        {
            InitializeComponent();
            alFileList = new ArrayList();
        }

        private void btnGetLock_Click(object sender, EventArgs e)
        {
            String strCacheFolder = "C:\\Users\\Madhu\\AppData\\Local\\Mozilla\\Firefox\\Profiles\\6atgc736.default\\Cache";
            String[] arrFiles = Directory.GetFiles(strCacheFolder);

            foreach (String strFile in arrFiles)
            {
                //String strFilePath = strCacheFolder + "\\" + strFile;
                alFileList.Add(new FileInfo(strFile, File.GetLastAccessTime(strFile)));
            }
            IComparer fc = new FileInfo.FileComparer();
            alFileList.Sort(fc);

            fiFileFound = (FileInfo)alFileList[0];

            // wait till it completes downloading...
            dtLastTime = File.GetLastAccessTime(fiFileFound.GetFilePath());
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (fiFileFound != null)
                {
                    if (dSize == 0)
                    {
                        dSize = new System.IO.FileInfo(fiFileFound.GetFilePath()).Length;
                    }
                    else
                    {
                        double dSizeNew = new System.IO.FileInfo(fiFileFound.GetFilePath()).Length;
                        if (dSize.CompareTo(dSizeNew) == 0)
                        {
                            String strNewFilePath = "C:\\Data\\Downloads\\" + Path.GetFileName(fiFileFound.GetFilePath()) + ".mp4";
                            File.Copy(fiFileFound.GetFilePath(), strNewFilePath);
                            timer1.Enabled = false;
                            MessageBox.Show("Video downloaded!!");
                        }
                        else
                        {
                            dSize = dSizeNew;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
    class FileInfo 
    {
        //private String strFileName;
        private String strFilePath;
        private DateTime dtLastAccessed;

        public class FileComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                
                return (new CaseInsensitiveComparer().Compare(((FileInfo)y).GetLastAccessedDate(), ((FileInfo)x).GetLastAccessedDate()));
            }
        }

        public FileInfo(String str1, DateTime dt)
        {
            strFilePath = str1;
            //strFilePath = str2;
            dtLastAccessed = dt;
        }
  
        //public String GetFileName()
        //{
        //    return strFileName;
        //}

        public String GetFilePath()
        {
            return strFilePath;
        }

        public DateTime GetLastAccessedDate()
        {
            return dtLastAccessed;
        }

    }
}
