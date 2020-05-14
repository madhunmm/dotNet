using System;
using System.Xml;
using System.Xml.XPath;
using System.Collections;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xd = new XmlDocument();
            XmlTextWriter xtw = new XmlTextWriter("D:\\test.xml",null);
            xtw.WriteStartDocument();
            xtw.WriteStartElement("WORDLIST");
            xtw.WriteStartElement("WORDENTRY");
            xtw.WriteStartElement("WORD");
            xtw.WriteString("Madhu");
            xtw.WriteEndElement();

            xtw.WriteStartElement("MEANING");
            xtw.WriteString("good boy");
            xtw.WriteEndElement();
            
            xtw.WriteStartElement("USAGE");
            xtw.WriteString("Madhu is a good boy");
            xtw.WriteEndElement();

            xtw.WriteStartElement("OTHERINFO");
            xtw.WriteString("Noun");
            xtw.WriteEndElement();

            xtw.WriteEndElement();
            xtw.WriteEndElement();

            xtw.WriteEndDocument();

            xtw.Close();

            XmlTextReader xtr = new XmlTextReader("D:\\test.xml");
            xtr.Read();
            xd.Load(xtr);
            XmlNodeList xnl = xd.GetElementsByTagName("WORDENTRY");
            foreach (XmlNode xn in xnl)
            {
                IEnumerator it = xn.GetEnumerator();
                while (it.MoveNext())
                {
                    XmlNode xn1 = (XmlNode)it.Current;
                    Console.WriteLine(xn1.InnerText);
                }
            }
        }
    }
}
