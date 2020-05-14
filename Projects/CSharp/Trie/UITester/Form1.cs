using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UITester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DS.IDataStructure t = new DS.Trie();
            StreamReader fileReader = new StreamReader(".\\dictionary.txt");
            while (fileReader.EndOfStream == false)
            {
                t.add(fileReader.ReadLine(), null);
            }
        }
    }
}
