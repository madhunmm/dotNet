using System;
using System.Collections;

namespace GRE_Master
{
    public class WordEntry
    {
        private String      strWord;
        private ArrayList   strMeaningList;
        private ArrayList   strUsageList;
        private ArrayList   strOtherInfoList;

        // Constructors
        public WordEntry()
        {
            strWord = null;
            strMeaningList = new ArrayList();
            strUsageList = new ArrayList();
            strOtherInfoList = new ArrayList();
        }

        // Accessors/Mutators
        public String getWord()
        {
            return strWord;
        }

        public ArrayList getMeanings()
        {
            return strMeaningList;
        }

        public ArrayList getUsages()
        {
            return strUsageList;
        }

        public ArrayList getOtherInfo()
        {
            return strOtherInfoList;
        }

        public void setWord(String str)
        {
            if (str.Length > 0)
            {
                strWord = str;
            }
        }

        public void addMeaning(String str)
        {
            if (str.Length > 0)
            {
                strMeaningList.Add(str);
            }
        }

        public void addUsage(String str)
        {
            if (str.Length > 0)
            {
                strUsageList.Add(str);
            }
        }

        public void addOtherInfo(String str)
        {
            if (str.Length > 0)
            {
                strOtherInfoList.Add(str);
            }
        }

        public void clearMeanings()
        {
            strMeaningList = new ArrayList();
        }

        public void clearUsages()
        {
            strUsageList = new ArrayList();
        }

        public void clearOtherInfo()
        {
            strOtherInfoList = new ArrayList();
        }
    }
}
