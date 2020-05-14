using System.IO;

namespace DS
{
    public class Tester
    {
        private IDataStructure t;
        public Tester()
        {
            t = new Trie();
        }
        //static void Main(string[] args)
        //{
        //    Tester test = new Tester();

        //    try
        //    {
        //        //test.testAdd();
        //        //test.testGetValue();
        //        //test.testSetValue();
        //        //test.testRemove();
        //        test.loadDict();
        //    }
        //    catch (System.Exception e)
        //    {
        //        System.Console.WriteLine("FAILURES!!!");
        //        System.Console.WriteLine(e.Message);
        //        return;
        //    }
        //    System.Console.WriteLine("ALL TESTS COMPLETED SUCCESSFULLY!!!");
        //}
        
        public void testAdd()
        {
            t.add("car", 1);
            t.add("care", 2);
            t.add("carp", 3);
            t.add("carry", 4);
        }

        public void testGetValue()
        {
            if ((int)t.getValue("care") != 2)
                throw new System.Exception();
            if((int)t.getValue("carp") != 3)
                throw new System.Exception();
            if((int)t.getValue("car") != 1)
                throw new System.Exception();
            if ((int)t.getValue("carry") != 4)
                throw new System.Exception();
        }
        public void testSetValue()
        {
            t.setValue("car", 23);
            t.setValue("care", 24);
            t.setValue("carp", 25);
            t.setValue("carry", 26);

            if ((int)t.getValue("care") != 24)
                throw new System.Exception();
            if ((int)t.getValue("carp") != 25)
                throw new System.Exception();
            if ((int)t.getValue("car") != 23)
                throw new System.Exception();
            if ((int)t.getValue("carry") != 26)
                throw new System.Exception();
        }
        public void testRemove()
        {
            t.remove("carry");
            if (t.getValue("carry") != null)
                throw new System.Exception();
        }

        public void loadDict()
        {
            StreamReader fileReader = new StreamReader(".\\dictionary.txt");
            while (fileReader.EndOfStream == false)
            {
                t.add(fileReader.ReadLine(),null);
            }
        }
    }
}