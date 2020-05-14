using System;
using System.Drawing;
using System.Windows.Forms;

namespace GRE_Master
{
    public partial class WordTest : Form
    {
        private Test test;

        public WordTest()
        {
            InitializeComponent();
        }
        public WordTest(Test t):this()
        {
            FormMaintenance.GetInstance().RegisterFindWord(this);
            test = t;
            if (test != null)
            {
                lblTestType.Text = test.GetTestType();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            lblResult.Text = "";
            
            test.Generate();
            Object objQuestion = test.GetQuestion();
            if (objQuestion != null)
            {
                if (btnNext.Text == "Start")
                {
                    btnNext.Text = "Next";
                }
                if (objQuestion.GetType().Equals(txtQuestion.Lines.GetType()))
                {
                    txtQuestion.Lines = (String[])objQuestion;
                }
                else if (objQuestion.GetType().Equals(txtQuestion.Text.GetType()))
                {
                    txtQuestion.Text = (String)objQuestion;
                }
                txtAnswer.Focus();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Boolean bResult = false;
            Object objAnswer = test.GetAnswer();
            if(objAnswer != null)
            {
                if(objAnswer.GetType().Equals(txtAnswer.Lines.GetType()))
                {
                    if (txtAnswer.Lines == (String[])objAnswer)
                    {
                        bResult = true;
                    }
                    else
                    {
                        bResult = false;
                    }
                }
                else if(objAnswer.GetType().Equals(txtAnswer.Text.GetType()))
                {
                    if (txtAnswer.Text.ToLower().Trim() == (String)objAnswer)
                    {
                        bResult = true;
                    }
                    else
                    {
                        bResult = false;
                    }
                }
                if (bResult)
                {
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "Correct";
                    btnNext.Focus();
                    test.HasAnsweredCorrectly(true);
                }
                else
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "Wrong";
                    btnGiveup.Focus();

                }
            }
        }

        private void btnGiveup_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            Object objAnswer = test.GetAnswer();
            if (objAnswer != null)
            {
                if (objAnswer.GetType().Equals(txtAnswer.Lines.GetType()))
                {
                    txtAnswer.Lines = (String[])objAnswer;
                }
                else if (objAnswer.GetType().Equals(txtAnswer.Text.GetType()))
                {
                    txtAnswer.Text = (String)objAnswer;
                }
                btnNext.Focus();
            }
        }

        private void FindWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            test.ResetUsedIndexes();
            this.Hide();
            FormMaintenance.GetInstance().UnregisterFindWord();
            FormMaintenance.GetInstance().GetTestModeInstance().Show();
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnCheck_Click(sender,e);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            String strWord = test.GetWord();
            if (strWord != null)
            {
                this.Hide();
                WordListDialog wld = new WordListDialog(test.GetWordlist(), strWord);
                wld.Show();
            }
        }
    }
}
