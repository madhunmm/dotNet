using System;
using System.Windows.Forms;

namespace GRE_Master
{
    public partial class WordListDialog : Form
    {
        private WordList wl;
        private Boolean bIsUpdated;// status variable
        private Boolean bIsNormalFlow; // Check if this window is opened via the default flow

        public WordListDialog()
        {
            InitializeComponent();
        }

        public WordListDialog(WordList w):this()
        {
            FormMaintenance.GetInstance().RegisterWordListDialog(this);
            bIsUpdated = false;
            bIsNormalFlow = true;
            wl = w;

            // Add entries to list
            foreach (WordEntry we in wl)
            {
                lstWordList.Items.Add(we.GetWord());
            }
            lblCount.Text = wl.GetCount().ToString();
        }

        public WordListDialog(WordList w, String strInitial):this(w)
        {
            lstWordList.SelectedItem = strInitial;
            bIsNormalFlow = false;

            // Add and remove can be done only from WordListDlg.
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void WordListDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMaintenance.GetInstance().UnregisterWordListDialog();
            if (bIsNormalFlow)
            {
                FormMaintenance.GetInstance().GetGREMasterInstance().Show();
            }
            else
            {
                FormMaintenance.GetInstance().GetFindWordInstance().Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate if we have atleast the word
            if (txtWord.Text.Length > 0)
            {
                // Create a WordEntry object from input
                WordEntry we = new WordEntry();
                we.SetWord(txtWord.Text);

                // Meanings
                String[] strMeanings = txtMeanings.Lines;
                foreach(String str in strMeanings)
                {
                    if(str.Length >0)
                    {
                        we.AddMeaning(str);
                    }
                }
                // Usages
                String[] strUsages = txtUsages.Lines;
                foreach(String str in strUsages)
                {
                    if(str.Length >0)
                    {
                        we.AddUsage(str);
                    }
                }
                // Other info
                String[] strOther = txtOtherInfo.Lines;
                foreach(String str in strOther)
                {
                    if(str.Length >0)
                    {
                        we.AddOtherInfo(str);
                    }
                }
                
                // Now, we have the entry. Add it to the ArrayWordList
                Boolean ret = wl.AddEntry(we);

                // Update the UI.
                if (ret)
                {
                    lstWordList.Items.Add(we.GetWord());
                }

                Clear();
            }
            FormMaintenance.GetInstance().GetGREMasterInstance().GetSerializer().SetChanged(true);
        }

        private void lstWordList_Click(object sender, EventArgs e)
        {
            Clear();

            if (lstWordList.SelectedItem != null)
            {
                // Get the word that was selected.
                String strSelectedWord = lstWordList.SelectedItem.ToString();

                // Immediately search for this word in the word list
                WordEntry we = wl.FindEntry(strSelectedWord);
                if (we != null)
                {
                    // Populate the fields with the info
                    txtWord.Text = we.GetWord();
                    String[] strMeanings = new String[we.GetMeanings().Count];
                    for (int i = 0; i < we.GetMeanings().Count; i++)
                    {
                        strMeanings[i] = we.GetMeanings()[i].ToString();
                    }

                    String[] strUsages = new String[we.GetUsages().Count];
                    for (int i = 0; i < we.GetUsages().Count; i++)
                    {
                        strUsages[i] = we.GetUsages()[i].ToString();
                    }

                    String[] strOtherInfo = new String[we.GetOtherInfo().Count];
                    for (int i = 0; i < we.GetOtherInfo().Count; i++)
                    {
                        strOtherInfo[i] = we.GetOtherInfo()[i].ToString();
                    }
                    txtMeanings.Lines = strMeanings;
                    txtUsages.Lines = strUsages;
                    txtOtherInfo.Lines = strOtherInfo;
                }
            }
            btnUpdate.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Clear();

            // Get the word that was selected.
            if (lstWordList.SelectedItem != null)
            {
                String strSelectedWord = lstWordList.SelectedItem.ToString();

                // Immediately search for this word in the word list
                WordEntry we = wl.FindEntry(strSelectedWord);
                if (we != null)
                {
                    wl.RemoveEntry(we);
                }
                // Remove item from list
                lstWordList.Items.Remove(strSelectedWord);
            }
        }

        private void Clear()
        {
            // Clear all previous data
            txtWord.Text = "";
            txtMeanings.Text = "";
            txtUsages.Text = "";
            txtOtherInfo.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bIsUpdated)
            {
                WordEntry we = wl.FindEntry(txtWord.Text);
                if(we != null)
                {
                    // Meanings
                    String[] strMeanings = txtMeanings.Lines;
                    we.ClearMeanings();
                    foreach (String str in strMeanings)
                    {
                        if (str.Length > 0)
                        {
                            we.AddMeaning(str);
                        }
                    }
                    // Usages
                    String[] strUsages = txtUsages.Lines;
                    we.ClearUsages();
                    foreach (String str in strUsages)
                    {
                        if (str.Length > 0)
                        {
                            we.AddUsage(str);
                        }
                    }
                    // Other info
                    String[] strOther = txtOtherInfo.Lines;
                    we.ClearOtherInfo();
                    foreach (String str in strOther)
                    {
                        if (str.Length > 0)
                        {
                            we.AddOtherInfo(str);
                        }

                    }
                }
            }
            btnUpdate.Enabled = false;
            FormMaintenance.GetInstance().GetGREMasterInstance().GetSerializer().SetChanged(true);
        }

        private void txtOtherInfo_TextChanged(object sender, EventArgs e)
        {
            if (lstWordList.SelectedItem != null)
            {
                bIsUpdated = true;
                btnUpdate.Enabled = true;
            }
        }

        private void txtUsages_TextChanged(object sender, EventArgs e)
        {
            if (lstWordList.SelectedItem != null)
            {
                bIsUpdated = true;
                btnUpdate.Enabled = true;
            }
        }

        private void txtMeanings_TextChanged(object sender, EventArgs e)
        {
            if (lstWordList.SelectedItem != null)
            {
                bIsUpdated = true;
                btnUpdate.Enabled = true;
            }
        }

        private void lstWordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstWordList_Click(sender,e);
        }
    }
}
