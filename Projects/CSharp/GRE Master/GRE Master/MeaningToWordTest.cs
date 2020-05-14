using System;

namespace GRE_Master
{
    class MeaningToWordTest : Test
    {
        // Constructors
        public MeaningToWordTest(WordList w)
            : base(w)
        {
        }

        // Abstract methods implementation
        public override object GetQuestion()
        {
            if (we != null)
            {
                String[] strMeanings = new String[we.GetMeanings().Count];
                for (int i = 0; i < we.GetMeanings().Count; i++)
                {
                    strMeanings[i] = we.GetMeanings()[i].ToString();
                }
                return strMeanings;
            }
            return null;
        }

        public override object GetAnswer()
        {
            if (we != null)
            {
                return we.GetWord();
            }
            return null;
        }

        public override String GetTestType()
        {
            return ("Meaning->Word");
        }
    }
}
