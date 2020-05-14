using System;
using System.IO;

namespace LogParser
{
    abstract class Handler
    {
        public abstract void Handle(String str,StreamReader fileReader);
    }
}
