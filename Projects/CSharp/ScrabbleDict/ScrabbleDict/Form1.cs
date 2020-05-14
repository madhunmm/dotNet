using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScrabbleDict
{
    public partial class Form1 : Form
    {
        private WordList wordList;
        private SpeechLib.SpVoice reader;

        public Form1()
        {
            InitializeComponent();
            wordList = new WordList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader fsr = new System.IO.StreamReader(new System.IO.FileStream(".\\dict.txt", System.IO.FileMode.Open));
            while (!fsr.EndOfStream)
            {
                String str = fsr.ReadLine();

                Word w = new Word(str);
                wordList.addWord(w);
                comboBox1.Items.Add(w.getWord().ToLower());
                comboBox1.SelectedIndex = 0;
            }
            reader = new SpeechLib.SpVoice();            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String str = comboBox1.SelectedItem.ToString();
            Word w = wordList.getWord(str);
            if (w != null)
            {
                String[] usages = w.getUsages();
                for (int i = 0; i < usages.GetLength(0); i++)
                {
                    listBox1.Items.Add(usages[i]);
                }
                textBox1.Text = w.getMeaning();
            }
            Refresh();
            if (checkBox2.Checked)
            {
                reader.Speak(comboBox1.Text,SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault);
                reader.Speak("usages",SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault);
                for (int i = 0; i < listBox1.Items.Count; i++)
                    reader.Speak(listBox1.Items[i].ToString(), SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault);
                reader.Speak("meaning", SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault);
                reader.Speak(textBox1.Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String str = comboBox1.Text;
            if (str != "")
            {
                Word w = wordList.getWord(str);
                if (w != null)
                {
                    String[] usages = w.getUsages();
                    for (int i = 0; i < usages.GetLength(0); i++)
                    {
                        listBox1.Items.Add(usages[i]);
                    }
                    textBox1.Text = w.getMeaning();
                }
                else
                {
                    textBox1.Text = "";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;
            Random r = new Random();
            int index = r.Next() % count;
            comboBox1.SelectedIndex = index;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }
    class Word
    {
        private String word;
        private String[] usages;
        private String meaning;

        public Word(String str)
        {
            parseString(str);
        }
        private void parseString(String str)
        {
            int pos = str.IndexOf('\\');
            this.usages = str.Substring(0, pos).Trim().Split(' ');
            int wordEnd = str.IndexOf(' ', pos + 2);
            this.word = str.Substring(pos + 1, wordEnd - pos).Trim();
            this.meaning = str.Substring(wordEnd).Trim();
        }
        public String getWord()
        {
            return word;
        }
        public String[] getUsages()
        {
            return usages;
        }
        public String getMeaning()
        {
            return meaning;
        }
    }
    class WordList
    {
        private System.Collections.ArrayList[] list;

        public WordList()
        {
            list = new System.Collections.ArrayList[26];
            for (int i = 0; i < 26; i++)
            {
                list[i] = new System.Collections.ArrayList();
            }
            list.Cast<Word>();
        }
        public void addWord(Word w)
        {
            int bucket = w.getWord().ToLower()[0] - 'a';
            list[bucket].Add(w);
        }
        public Word getWord(String name)
        {
            int bucket = name.ToLower()[0] - 'a';
            for (int i = 0; i < list[bucket].Count; i++)
            {
                Word w = (Word)(list[bucket][i]);
                if (w.getWord().Equals(name.ToUpper()))
                {
                    return w;
                }
            }
            return null;
        }

    }
}
