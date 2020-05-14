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

        protected override void Load(WordList wl)
        {
            fileReader = new StreamReader(strFilename);
            String strLine = null;
            while (!fileReader.EndOfStream)
            {
                WordEntry we = new WordEntry();
                strLine = fileReader.ReadLine();
                String[] fields = strLine.Split(delimiter);

                // First entry is the word
                we.SetWord(fields[0]);

                // Second come the meanings.Here,we have to parse again
                String[] attrs = fields[1].Split(newline);
                foreach (String str in attrs)
                {
                    we.AddMeaning(str);
                }

                // Third come the usages.
                attrs = fields[2].Split(newline);
                foreach (String str in attrs)
                {
                    we.AddUsage(str);
                }

                // Fourth come the Other info.
                attrs = fields[3].Split(newline);
                foreach (String str in attrs)
                {
                    we.AddOtherInfo(str);
                }

                // Now we have the entry ready. Add it to the word list
                wl.AddEntry(we);
            }
            fileReader.Close();
            fileReader = null;
        }

        protected override void Save(WordList wl)
        {
            fileWriter = new StreamWriter(strFilename, false);
            String strLine = null;
            foreach (WordEntry we in wl)
            {
                if (we != null)
                {
                    strLine = we.GetWord();
                    strLine = strLine + delimiter;
                    foreach (String str in we.GetMeanings())
                    {
                        strLine = strLine + str + newline;
                    }
                    strLine = strLine + delimiter;
                    foreach (String str in we.GetUsages())
                    {
                        strLine = strLine + str + newline;
                    }
                    strLine = strLine + delimiter;
                    foreach (String str in we.GetOtherInfo())
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
