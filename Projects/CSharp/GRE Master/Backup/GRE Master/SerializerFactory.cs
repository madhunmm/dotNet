using System;
using System.IO;

namespace GRE_Master
{
    class SerializerFactory
    {
        private const String strXMLMoniker = ".xml";
        private const String strTextMoniker = ".txt";
        public Serializer GetSerializer(String strFilename)
        {
            // Check extension
            if (Path.GetExtension(strFilename) == strXMLMoniker)
            {
                return new XMLSerializer(strFilename);
            }
            else if (Path.GetExtension(strFilename) == strTextMoniker)
            {
                return new TextSerializer(strFilename);
            }
            return new TextSerializer(strFilename);
        }
    }
}
