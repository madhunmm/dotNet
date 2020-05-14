using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Parser p = new Parser("C:\\Documents and Settings\\DNA\\My Documents\\Logs\\UNI6505L3-53_DNADebug.log");
            p.Parse();
        }
    }
}
