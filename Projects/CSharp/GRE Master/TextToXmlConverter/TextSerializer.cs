using System;
using System.IO;

namespace GRE_Master
{
    class TextSerializer : Serializer
    {
        // Constructors
        public TextSerializer()
        {
            strFilename = ".\\WordList.txt";
            strBackupFilename = ".\\WordList.bak";
        }

        public TextSerializer(String strFileName)
            : base(strFileName)
        {
        }

        protected override void load(WordList wl)
        {
            fileReader = new StreamReader(strFilename);
            String strLine = null;
            while (!fileReader.EndOfStream)
            {
                WordEntry we = new WordEntry();
                strLine = fileReader.ReadLine();
                String[] fields = strLine.Split(delimiter);

                // First entry is the word
                we.setWord(fields[0]);

                // Second come the meanings.Here,we have to parse again
                String[] attrs = fields[1].Split(newline);
                foreach (String str in attrs)
                {
                    we.addMeaning(str);
                }

                // Third come the usages.
                if (fields.Length > 2)
                {
                    attrs = fields[2].Split(newline);
                    foreach (String str in attrs)
                    {
                        we.addUsage(str);
                    }
                }

                // Fourth come the Other info.
                if (fields.Length > 3)
                {
                    attrs = fields[3].Split(newline);
                    foreach (String str in attrs)
                    {
                        we.addOtherInfo(str);
                    }
                }

                // Now we have the entry ready. Add it to the word list
                wl.addEntry(we);
            }
            fileReader.Close();
            fileReader = null;
        }

        protected override void save(WordList wl)
        {
            fileWriter = new StreamWriter(strFilename, false);
            String strLine = null;
            foreach (WordEntry we in wl)
            {
                if (we != null)
                {
                    strLine = we.getWord();
                    strLine = strLine + delimiter;
                    foreach (String str in we.getMeanings())
                    {
                        strLine = strLine + str + newline;
                    }
                    strLine = strLine + delimiter;
                    foreach (String str in we.getUsages())
                    {
                        strLine = strLine + str + newline;
                    }
                    strLine = strLine + delimiter;
                    foreach (String str in we.getOtherInfo())
                    {
                        strLine = strLine + str + newline;
                    }

                    fileWriter.WriteLine(strLine);
                }
            }
            fileWriter.Flush();

            fileWriter.Close();
            fileWriter = null;

        }

        public override int GetPercentSerialized()
        {
            throw new NotImplementedException();
        }
    }
}
