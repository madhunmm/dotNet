using System;
using System.Collections;

namespace LogParser
{
    class Category
    {
        private String strName;
        private ArrayList parsedList;

        public Category(String str)
        {
            strName = str;
            parsedList = new ArrayList();
        }

        public String GetCategoryName()
        {
            return strName;
        }

        public ArrayList GetParsedList()
        {
            return parsedList;
        }

        public Boolean AddParsedItem(Object item)
        {
            if (item != null)
            {
                parsedList.Add(item);
                return true;
            }
            return false;
        }
    }
}
