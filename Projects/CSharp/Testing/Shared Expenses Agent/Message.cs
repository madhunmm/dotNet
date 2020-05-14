using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snooper
{
    class Message
    {
        private String strRequest;
        private String strResponse;

        public Message()
        {
            strRequest = "";
            strResponse = "";
        }

        public Message(String strRequest)
            : base()
        {
            this.strRequest = strRequest;
        }

        public String Request
        {
            get
            {
                return strRequest;
            }
            set
            {
                strRequest = value;
            }
        }

        public String Response
        {
            get
            {
                return strResponse;
            }
            set
            {
                strResponse = value;
            }
        }
    }
}
