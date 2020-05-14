using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Video_Library
{
    class Common
    {
        public static void PlayMovie(String strMoviePath, String strPlayer)
        {
            ProcessStartInfo psi = null;
            if (strPlayer.Length == 0)
            {
                //psi = new ProcessStartInfo(GetMediaPlayerPath(), "\"" + strMoviePath.Trim() + "\"");
                psi = new ProcessStartInfo(GetMediaPlayerPath(), strMoviePath);
            }
            else
            {
                //psi = new ProcessStartInfo(strPlayer, "\"" + strMoviePath + "\"");
                psi = new ProcessStartInfo(strPlayer, strMoviePath);
            }
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
