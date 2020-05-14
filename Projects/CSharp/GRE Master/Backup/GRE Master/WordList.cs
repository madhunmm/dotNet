using System;
using System.Collections;

namespace GRE_Master
{
    public class WordList : IEnumerable
    {
        private ArrayList wordList;

        // Constructors
        public WordList()
        {
            wordList = new ArrayList();
        }

        // A Comparer for easy search.
        protected class EntryComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return (new CaseInsensitiveComparer().Compare(((WordEntry)x).GetWord(), ((WordEntry)y).GetWord()));
            }
        }

        public bool AddEntry(WordEntry we)
        {
            if ((we != null) && (!wordList.Contains(we)))
            {
                wordList.Add(we);
                return true;
            }
            return false;
        }

        public WordEntry FindEntry(string strSelectedWord)
        {
            IComparer comp = new EntryComparer();
            wordList.Sort(comp);
            WordEntry we = new WordEntry();
            we.SetWord(strSelectedWord);

            int index = wordList.BinarySearch(we, comp);

            if (index >= 0)
            {
                return (WordEntry)wordList[index];
            }
            return null;
        }

        public int GetCount()
        {
            return wordList.Count;
        }

        public void RemoveEntry(WordEntry we)
        {
            if ((we != null) && (wordList.Contains(we)))
            {
                wordList.Remove(we);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return wordList.GetEnumerator();
        }

        public WordEntry GetRandomWord()
        {
            if (wordList.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(wordList.Count);
                return (WordEntry)wordList[index];
            }
            return null;
        }

        public int GetIndexOf(WordEntry we)
        {
            return wordList.IndexOf(we);
        }
    }
}