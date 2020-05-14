using System;
using System.Xml;
using System.Collections;
using System.IO;
using System.Threading;

namespace Shared_Expenses_Agent
{
    class MessageManager
    {
        private const String strRequestMoniker = "REQUEST";
        private const String strResponseMoniker = "RESPONSE";
        private const String strErrorMoniker = "ERROR";
        private const String strEntryMoniker = "ENTRY";
        
        // Constructors
        public MessageManager()
        {
        }

        // abstract method implementation
        public void Parse()
        {
            XmlDocument xd = new XmlDocument();
            XmlTextReader xtr = new XmlTextReader(strFilename);
            xtr.Read();
            xd.Load(xtr);
            XmlNodeList xnl = xd.GetElementsByTagName(strWordEntryMoniker);
            iTotalWords = xnl.Count;
            foreach (XmlNode xn in xnl)
            {
                WordEntry we = new WordEntry();
                foreach (XmlNode xnSubElements in xn.ChildNodes)
                {
                    if (xnSubElements.Name == strWordMoniker)
                    {
                        we.SetWord(xnSubElements.InnerText.Trim());
                    }
                    else if (xnSubElements.Name == strMeaningMoniker)
                    {
                        we.AddMeaning(xnSubElements.InnerText.Trim());
                    }
                    else if (xnSubElements.Name == strUsageMoniker)
                    {
                        we.AddUsage(xnSubElements.InnerText.Trim());
                    }
                    else if (xnSubElements.Name == strOtherInfoMoniker)
                    {
                        we.AddOtherInfo(xnSubElements.InnerText.Trim());
                    }
                }
                wl.AddEntry(we);
                iWordsLoaded++;
            }
        }

        public Stream CreateGetDatabaseRequest()
        {
            Stream stRequest = new Stream();
            XmlTextWriter xtw = new XmlTextWriter(stRequest, null);
            xtw.WriteStartDocument();
            xtw.WriteStartElement(strRequestMoniker);
            xtw.WriteStartElement(strWordEntryMoniker);

            xtw.WriteStartElement(strWordMoniker);
            xtw.WriteString(we.GetWord());
            xtw.WriteEndElement();

            foreach (String strMeaning in we.GetMeanings())
            {
                xtw.WriteStartElement(strMeaningMoniker);
                xtw.WriteString(strMeaning);
                xtw.WriteEndElement();
            }

            foreach (String strUsage in we.GetUsages())
            {
                xtw.WriteStartElement(strUsageMoniker);
                xtw.WriteString(strUsage);
                xtw.WriteEndElement();
            }

            foreach (String strOtherInfo in we.GetOtherInfo())
            {
                xtw.WriteStartElement(strOtherInfoMoniker);
                xtw.WriteString(strOtherInfo);
                xtw.WriteEndElement();
            }

            xtw.WriteEndElement();
            
            xtw.WriteEndElement();

            xtw.WriteEndDocument();

            xtw.Close();

            return stRequest;
        }

        public override int GetPercentSerialized()
        {
            if (iTotalWords > 0)
            {
                double iPercent = (iWordsLoaded / iTotalWords) * 100;
                return (int)iPercent;
            }
            return 0;
        }
    }
}
