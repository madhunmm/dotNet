using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Drawing;
using System.Diagnostics;

namespace Video_Library
{
    public partial class VideoLibrary : Form
    {
        private VideoDatabase vdb;
        public VideoLibrary()
        {
            InitializeComponent();
            vdb = VideoDatabase.Instance();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSearchList.Columns[0].Width = dgvSearchList.Width-150;

            ToolStripMenuItem tsmi = new ToolStripMenuItem("Play With...");

            ArrayList alMediaPlayers = vdb.GetMediaPlayers();
            foreach(String strMediaPlayer in alMediaPlayers)
            {
                tsmi.DropDownItems.Add(strMediaPlayer);
            }

            cmsMenu.Items.Add(tsmi);
            btnSearch_Click(sender,e);
        }

        private void DatabaseTest()
        {
            VideoDatabase vdb = new VideoDatabase();
            vdb.MovieName = "ayan";
            vdb.StarCast = "suriya";
            vdb.Language = "Tamil";
            vdb.HasSubtitle = true;
            vdb.Genre = "Action";

            MessageBox.Show(vdb.MovieName);
            MessageBox.Show(vdb.StarCast);
            MessageBox.Show(vdb.Language);
            MessageBox.Show(vdb.Genre);
            MessageBox.Show(vdb.HasSubtitle.ToString());

            vdb.AddMovie("Nala Damayanti");

            vdb.AddExtension("dat");
            vdb.AddExtension("avi");

            vdb.AddSearchPath("F:\\Movies");
            vdb.AddSearchPath("L:\\DATA\\Movies");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSearchList.Rows.Clear();
            String strQuery = GetQuery();
            ArrayList alSearchList = vdb.GetMovieList(strQuery);

            foreach (DisplayData dd in alSearchList)
            {
                dgvSearchList.Rows.Add();
                dgvSearchList.Rows[dgvSearchList.RowCount -1].Cells["Video"].Value = dd.MovieName;

                // Get the location of the video
                vdb.MovieName = dd.MovieName;
                String strFilePath = vdb.Location;
                if (File.Exists(strFilePath))
                {
                    dgvSearchList.Rows[dgvSearchList.RowCount - 1].Cells["Availability"].Style.BackColor = Color.PaleGreen;
                }
                else
                {
                    dgvSearchList.Rows[dgvSearchList.RowCount - 1].Cells["Availability"].Style.BackColor = Color.PaleVioletRed;
                }
                
            }
        }

        private String GetQuery()
        {
            String strQuery = "";
            Boolean bAnd = false;
            Boolean bWhere = false;
            strQuery = "Select moviename from videos";

            if (txtLanguage.Text.Length > 0)
            {
                if (!bWhere)
                {
                    strQuery = strQuery + " where ";
                    bWhere = true;
                }
                strQuery = strQuery + "lang like '%" + txtLanguage.Text + "%'";
                bAnd = true;
            }
            if (txtGenre.Text.Length > 0)
            {
                if (!bWhere)
                {
                    strQuery = strQuery + " where ";
                    bWhere = true;
                }
                if (bAnd)
                {
                    strQuery = strQuery + " and ";
                }
                strQuery = strQuery + "genre like '%" + txtGenre.Text + "%'";
                bAnd = true;
            }
            if (txtDirector.Text.Length > 0)
            {
                if (!bWhere)
                {
                    strQuery = strQuery + " where ";
                    bWhere = true;
                }
                if (bAnd)
                {
                    strQuery = strQuery + " and ";
                }
                strQuery = strQuery + "director like '%" + txtDirector.Text + "%'";
                bAnd = true;
            }
            if (txtStarCast.Text.Length > 0)
            {
                if (!bWhere)
                {
                    strQuery = strQuery + " where ";
                    bWhere = true;
                }
                if (bAnd)
                {
                    strQuery = strQuery + " and ";
                }
                strQuery = strQuery + "starcast like '%" + txtStarCast.Text + "%'";
                bAnd = true;
            }
            if (txtYear.Text.Length > 0)
            {
                if (!bWhere)
                {
                    strQuery = strQuery + " where ";
                    bWhere = true;
                }
                if (bAnd)
                {
                    strQuery = strQuery + " and ";
                }
                strQuery = strQuery + "year like '%" + txtYear.Text + "%'";
                bAnd = true;
            }
            if (txtKeywords.Text.Length > 0)
            {
                if (!bWhere)
                {
                    strQuery = strQuery + " where ";
                    bWhere = true;
                }
                if (bAnd)
                {
                    strQuery = strQuery + " and ";
                }
                strQuery = strQuery + "keywords like '%" + txtYear.Text + "%'";
                bAnd = true;
            }

            return strQuery;
        }

        private void txtLanguage_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender,e);
        }

        private void txtGenre_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void txtDirector_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void txtStarCast_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void txtKeywords_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            vdb.MovieName = dgvSearchList.SelectedCells[0].Value.ToString();
            Common.PlayMovie(vdb.Location);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void niSysTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void VideoLibrary_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void dgvSearchList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvSearchList.CurrentCell = dgvSearchList[0, e.RowIndex];
            }
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            Configure.ShowPage();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPlay_Click(sender, e);
        }

        private void editVideoInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDetails.ShowPage();
        }
    }
}
