using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Video_Library
{
    public partial class ViewDetails : Form
    {
        private static ViewDetails m_ViewDetails;
        private ArrayList alMovieList;
        private VideoDatabase vdb;

        public ViewDetails()
        {
            InitializeComponent();
            vdb = VideoDatabase.Instance();
        }

        private static ViewDetails Instance()
        {
            if (m_ViewDetails == null)
            {
                m_ViewDetails = new ViewDetails();
            }
            return m_ViewDetails;
        }

        public static void ShowPage(ArrayList alMovies)
        {
            Instance().SetInstanceMovieList(alMovies);
            Instance().Show();
        }

        public void SetInstanceMovieList(ArrayList alMovies)
        {
            alMovieList = alMovies;
        }

        public static void HidePage()
        {
            Instance().Hide();
        }

        private void ViewDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_ViewDetails = null;
        }

        private void ViewDetails_Load(object sender, EventArgs e)
        {
            if (alMovieList.Count == 1)
            {
                if (alMovieList[0].ToString().Length > 0)
                {
                    vdb.MovieName = alMovieList[0].ToString();
                    txtMovieName.Text = vdb.MovieName;
                    txtLocation.Text = vdb.Location;
                    txtLanguage.Text = vdb.Language;
                    txtDirector.Text = vdb.Director;
                    txtGenre.Text = vdb.Genre;
                    txtKeywords.Text = vdb.Keywords;
                    txtStarCast.Text = vdb.StarCast;
                    txtYear.Text = vdb.Year;

                    if (vdb.HasSubtitle)
                    {
                        chkSubtitles.Checked = true;
                    }
                    else
                    {
                        chkSubtitles.Checked = false;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (alMovieList.Count > 1)
            {
                foreach (String strMovieName in alMovieList)
                {
                    vdb.MovieName = strMovieName;
                    if (vdb.Exists())
                    {
                        vdb.Director = (vdb.Director.Length == 0) ? txtDirector.Text
                            : (vdb.Director.Contains(txtDirector.Text)) ? vdb.Director
                            : vdb.Director + "," + txtDirector.Text;

                        vdb.Genre = (vdb.Genre.Length == 0) ? txtGenre.Text
                            : (vdb.Genre.Contains(txtGenre.Text)) ? vdb.Genre
                            : vdb.Genre + "," + txtGenre.Text;

                        vdb.Language = (vdb.Language.Length == 0) ? txtLanguage.Text
                            : (vdb.Language.Contains(txtLanguage.Text)) ? vdb.Language
                            : vdb.Language + "," + txtLanguage.Text;

                        vdb.StarCast = (vdb.StarCast.Length == 0) ? txtStarCast.Text
                            : (vdb.StarCast.Contains(txtStarCast.Text)) ? vdb.StarCast
                            : vdb.StarCast + "," + txtStarCast.Text;

                        //vdb.Year = txtYear.Text;
                        vdb.Keywords = (vdb.Keywords.Length == 0) ? txtKeywords.Text
                            : (vdb.Keywords.Contains(txtKeywords.Text)) ? vdb.Keywords
                            : vdb.Keywords + "," + txtKeywords.Text;
                    }
                }
            }
            else
            {
                vdb.MovieName = alMovieList[0].ToString();
                if (vdb.Exists())
                {
                    vdb.ChangeMovieName(alMovieList[0].ToString(),txtMovieName.Text);
                    vdb.Director = txtDirector.Text;
                    vdb.Genre = txtGenre.Text;
                    vdb.Language = txtLanguage.Text;
                    vdb.StarCast = txtStarCast.Text;
                    //vdb.Year = txtYear.Text;
                    vdb.Keywords = txtKeywords.Text;
                }
            }
            if (alMovieList.Count == 1)
            {
                vdb.Location = txtLocation.Text;
            }
            this.Close();
        }
    }
}
