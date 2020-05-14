using System;
using System.IO;

namespace GRE_Master
{
    public abstract class Serializer
    {
        private Boolean bChanged;
        protected StreamReader fileReader;
        protected StreamWriter fileWriter;
        protected const char delimiter = '#';
        protected const char newline = '$';
        protected String strFilename; 
        protected String strBackupFilename;

        public Serializer()
        {
            bChanged = false;
        }

        public Serializer(String strFilename)
            : this()
        {
            this.strFilename = ".\\" + strFilename;
            strBackupFilename = Path.ChangeExtension(this.strFilename, "bak");
        }

        abstract protected void load(WordList wl);

        abstract protected void save(WordList wl);

        public void loadWordList(Object owl)
        {
            WordList wl = (WordList)owl;
            if (File.Exists(strFilename))
            {
                load(wl);
            }
        }

        public void saveWordList(WordList wl)
        {
            if ((wl.getCount() > 0) && (bChanged))// No use otherwise
            {
                PreSaveProcess();
                save(wl);
            }
        }

        public void setChanged(Boolean value)
        {
            bChanged = value;
        }

        void PreSaveProcess()
        {
            // OK, first let us take a backup of the previous
            // Word list..I have my apprehensions..
            if (File.Exists(strFilename))
            {
                File.Copy(strFilename, strBackupFilename, true);
            }
        }

        public abstract int GetPercentSerialized();
        
    }
}
