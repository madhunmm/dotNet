using System.Collections;
using System;

namespace DS
{
    public class Trie : IDataStructure
    {
        // Members
        private char        m_char;
        private object      m_obj;
        private ArrayList   m_trieList;

        // Constructor
        public Trie()
        {
        }

        public Trie(char c)
        {
            m_char = c;
        }

        // Accessors
        public char getChar()
        {
            return m_char;
        }

        public void setValue(object val)
        {
            m_obj = val;
        }

        public object getValue()
        {
            return m_obj;
        }

        public int getChildCount()
        {
            return m_trieList.Count;
        }

        // Public Methods
        public void add(object key, object value)
        {
            string strKey = key.ToString();

            // Tokenize the key
            char[] tokens = strKey.ToCharArray();
            Trie tNewNode = null;

            // Add each key character to its own trie node
            // First search if the token already exists
            int tokenIndex = searchToken(tokens[0]);
            if (tokenIndex == -1)
            {
                // Create a new node
                tNewNode = new Trie(tokens[0]);

                // Add it to the list
                addToList(tNewNode);
            }
            else
            {
                // To Do: Typechecking before casting
                tNewNode = (Trie)m_trieList[tokenIndex];
            }
            // Remove the first character from key and 
            // pass it to the next level
            string strTemp = new string(tokens);
            strTemp = strTemp.Remove(0, 1);

            // Condition to break recursion.
            // Add value to the last key token node
            if (strTemp.Length == 0)
            {
                tNewNode.setValue(value);

                return;
            }
            // Recurse with remaining tokens
            tNewNode.add(strTemp, value);
        }

        public void remove(object key)
        {
            string strKey = key.ToString();

            // Tokenize the key
            char[] tokens = strKey.ToCharArray();
            Trie tNewNode = null;

            // Add each key character to its own trie node
            // First search if the token already exists
            int tokenIndex = searchToken(tokens[0]);
            if (tokenIndex == -1)
            {
                return;
            }
            else
            {
                // To Do: Typechecking before casting
                tNewNode = (Trie)m_trieList[tokenIndex];

                // Remove the first character from key and 
                // pass it to the next level
                string strTemp = new string(tokens);
                strTemp = strTemp.Remove(0, 1);

                // Condition to break recursion.
                // Remove it
                if (strTemp.Length == 0)
                {
                    tNewNode = null;
                    m_trieList.RemoveAt(tokenIndex);

                    return;
                }
                // Recurse with remaining tokens
                tNewNode.remove(strTemp);
                if ((tNewNode.getChildCount() == 0) && (tNewNode.getValue() == null))
                {
                    m_trieList.RemoveAt(tokenIndex);
                }
            }
        }

        public object getValue(object key)
        {
            string strKey = key.ToString();

            // Tokenize the key
            char[] tokens = strKey.ToCharArray();
            Trie tNewNode = null;

            // Add each key character to its own trie node
            // First search if the token already exists
            int tokenIndex = searchToken(tokens[0]);
            if (tokenIndex == -1)
            {
                return null;
            }
            else
            {
                // To Do: Typechecking before casting
                tNewNode = (Trie)m_trieList[tokenIndex];
            }
            // Remove the first character from key and 
            // pass it to the next level
            string strTemp = new string(tokens);
            strTemp = strTemp.Remove(0, 1);

            // Condition to break recursion.
            // Get value from the last key token node
            if (strTemp.Length == 0)
            {
                return tNewNode.m_obj;
            }
            // Recurse with remaining tokens
            return tNewNode.getValue(strTemp);
        }

        public void setValue(object key, object value)
        {
            string strKey = key.ToString();

            // Tokenize the key
            char[] tokens = strKey.ToCharArray();
            Trie tNewNode = null;

            // Add each key character to its own trie node
            // First search if the token already exists
            int tokenIndex = searchToken(tokens[0]);
            if (tokenIndex == -1)
            {
                return;
            }
            else
            {
                // To Do: Typechecking before casting
                tNewNode = (Trie)m_trieList[tokenIndex];
            }
            // Remove the first character from key and 
            // pass it to the next level
            string strTemp = new string(tokens);
            strTemp = strTemp.Remove(0, 1);

            // Condition to break recursion.
            // Set value to the last key token node
            if (strTemp.Length == 0)
            {
                tNewNode.m_obj = value;
                return;
            }
            // Recurse with remaining tokens
            tNewNode.setValue(strTemp,value);
        }

        public object getChildTries(object key)
        {
            string strKey = key.ToString();

            if (strKey.Length > 0)
            {
                // Tokenize the key
                char[] tokens = strKey.ToCharArray();
                Trie tNewNode = null;

                // Add each key character to its own trie node
                // First search if the token already exists
                int tokenIndex = searchToken(tokens[0]);
                if (tokenIndex == -1)
                {
                    return null;
                }
                else
                {
                    // To Do: Typechecking before casting
                    tNewNode = (Trie)m_trieList[tokenIndex];
                }
                // Remove the first character from key and 
                // pass it to the next level
                string strTemp = new string(tokens);
                strTemp = strTemp.Remove(0, 1);

                // Condition to break recursion.
                // Get trieList from the last key token node
                if (strTemp.Length == 0)
                {
                    return tNewNode.m_trieList;
                }
                // Recurse with remaining tokens
                return tNewNode.getChildTries(strTemp);
            }
            else
            {
                return m_trieList;
            }
        }

        // Private Methods
        protected int searchToken(char c)
        {
            if (m_trieList != null)
            {
                for (int index = 0; index < m_trieList.Count; index++)
                {
                    Trie tTemp = (Trie)m_trieList[index];
                    if (tTemp.getChar() == c)
                    {
                        return index;
                    }
                }
            }

            return -1;
        }
        
        private bool addToList(Trie t)
        {
            if (m_trieList == null)
            {
                m_trieList = new ArrayList();
            }
            m_trieList.Add(t);
            
            return true;
        }
    }
}