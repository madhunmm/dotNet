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
        public String GetWord()
        {
            return strWord;
        }

        public ArrayList GetMeanings()
        {
            return strMeaningList;
        }

        public ArrayList GetUsages()
        {
            return strUsageList;
        }

        public ArrayList GetOtherInfo()
        {
            return strOtherInfoList;
        }

        public void SetWord(String str)
        {
            if (str.Length > 0)
            {
                strWord = str;
            }
        }

        public void AddMeaning(String str)
        {
            if (str.Length > 0)
            {
                strMeaningList.Add(str);
            }
        }

        public void AddUsage(String str)
        {
            if (str.Length > 0)
            {
                strUsageList.Add(str);
            }
        }

        public void AddOtherInfo(String str)
        {
            if (str.Length > 0)
            {
                strOtherInfoList.Add(str);
            }
        }

        public void ClearMeanings()
        {
            strMeaningList = new ArrayList();
        }

        public void ClearUsages()
        {
            strUsageList = new ArrayList();
        }

        public void ClearOtherInfo()
        {
            strOtherInfoList = new ArrayList();
        }
    }
}
