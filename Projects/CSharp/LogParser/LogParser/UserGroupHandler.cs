using System;
using System.IO;
using System.Text;

namespace LogParser
{
    class UserGroupHandler : Handler
    {
        private class UserGroupObject
        {
            private String strUserName;
            private String[] strUserGroups;

            public UserGroupObject(String strName, String[] groups)
            {
                strUserName = strName;
                strUserGroups = groups;
            }
        }

        public override void Handle(String str,StreamReader fileReader)
        {
            str = str.ToLower();
            String strGroupsForMoniker = "groups for";
            String strGroupMoniker = "group =";
            if (str.Contains(strGroupsForMoniker))
            {
                int startpoint;
                int loc = str.IndexOf(strGroupsForMoniker);
                loc = loc + strGroupsForMoniker.Length + 2;
                int endpoint = str.LastIndexOf('"');
                String strAccountName = str.Substring(loc, endpoint - loc);

                StringBuilder strGroups = new StringBuilder();
                String strGeneral = null;
                while (!fileReader.EndOfStream)
                {
                    strGeneral = fileReader.ReadLine();
                    if (strGeneral.Contains(strGroupMoniker))
                    {
                        startpoint = strGeneral.IndexOf('"');
                        endpoint = strGeneral.LastIndexOf('"');
                        strGroups.Append(strGeneral.Substring(startpoint +1, endpoint - startpoint-1));
                        strGroups.Append(",");
                    }
                    else
                    {
                        break;
                    }
                }

                // Now we have the user goup info
                String[] groups = strGroups.ToString().Split(',');

                ObjectBucket ob = ObjectBucket.Instance();
                ob.AddParsedItem(new UserGroupObject(strAccountName, groups),"User Info");

            }
        }
    }
}
