using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Video_Library
{
    public partial class ViewDetails : Form
    {
        private static ViewDetails m_ViewDetails;
        public ViewDetails()
        {
            InitializeComponent();
        }

        private static ViewDetails Instance()
        {
            if (m_ViewDetails == null)
            {
                m_ViewDetails = new ViewDetails();
            }
            return m_ViewDetails;
        }

        public static void ShowPage()
        {
            Instance().Show();
        }

        public static void HidePage()
        {
            Instance().Hide();
        }

        private void ViewDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_ViewDetails = null;
        }
    }
}
