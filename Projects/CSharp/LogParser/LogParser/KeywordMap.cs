using System.Collections;
using System;

namespace LogParser
{
    class KeywordMap
    {
        private Hashtable map;

        // Keywords
        private static const String errorMoniker = "Error"; 

        public KeywordMap()
        {
            map = new Hashtable();
            Initialize();
        }

        private void Initialize()
        {
            // Add any new keyword
            ErrorHandler errorHandler = new ErrorHandler();
            AddKeyword(errorMoniker, errorHandler);
        }

        public void AddKeyword(String key, Handler value)
        {
            map.Add(key, value);
        }

        public Handler GetHandler(String strKeyword)
        {
            return (Handler)map[strKeyword];
        }
    }
}
