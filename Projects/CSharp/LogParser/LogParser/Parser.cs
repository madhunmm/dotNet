using System;
using System.IO;

namespace LogParser
{
    class Parser
    {
        private StreamReader fileReader;
        private HandlerManager hm;

        public Parser(String strFilePath)
        {
            fileReader = new StreamReader(strFilePath);
            hm = new HandlerManager();
        }

        public void Parse()
        {
            while (!fileReader.EndOfStream)
            {
                hm.HandleLog(fileReader.ReadLine(),fileReader);
            }
        }
    }
}
