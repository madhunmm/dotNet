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

        abstract protected void Load(WordList wl);

        abstract protected void Save(WordList wl);

        public void LoadWordList(Object owl)
        {
            WordList wl = (WordList)owl;
            if (File.Exists(strFilename))
            {
                Load(wl);
            }
        }

        public void SaveWordList(WordList wl)
        {
            if ((wl.GetCount() > 0) && (bChanged))// No use otherwise
            {
                PreSaveProcess();
                Save(wl);
            }
        }

        public void SetChanged(Boolean value)
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
