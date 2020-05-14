namespace GRE_Master
{
    // Singleton class just to ease Form-switching.
    class FormMaintenance
    {
        private GREMaster gm;
        private WordListDialog wld;
        private TestMode tm;
        private WordTest fw;
        private static FormMaintenance fm;

        private FormMaintenance()
        {
        }

        public static FormMaintenance GetInstance()
        {
            if (fm == null)
            {
                fm = new FormMaintenance();
            }
            return fm;
        }

        public GREMaster GetGREMasterInstance()
        {
            return gm;
        }

        public WordListDialog GetWordListDialogInstance()
        {
            return wld;
        }

        public TestMode GetTestModeInstance()
        {
            return tm;
        }

        public WordTest GetFindWordInstance()
        {
            return fw;
        }

        // Central Maintenance baby...
        public void RegisterGREMaster(GREMaster g)
        {
            gm = g;
        }

        public void RegisterWordListDialog(WordListDialog w)
        {
            wld = w;
        }

        public void RegisterTestMode(TestMode t)
        {
            tm = t;
        }

        public void RegisterFindWord(WordTest f)
        {
            fw = f;
        }

        // Just to ensure that in case we ask for the instance,
        // we do not get an old dead instance
        public void UnregisterGREMaster()
        {
            gm = null;
        }

        public void UnregisterWordListDialog()
        {
            wld = null;
        }

        public void UnregisterTestMode()
        {
            tm = null;
        }

        public void UnregisterFindWord()
        {
            fw = null;
        }
    }
}
