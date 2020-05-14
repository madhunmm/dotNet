using System;

namespace Video_Library
{
    class DisplayData
    {
        private String strMovieName;
        private String strDirector;
        private String strGenre;
        private String strLanguage;
        private String strStarCast;
        private Boolean bHasSubtitles;

        public String MovieName
        {
            get
            {
                return strMovieName;
            }
            set
            {
                strMovieName = value;
            }
        }

        public String StarCast
        {
            get
            {
                return strStarCast;
            }
            set
            {
                strStarCast = value;
            }
        }

        public String Director
        {
            get
            {
                return strDirector;
            }
            set
            {
                strDirector = value;
            }
        }

        public String Language
        {
            get
            {
                return strLanguage;
            }
            set
            {
                strLanguage = value;
            }
        }

        public String Genre
        {
            get
            {
                return strGenre;
            }
            set
            {
                strGenre = value;
            }
        }

        public Boolean HasSubtitles
        {
            get
            {
                return bHasSubtitles;
            }
            set
            {
                bHasSubtitles = value;
            }
        }
    }
}
