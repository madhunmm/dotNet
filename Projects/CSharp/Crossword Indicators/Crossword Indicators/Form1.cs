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

namespace Crossword_Indicators
{
    public partial class frmIndicators : Form
    {
        private ArrayList indicatorList;
        
        private struct IndicatorNode
        {
            public String word;
            public String indicator;
        }

        public frmIndicators()
        {
            InitializeComponent();
            indicatorList = new ArrayList();
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            if (txtClue.Text != "")
            {
                dgvIndicators.Rows.Clear();
                String[] tokens = txtClue.Text.Split(' ');
                IndicatorNode indNode;
                for (int i = 0; i < indicatorList.Count - 1; i++)
                {
                    indNode = (IndicatorNode)indicatorList[i];
                    for (int j = 0; j < tokens.Count(); j++)
                    {
                        if (indNode.word.Contains(tokens[j]))
                        {
                            dgvIndicators.Rows.Add(indNode.word, indNode.indicator);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader fileReader = new StreamReader(".\\Indicators.csv");
            String line = null;
            while (!fileReader.EndOfStream)
            {
                line = fileReader.ReadLine();
                String[] tokens = line.Split(',');
                IndicatorNode indNode = new IndicatorNode();
                indNode.indicator = tokens[0].Trim();
                indNode.word = tokens[1].Trim();
                indicatorList.Add(indNode);
            }
            fileReader.Close();
        }

        private void txtClue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cmdFind_Click(sender,e);
        }
    }
}
