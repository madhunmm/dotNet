using System;
using System.Collections;

namespace LogParser
{
    class ObjectBucket
    {
        private ArrayList categoryList;
        private static ObjectBucket bucket;

        private ObjectBucket()
        {
            categoryList = new ArrayList();
        }

        public static ObjectBucket Instance()
        {
            if (bucket == null)
            {
                bucket = new ObjectBucket();
            }
            return bucket;
        }

        public Category GetCategory(String strName)
        {
            foreach (Category c in categoryList)
            {
                if (c.GetCategoryName() == strName)
                {
                    return c;
                }
            }
            
            Category newCategory = new Category(strName);
            categoryList.Add(newCategory);

            return newCategory;
        }

        public Boolean AddParsedItem(Object item, String strCategory)
        {
            if (item != null)
            {
                Category c = GetCategory(strCategory);
                return c.AddParsedItem(item);
            }
            return false;
           
        }

    }
}
