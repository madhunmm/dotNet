using System;
using System.Windows.Forms;

namespace GRE_Master
{
    public partial class TestMode : Form
    {
        private WordList wl;
        public TestMode()
        {
            InitializeComponent();
        }

        public TestMode(WordList w):this()
        {
            FormMaintenance.GetInstance().RegisterTestMode(this);
            wl = w;

            // Add entries to list
            foreach (WordEntry we in wl)
            {
                cboFrom.Items.Add(we.GetWord());
                cboTill.Items.Add(we.GetWord());
            }
        }

        private void TestMode_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMaintenance.GetInstance().UnregisterTestMode();
            FormMaintenance.GetInstance().GetGREMasterInstance().Show();
        }

        private void btnBeginTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestFactory tf = new TestFactory();
            WordTest fw;
            String strCriteria = null;
            if (cboWordList.SelectedItem.ToString() == "All")
            {
                // Start point
                if (cboFrom.SelectedItem == null)
                {
                    strCriteria = cboFrom.Items[0].ToString();
                }
                else
                {
                    strCriteria = cboFrom.SelectedItem.ToString();
                }

                strCriteria = strCriteria + ",";

                // End point
                if (cboTill.SelectedItem == null)
                {
                    strCriteria = strCriteria + cboTill.Items[cboTill.Items.Count-1].ToString();
                }
                else
                {
                    strCriteria = strCriteria + cboTill.SelectedItem.ToString();
                }
            }
            else
            {
                strCriteria = cboWordList.SelectedItem.ToString();
            }

            if (rdbTest1.Checked == true)
            {
                fw = new WordTest(tf.GetTest(wl, "Meaning->Word", strCriteria));
            }
            else
            {
                fw = new WordTest(tf.GetTest(wl, "Word->Meaning", strCriteria));
            }
            fw.Show();
        }
    }
}
