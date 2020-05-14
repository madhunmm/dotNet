using System;
using System.Collections;

namespace GRE_Master
{
    public abstract class Test
    {
        protected WordList wl;
        protected WordEntry we;
        private ArrayList generatedIndexList;

        // Constructors
        public Test(WordList w)
        {
            wl = w;
            generatedIndexList = new ArrayList();
        }

        // Abstract methods
        abstract public Object GetQuestion();
        abstract public Object GetAnswer();
        abstract public String GetTestType();

        // Default methods
        public void Generate()
        {
            if (generatedIndexList.Count == wl.GetCount())
            {
                ResetUsedIndexes();
            }
            if (wl.GetCount() > 0)
            {
                int index = -1;
                do
                {
                    we = wl.GetRandomWord();
                    index = wl.GetIndexOf(we);
                } while (generatedIndexList.Contains(index));
            }
        }

        public String GetWord()
        {
            if (we != null)
            {
                return we.GetWord();
            }
            return null;
        }

        public WordList GetWordlist()
        {
            return wl;
        }

        public void HasAnsweredCorrectly(Boolean value)
        {
            if (value)
            {
                int index = wl.GetIndexOf(we);
                if (index >= 0)
                {
                    if (generatedIndexList == null)
                    {
                        generatedIndexList = new ArrayList();
                    }
                    if (!generatedIndexList.Contains(index))
                    {
                        generatedIndexList.Add(index);
                    }
                }
            }
        }

        public void ResetUsedIndexes()
        {
            generatedIndexList.Clear();
        }
    }
}
