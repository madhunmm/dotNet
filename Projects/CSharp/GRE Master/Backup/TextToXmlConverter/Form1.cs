using System;
using System.Windows.Forms;
using GRE_Master;

namespace TextToXmlConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.SafeFileName;
            }

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            WordList wl;
            Serializer serializer;

            wl = new WordList();
            serializer = new SerializerFactory().getSerializer("WordList.txt");

            serializer.loadWordList(wl);

            serializer = new SerializerFactory().getSerializer("WordList.xml");
            serializer.setChanged(true);
            serializer.saveWordList(wl);
        }
    }
}
