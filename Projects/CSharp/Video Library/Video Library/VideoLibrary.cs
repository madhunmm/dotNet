using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Text;

namespace Video_Library
{
    public partial class VideoLibrary : Form
    {
        private VideoDatabase vdb;

        private class PlayerEventArgs : EventArgs
        {
            public String strPlayer;
        }

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
                PlayerEventArgs pea = new PlayerEventArgs();
                pea.strPlayer = strMediaPlayer;
                EventHandler eh = new EventHandler(PlayWithEventhandler);
                //eh.Method.
                tsmi.DropDownItems.Add(strMediaPlayer,null,eh);
            }

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(dgvSearchList.Font, FontStyle.Bold);
            dgvSearchList.Columns[1].DefaultCellStyle = style;
            dgvSearchList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchList.ColumnHeadersDefaultCellStyle = style;

            cmsMenu.Items.Add(tsmi);
            //btnSearch_Click(sender,e);
        }

        private void DatabaseTest()
        {
            VideoDatabase vdb = VideoDatabase.Instance();
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

            lblResultCount.Text = alSearchList.Count.ToString();

            foreach (DisplayData dd in alSearchList)
            {
                dgvSearchList.Rows.Add();
                dgvSearchList.Rows[dgvSearchList.RowCount -1].Cells["Video"].Value = dd.MovieName;

                // Get the location of the video
                vdb.MovieName = dd.MovieName;
                String strFilePath = vdb.Location;

                if (File.Exists(strFilePath))
                {
                    dgvSearchList.Rows[dgvSearchList.RowCount - 1].Cells["Availability"].Style.ForeColor = Color.Green;
                    dgvSearchList.Rows[dgvSearchList.RowCount - 1].Cells["Availability"].Value = "YES";
                }
                else
                {
                    dgvSearchList.Rows[dgvSearchList.RowCount - 1].Cells["Availability"].Style.ForeColor = Color.Red;
                    dgvSearchList.Rows[dgvSearchList.RowCount - 1].Cells["Availability"].Value = "NO";
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
                strQuery = strQuery + "keywords like '%" + txtKeywords.Text + "%'";
                bAnd = true;
            }
            if (txtMovieName.Text.Length > 0)
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
                strQuery = strQuery + "moviename like '%" + txtMovieName.Text + "%'";
                bAnd = true;
            }

            return strQuery;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayWithEventhandler("", e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will update the movie list. Your information might get lost. Do you wish to continue?","Refresh",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                VideoSnooper vs = new VideoSnooper(vdb);
                vs.Snoop();
                vs = null;
                btnSearch_Click(sender, e);
            }
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

        private void editVideoInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList alMovieList = new ArrayList();
            foreach (DataGridViewCell dgc in dgvSearchList.SelectedCells)
            {
                alMovieList.Add(dgc.Value.ToString());
            }
            ViewDetails.ShowPage(alMovieList);
            dgvSearchList.Refresh();
        }

        private void PlayWithEventhandler(object sender, EventArgs e)
        {
            StringBuilder strSelectedMovies = new StringBuilder();
            foreach (DataGridViewCell dgc in dgvSearchList.SelectedCells)
            {
                vdb.MovieName = dgc.Value.ToString();

                strSelectedMovies.Append("\"");
                strSelectedMovies.Append(vdb.Location);
                strSelectedMovies.Append("\"");
                strSelectedMovies.Append(" ");
            }
            if (strSelectedMovies.Length > 0)
            {
                if (sender.ToString().Length > 0)
                {
                    Common.PlayMovie(strSelectedMovies.ToString(), vdb.GetPlayerLocation(sender.ToString()));
                }
                else
                {
                    Common.PlayMovie(strSelectedMovies.ToString(),"");
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm Delete?", "Delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                foreach (DataGridViewCell dgc in dgvSearchList.SelectedCells)
                {
                    vdb.RemoveMovie(dgc.Value.ToString());
                    dgvSearchList.Rows.RemoveAt(dgc.RowIndex);
                }
            }
        }
    }
}
