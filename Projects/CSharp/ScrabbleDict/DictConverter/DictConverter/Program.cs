using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    struct WaitingList
    {
        public String strParent;
        public String strUsage;
    };

    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Process();
        }
        public void Process()
        {
            WordList wordList;
            wordList = new WordList();
            System.IO.StreamReader fsr = new System.IO.StreamReader(new System.IO.FileStream(".\\dict.txt", System.IO.FileMode.Open));
            while (!fsr.EndOfStream)
            {
                String str = fsr.ReadLine();

                Word w = new Word(str);
                wordList.addWord(w);
            }
            fsr.Close();

            wordList.printList();
            // Old Word list indexed
            // Now open the new wordlist and for each word, check if it is already there in the old word list
            fsr = new System.IO.StreamReader(new System.IO.FileStream(".\\ospd4.txt", System.IO.FileMode.Open));
            WordList newWordList = new WordList();

            // Parse the twl2def worldlist

            WordList dictionary = new WordList();
            ArrayList alWaitingList = new ArrayList();

            loadDictionary(dictionary, alWaitingList);


            // Process the waiting list
            for (int i = 0; i < alWaitingList.Count; i++)
            {
                WaitingList wl = (WaitingList)alWaitingList[i];
                Word w = dictionary.getWord(wl.strParent);
                if (w != null)
                {
                    String[] strNewusages = new String[] { wl.strUsage };
                    w.addUsages(strNewusages);
                }
            }

            while (!fsr.EndOfStream)
            {
                String str = fsr.ReadLine();

                // First check for it in the existing wordlist section
                if (wordList.getWord(str) == null)
                {
                    Console.Write(str);

                    // If not present, open the dictionary and get the meaning
                    Word newWord = dictionary.getWord(str);
                    if (newWord != null)
                    {
                        if (newWordList.getWord(str) == null)
                        {
                            newWordList.addWord(newWord);
                        }
                        Console.WriteLine(" - " + newWord.getMeaning());
                        
                    }
                    else
                    {
                        //for (int m = 0; m < newWord.getUsages().Length; m++)
                        //{
                        //    strLine = strLine + newWord.getUsages()[m] + " ";
                        //}
                        //strLine = strLine + "\\ ";
                        //strLine = strLine + newWord.getWord() + " ";
                        //strLine = strLine + "NO MEANING";
                        //Console.WriteLine(" - NO MEANING");
                    }

                    
                }
            }
            fsr.Close();
            newWordList.printList();
        }
        private void loadDictionary(WordList dictionary, ArrayList alWaitingList)
        {
            System.IO.StreamReader fsr1 = new System.IO.StreamReader(new System.IO.FileStream(".\\twl2defs.txt", System.IO.FileMode.Open));
            while (!fsr1.EndOfStream)
            {
                String str1 = fsr1.ReadLine();
                int pos = str1.IndexOf(' ');
                String strWord = str1.Substring(0, pos).ToUpper().Trim();
                String strMeaning = str1.Substring(pos).Trim();


                // If the meaning is pointing to an existing entry
                // then do not add this word. Instead add the word as an usage to the existing word
                int posOfIndexer = strMeaning.IndexOf('<');
                if (posOfIndexer == 0)
                {
                    String strParent = strMeaning.Substring(posOfIndexer + 1, strMeaning.IndexOf('=') - 1);
                    Word w = dictionary.getWord(strParent);
                    if (w != null)
                    {
                        String[] strNewusages = new String[] { strWord };
                        w.addUsages(strNewusages);
                    }
                    else
                    {
                        // Put the word in a waiting list
                        WaitingList wl = new WaitingList();
                        wl.strParent = strParent;
                        wl.strUsage = strWord;
                        alWaitingList.Add(wl);
                    }
                }
                else
                {
                    Word w = new Word(strWord);
                    w.setMeaning(strMeaning);
                    dictionary.addWord(w);
                }
            }
            fsr1.Close();
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
            if (pos >= 0)
            {
                this.usages = str.Substring(0, pos).Trim().Split(' ');
                int wordEnd = str.IndexOf(' ', pos + 2);
                this.word = str.Substring(pos + 1, wordEnd - pos).Trim();
                this.meaning = str.Substring(wordEnd).Trim();
            }
            else
            {
                this.word = str;
                this.usages = new String[]{str.ToLower()};
                
            }
        }
        public String getWord()
        {
            return word;
        }
        public String[] getUsages()
        {
            return usages;
        }
        public void addUsages(String[] newUsages)
        {
            ArrayList tempAL = new ArrayList(usages);
            for(int i=0;i<newUsages.Length;i++)
            {
                tempAL.Add(newUsages[i].ToLower());
            }
            usages = (String[])tempAL.ToArray(typeof(String)) as String[];
            
        }
        public String getMeaning()
        {
            return meaning;
        }
        public void setMeaning(String str)
        {
            meaning = str;
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
            for (int i = 0; i < list[bucket].Count; i++)
            {
                Word w = (Word)(list[bucket][i]);
                String[] strUsages = w.getUsages();
                for (int j = 0; j < strUsages.Length; j++)
                {
                    if(name.Equals(strUsages[j].ToLower()))
                    {
                        return w;
                    }
                }
            }
            return null;
        }

        // A Comparer for easy search.
        protected class EntryComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return (new CaseInsensitiveComparer().Compare(((Word)x).getWord(), ((Word)y).getWord()));
            }
        }

        public void printList()
        {
            String strLine = ""; // to be written
            
            // Open a new file to write the new words
            System.IO.StreamWriter fsrWriting = new System.IO.StreamWriter(new System.IO.FileStream(".\\output.txt",System.IO.FileMode.OpenOrCreate));

            for (int bucket = 0; bucket < 26; bucket++)
            {
                IComparer comp = new EntryComparer();
                list[bucket].Sort(comp);

                for (int i = 0; i < list[bucket].Count; i++)
                {
                    Word w = (Word)(list[bucket][i]);

                    for (int m = 0; m < w.getUsages().Length; m++)
                    {
                        strLine = strLine + w.getUsages()[m] + " ";
                    }
                    strLine = strLine + "\\ ";
                    strLine = strLine + w.getWord() + " ";
                    strLine = strLine + w.getMeaning();

                    // Write it
                    fsrWriting.WriteLine(strLine);
                    strLine = "";
                }
            }
            fsrWriting.Close();            
        }
        
    }
}

