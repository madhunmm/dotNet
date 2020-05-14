using System;
using System.Collections;
using System.IO;

namespace Video_Library
{
    class VideoSnooper
    {
        private ArrayList alFileTypes;
        VideoDatabase vdb;

        public VideoSnooper()
        {
            vdb = new VideoDatabase();
            alFileTypes = vdb.GetExtensions();
        }

        public VideoSnooper(VideoDatabase v)
        {
            vdb = v;
            alFileTypes = vdb.GetExtensions();
        }
        public void Snoop()
        {
            ArrayList alSearchPaths = vdb.GetSearchPaths();
            foreach (String strPath in alSearchPaths)
            {
                SearchVideos(strPath);
            }
        }

        private void SearchVideos(String strPath)
        {
            String[] strSubDirectories = null;
            try
            {
                strSubDirectories = Directory.GetDirectories(strPath);
            }
            catch (Exception)
            {
                return;
            }
            if (strSubDirectories.Length > 0)
            {
                // Go inside
                foreach(String strSubDirectory in strSubDirectories)
                {
                    SearchVideos(strSubDirectory);
                }
            }

            String[] strFiles = null;
            try
            {
                strFiles = Directory.GetFiles(strPath);
            }
            catch (Exception)
            {
                // Do nothing
                return;
            }
            if (strFiles.Length > 0)
            {
                foreach (String strFile in strFiles)
                {
                    String strExtension = Path.GetExtension(strFile).ToLower();
                    if (strExtension.Length > 0)
                    {
                        strExtension = strExtension.Remove(0, 1);
                    }
                    if (alFileTypes.Contains(strExtension))
                    {
                        String strMovieName = Path.GetFileNameWithoutExtension(strFile);
                        vdb.AddMovie(strMovieName.ToUpper());
                        vdb.MovieName = strMovieName;
                        vdb.MediaType = strExtension;
                        vdb.Location = strFile;
                        vdb.HasSubtitle = false;

                        // Check if it has subtitles.
                        String strSubtitlePath = Path.ChangeExtension(strFile, "srt");
                        if (File.Exists(strSubtitlePath))
                        {
                            vdb.HasSubtitle = true;
                        }
                    }
                }
            }
        }
    }
}
