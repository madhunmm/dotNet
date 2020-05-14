using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Issue_Status
{
    public partial class IssueStatus : Form
    {
        private OleDbConnection conn;
        public IssueStatus()
        {
            InitializeComponent();
        }

        private void IssueStatus_Load(object sender, EventArgs e)
        {
            try
            {
                String strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\star.mdb;Persist Security Info=False";
                conn = new OleDbConnection(strConnectionString);
                conn.Open();
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to open the database","Issue Status");
                this.Close();
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            int openCount = 0,
                closedCount = 0,
                workingCount = 0,
                sev1Count = 0,
                sev2Count = 0,
                sev3Count = 0,
                sev4Count = 0,
                age30Count = 0,
                age60Count = 0,
                age90Count = 0,
                age90abCount = 0;

            if (dtpFrom.Value < dtpTo.Value)
            {
                String strOpenIssuesCountQuery = "select count(*) as opencount from issues where transferDate >= #" + dtpFrom.Text + "# and transferDate <= #" + dtpTo.Text + "#";
                String strClosedIssuesCountQuery = "select count(*) as closedcount from issues where closeDate >= #" + dtpFrom.Text + "# and closeDate <= #" + dtpTo.Text + "#";
                String strWorkingIssuesCountQuery = "select count(*) as workingcount from issues where transferDate <= #" + dtpTo.Text + "# and #" + dtpTo.Text + "# < closedate";
                String strWorkingInfoQuery = "select * from issues where transferDate <= #" + dtpTo.Text + "# and #" + dtpTo.Text + "# < closedate";

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                cmd.CommandText = strOpenIssuesCountQuery;
                openCount = (int)cmd.ExecuteScalar();

                cmd.CommandText = strClosedIssuesCountQuery;
                closedCount = (int)cmd.ExecuteScalar();

                cmd.CommandText = strWorkingIssuesCountQuery;
                workingCount = (int)cmd.ExecuteScalar();

                cmd.CommandText = strWorkingInfoQuery;
                OleDbDataReader dr = cmd.ExecuteReader();

                int age;
                while (dr.Read())
                {
                    switch ((int)dr["priority"])
                    {
                        case 1:
                            sev1Count++;
                            break;
                        case 2:
                            sev2Count++;
                            break;
                        case 3:
                            sev3Count++;
                            break;
                        case 4:
                            sev4Count++;
                            break;
                    }
                    age = dtpTo.Value.Subtract((DateTime)dr["transferDate"]).Days;
                    if (age < 30)
                        age30Count++;
                    else if (age < 60)
                        age60Count++;
                    else if (age < 90)
                        age90Count++;
                    else
                        age90abCount++;
                }
            }
            lblOpenCount.Text = openCount.ToString();
            lblClosedCount.Text = closedCount.ToString();
            lblWorkingCount.Text = workingCount.ToString();
            lblSev1Count.Text = sev1Count.ToString();
            lblSev2Count.Text = sev2Count.ToString();
            lblSev3Count.Text = sev3Count.ToString();
            lblSev4Count.Text = sev4Count.ToString();
            lbl30Count.Text = age30Count.ToString();
            lbl60Count.Text = age60Count.ToString();
            lbl90Count.Text = age90Count.ToString();
            lbl90abCount.Text = age90abCount.ToString();
        }

        private void IssueStatus_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            btnGenerateReport_Click(sender, e);
        }
        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            btnGenerateReport_Click(sender, e);
        }
    }
}
