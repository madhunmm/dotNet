using System;
using System.Collections;
using System.IO;

namespace LogParser
{
    class HandlerManager
    {
        private ArrayList handlerList;

        public HandlerManager()
        {
            handlerList = new ArrayList();
            InitializeHandlers();
        }

        private void InitializeHandlers()
        {
            // Keep adding all new handlers here
            handlerList.Add(new ErrorHandler());
            handlerList.Add(new UserGroupHandler());
        }

        public void HandleLog(String strLog, StreamReader fileReader)
        {
            foreach (Handler h in handlerList)
            {
                h.Handle(strLog,fileReader);
            }
        }
    }
}
