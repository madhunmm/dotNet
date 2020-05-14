using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Video_Library
{
    class Common
    {
        public static void PlayMovie(String strMoviePath)
        {
            ProcessStartInfo psi = new ProcessStartInfo(GetMediaPlayerPath(), "\"" + strMoviePath + "\"");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }

        public static String GetMediaPlayerPath()
        {
            return "C:\\Program Files\\Ringz Studio\\Storm Codec\\mplayerc.exe";
        }
    }
}
