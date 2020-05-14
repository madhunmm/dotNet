using System;

namespace GRE_Master
{
    class TestFactory
    {
        public Test GetTest(WordList w, String strTestType,String strCriteria)
        {
            // Create the filtered wordlist
            WordList wl = new WordList();
            if (strCriteria != "All")
            {
                if (strCriteria.Length > 1)
                {
                    String[] strArray = strCriteria.Split(',');
                    String strFrom = strArray[0];
                    String strTo = strArray[1];

                    Boolean bStarted = false;
                    foreach (WordEntry we in w)
                    {
                        if ((we.GetWord() != strFrom.ToLower()))
                        {
                            if (!bStarted)
                                continue;
                        }
                        else
                        {
                            bStarted = true;
                        }
                        if (we.GetWord() == strTo.ToLower())
                        {
                            wl.AddEntry(we);
                            break;
                        }
                        wl.AddEntry(we);
                    }
                }
                else
                {
                    foreach (WordEntry we in w)
                    {
                        if (we.GetWord()[0] == strCriteria.ToLower()[0])
                        {
                            wl.AddEntry(we);
                        }
                    }
                }
            }
            else
            {
                wl = w;
            }

            if (strTestType == "Meaning->Word")
            {
                return new MeaningToWordTest(wl);
            }
            else if (strTestType == "Word->Meaning")
            {
                return new WordToMeaningTest(wl);
            }
            return null;
        }
    }
}
