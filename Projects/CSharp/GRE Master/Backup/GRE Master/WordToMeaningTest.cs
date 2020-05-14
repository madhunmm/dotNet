using System;

namespace GRE_Master
{
    class WordToMeaningTest : Test
    {
        // Constructors
        public WordToMeaningTest(WordList w)
            : base(w)
        {
        }

        public override Object GetQuestion()
        {
            if (we != null)
            {
                return we.GetWord();
            }
            return null;
        }

        public override Object GetAnswer()
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

        public override String GetTestType()
        {
            return ("Word->Meaning");
        }
    }
}
