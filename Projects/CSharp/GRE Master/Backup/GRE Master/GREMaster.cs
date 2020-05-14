using System;
using System.Windows.Forms;
using System.Threading;

namespace GRE_Master
{
    public partial class GREMaster : Form
    {
        private WordList wl;
        private Serializer serializer;
        public GREMaster()
        {
            InitializeComponent();
            wl = new WordList();
            serializer = new SerializerFactory().GetSerializer("WordList.xml");

            //Splash.ShowSplashScreen(serializer);
            //Thread.Sleep(2000);
            serializer.LoadWordList(wl);
            
            FormMaintenance.GetInstance().RegisterGREMaster(this);
        }

        private void btnWordList_Click(object sender, EventArgs e)
        {
            this.Hide();
            WordListDialog wld = new WordListDialog(wl);
            wld.Show();
        }

        private void btnTestMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestMode tm = new TestMode(wl);
            tm.Show();
        }

        private void GREMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            serializer.SaveWordList(wl);
        }

        public Serializer GetSerializer()
        {
            return serializer;
        }
    }
}
