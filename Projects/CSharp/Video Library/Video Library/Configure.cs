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
    public partial class Configure : Form
    {
        private VideoDatabase vdb;
        private static Configure m_Configure;

        public Configure()
        {
            InitializeComponent();
            vdb = VideoDatabase.Instance();
        }

        private static Configure Instance()
        {
            if (m_Configure == null)
            {
                m_Configure = new Configure();
            }
            return m_Configure;
        }

        public static void ShowPage()
        {
            Instance().Show();
        }

        public static void HidePage()
        {
            Instance().Hide();
        }

        private void Configure_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_Configure = null;
        }

        private void Configure_Load(object sender, EventArgs e)
        {
            ArrayList alFileTypes = vdb.GetExtensions();
            ArrayList alSearchPaths = vdb.GetSearchPaths();

            lstExtensions.Items.Clear();
            foreach (String str in alFileTypes)
            {
                lstExtensions.Items.Add(str);
            }

            lstSearchPaths.Items.Clear();
            foreach (String str in alSearchPaths)
            {
                lstSearchPaths.Items.Add(str);
            }
        }

        private void btnAddFileType_Click(object sender, EventArgs e)
        {
            if (txtNewFileType.Text != "")
            {
                if (!lstExtensions.Items.Contains(txtNewFileType.Text))
                {
                    lstExtensions.Items.Add(txtNewFileType.Text);
                    vdb.AddExtension(txtNewFileType.Text);
                }
            }
        }

        private void btnSearchAdd_Click(object sender, EventArgs e)
        {
            if (txtNewPath.Text != "")
            {
                if (!lstSearchPaths.Items.Contains(txtNewPath.Text))
                {
                    lstSearchPaths.Items.Add(txtNewPath.Text);
                    vdb.AddSearchPath(txtNewPath.Text);
                }
            }
        }

        private void btnSearchPathRemove_Click(object sender, EventArgs e)
        {
            vdb.RemoveSearchPath(lstSearchPaths.SelectedItem.ToString());
            lstSearchPaths.Items.Remove(lstSearchPaths.SelectedItem);
        }

        private void btnFileTypeRemove_Click(object sender, EventArgs e)
        {
            vdb.RemoveExtension(lstExtensions.SelectedItem.ToString());
            lstExtensions.Items.Remove(lstExtensions.SelectedItem);
        }

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            fbdFolderBrowse.ShowDialog();
            txtNewPath.Text = fbdFolderBrowse.SelectedPath;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
