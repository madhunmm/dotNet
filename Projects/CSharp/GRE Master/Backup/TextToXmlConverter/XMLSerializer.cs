using System;
using System.Xml;
using System.Collections;
using System.IO;
using System.Threading;

namespace GRE_Master
{
    class XMLSerializer : Serializer
    {
        private const String strWordListMoniker = "WORDLIST";
        private const String strWordEntryMoniker = "WORDENTRY";
        private const String strWordMoniker = "WORD";
        private const String strMeaningMoniker = "MEANING";
        private const String strUsageMoniker = "USAGE";
        private const String strOtherInfoMoniker = "OTHERINFO";

        private double iTotalWords,
                        iWordsLoaded;

        // Constructors
        public XMLSerializer()
        {
        }

        public XMLSerializer(String strFileName)
            : base(strFileName)
        {
            iTotalWords = 0;
            iWordsLoaded = 0;
        }

        // abstract method implementation
        protected override void load(WordList wl)
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
                        we.setWord(xnSubElements.InnerText);
                    }
                    else if (xnSubElements.Name == strMeaningMoniker)
                    {
                        we.addMeaning(xnSubElements.InnerText);
                    }
                    else if (xnSubElements.Name == strUsageMoniker)
                    {
                        we.addUsage(xnSubElements.InnerText);
                    }
                    else if (xnSubElements.Name == strOtherInfoMoniker)
                    {
                        we.addOtherInfo(xnSubElements.InnerText);
                    }
                }
                wl.addEntry(we);
                iWordsLoaded++;
            }
        }

        protected override void save(WordList wl)
        {
            XmlTextWriter xtw = new XmlTextWriter(strFilename, null);
            xtw.WriteStartDocument();
            xtw.WriteStartElement(strWordListMoniker);
            foreach (WordEntry we in wl)
            {
                xtw.WriteStartElement(strWordEntryMoniker);

                xtw.WriteStartElement(strWordMoniker);
                xtw.WriteString(we.getWord());
                xtw.WriteEndElement();

                foreach (String strMeaning in we.getMeanings())
                {
                    xtw.WriteStartElement(strMeaningMoniker);
                    xtw.WriteString(strMeaning);
                    xtw.WriteEndElement();
                }

                foreach (String strUsage in we.getUsages())
                {
                    xtw.WriteStartElement(strUsageMoniker);
                    xtw.WriteString(strUsage);
                    xtw.WriteEndElement();
                }

                foreach (String strOtherInfo in we.getOtherInfo())
                {
                    xtw.WriteStartElement(strOtherInfoMoniker);
                    xtw.WriteString(strOtherInfo);
                    xtw.WriteEndElement();
                }

                xtw.WriteEndElement();
            }

            xtw.WriteEndElement();

            xtw.WriteEndDocument();

            xtw.Close();
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
