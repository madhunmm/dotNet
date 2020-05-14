using System;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;

namespace Video_Library
{
    class VideoDatabase
    {
        private OleDbConnection conn;
        private OleDbCommand cmd;

        private static VideoDatabase m_Videodatabase;

        private static String MovieNameMoniker = "moviename";
        private static String LanguageMoniker = "lang";
        private static String StarCastMoniker = "starcast";
        private static String DirectorMoniker = "director";
        private static String GenreMoniker = "genre";
        private static String SubtitleMoniker = "subtitles";
        private static String LocationMoniker = "location";
        private static String SearchPathMoniker = "path";
        private static String ExtensionMoniker = "extension";
        private static String MediaTypeMoniker = "mediatype";
        private static String YearMoniker = "year";
        private static String KeywordsMoniker = "keywords";
        private static String PlayerNameMoniker = "playername";
        private static String PlayerLocationMoniker = "location";
        private static String VideoTableMoniker = "videos";
        private static String PathTableMoniker = "searchpaths";
        private static String FileTypesTableMoniker = "filetypes";
        private static String MediaPlayersTableMoniker = "mediaplayers";

        private String strMovieName;

        private VideoDatabase()
        {
            try
            {
                String strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\Library.mdb;Persist Security Info=False";
                conn = new OleDbConnection(strConnectionString);
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open the database", "Video Library");
            }
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            strMovieName = "";
        }

        public static VideoDatabase Instance()
        {
            if (m_Videodatabase == null)
            {
                m_Videodatabase = new VideoDatabase();
            }
            return m_Videodatabase;
        }

        // Main functions
        public ArrayList GetMovieList(String strQuery)
        {
            ArrayList alResult = new ArrayList();
            if (strQuery.Length > 0)
            {
                cmd.CommandText = strQuery;
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DisplayData dd = new DisplayData();
                    dd.MovieName = (String)dr[MovieNameMoniker];
                    alResult.Add(dd);
                }
                dr.Close();
            }
            return alResult;
        }

        public void AddMovie(String strMovieName)
        {
            if (strMovieName.Length > 0)
            {
                // Check if movie is already in DB.
                String strSelectQuery = "Select " + MovieNameMoniker + " from " + VideoTableMoniker +
                                        " where " + MovieNameMoniker + " = '" + strMovieName + "'";

                if (ExecuteSelect(strSelectQuery, MovieNameMoniker) == null)
                {
                    String strInsertQuery = "Insert into " + VideoTableMoniker +
                                            " (" + MovieNameMoniker + ") values('" + strMovieName + "')";
                    
                    ExecuteUpdate(strInsertQuery);
               }
            }
        }

        public void AddSearchPath(String strPath)
        {
            if (strPath.Length > 0)
            {
                String strInsertQuery = "Insert into " + PathTableMoniker +
                                        " (" + SearchPathMoniker + ") values('" + strPath + "')";

                ExecuteUpdate(strInsertQuery);
            }
        }

        public ArrayList GetSearchPaths()
        {
            ArrayList alResult = new ArrayList();

            String strQuery = "Select * from " + PathTableMoniker;
            cmd.CommandText = strQuery;
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {                
                alResult.Add((String)dr[SearchPathMoniker]);
            }
            dr.Close();
            return alResult;
        }

        public void AddExtension(String strExtension)
        {
            if (strExtension.Length > 0)
            {
                String strInsertQuery = "Insert into " + FileTypesTableMoniker +
                                        " (" + ExtensionMoniker + ") values('" + strExtension + "')";

                ExecuteUpdate(strInsertQuery);
            }
        }

        public ArrayList GetExtensions()
        {
            ArrayList alResult = new ArrayList();

            String strQuery = "Select * from " + FileTypesTableMoniker;
            cmd.CommandText = strQuery;
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                alResult.Add((String)dr[ExtensionMoniker]);
            }
            dr.Close();
            return alResult;
        }

        public ArrayList GetMediaPlayers()
        {
            ArrayList alResult = new ArrayList();

            String strQuery = "Select * from " + MediaPlayersTableMoniker;
            cmd.CommandText = strQuery;
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                alResult.Add((String)dr[PlayerNameMoniker]);
            }
            dr.Close();
            return alResult;
        }

        // Private helpers
        private void ExecuteUpdate(String strQuery)
        {
            cmd.CommandText = strQuery;
            cmd.ExecuteNonQuery();
        }

        private Object ExecuteSelect(String strQuery, String strCriteria)
        {
            if (strQuery.Length > 0)
            {
                cmd.CommandText = strQuery;
                OleDbDataReader dr = cmd.ExecuteReader();

                Object objReturn = null;
                if (dr.Read())
                {
                    objReturn = dr[strCriteria];
                }
                dr.Close();
                cmd.CommandText = "";
                return objReturn;
            }
            return null;
        }
        
        // Database fields
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
                String strQuery = "Select " + StarCastMoniker + " from " + VideoTableMoniker +
                                  " where " + MovieNameMoniker + " = '" + MovieName + "'";

                return (String)ExecuteSelect(strQuery, StarCastMoniker);
            }
            set
            {
                String strQuery = "Update videos set " +
                                    StarCastMoniker + " = '" + value + "' " +
                                    "where " + MovieNameMoniker + " = '" + MovieName + "'";

                ExecuteUpdate(strQuery);
            }
        }

        public String Director
        {
            get
            {
                String strQuery =   "Select " + DirectorMoniker + " from " + VideoTableMoniker +
                                    " where " + MovieNameMoniker + " = '" + MovieName + "'";

                return (String)ExecuteSelect(strQuery, DirectorMoniker);
            }
            set
            {
                String strQuery =   "Update videos set " +
                                    DirectorMoniker + " = '" + value + "' " +
                                    "where " + MovieNameMoniker + " = '" + MovieName + "'";

                ExecuteUpdate(strQuery);
            }
        }

        public String Language
        {
            get
            {
                String strQuery =   "Select " + LanguageMoniker + " from " + VideoTableMoniker +
                                    " where " + MovieNameMoniker + " = '" + MovieName + "'";

                return (String)ExecuteSelect(strQuery, LanguageMoniker);
            }
            set
            {
                String strQuery =   "Update videos set " +
                                    LanguageMoniker + " = '" + value + "' " +
                                    "where " + MovieNameMoniker + " = '" + MovieName + "'";

                ExecuteUpdate(strQuery);
            }
        }

        public String Genre
        {
            get
            {
                String strQuery =   "Select " + GenreMoniker + " from " + VideoTableMoniker +
                                    " where " + MovieNameMoniker + " = '" + MovieName + "'";

                return (String)ExecuteSelect(strQuery, GenreMoniker);
            }
            set
            {
                String strQuery =   "Update videos set " +
                                    GenreMoniker + " = '" + value + "' " +
                                    "where " + MovieNameMoniker + " = '" + MovieName + "'";

                ExecuteUpdate(strQuery);
            }
        }

        public String Location
        {
            get
            {
                String strQuery = "Select " + LocationMoniker + " from " + VideoTableMoniker +
                                    " where " + MovieNameMoniker + " = '" + MovieName + "'";

                return (String)ExecuteSelect(strQuery, LocationMoniker);
            }
            set
            {
                String strQuery = "Update videos set " +
                                    LocationMoniker + " = '" + value + "' " +
                                    "where " + MovieNameMoniker + " = '" + MovieName + "'";

                ExecuteUpdate(strQuery);
            }
        }

        public String MediaType
        {
            get
            {
                String strQuery = "Select " + MediaTypeMoniker + " from " + VideoTableMoniker +
                                    " where " + MovieNameMoniker + " = '" + MovieName + "'";

                return (String)ExecuteSelect(strQuery, MediaTypeMoniker);
            }
            set
            {
                String strQuery = "Update videos set " +
                                    MediaTypeMoniker + " = '" + value + "' " +
                                    "where " + MovieNameMoniker + " = '" + MovieName + "'";

                ExecuteUpdate(strQuery);
            }
        }

        public String Keywords
        {
            get
            {
                String strQuery = "Select " + KeywordsMoniker + " from " + VideoTableMoniker +
                                    " where " + MovieNameMoniker + " = '" + MovieName + "'";

                return (String)ExecuteSelect(strQuery, KeywordsMoniker);
            }
            set
            {
                String strQuery = "Update videos set " +
                                    KeywordsMoniker + " = '" + value + "' " +
                                    "where " + MovieNameMoniker + " = '" + MovieName + "'";

                ExecuteUpdate(strQuery);
            }
        }

        public String Year
        {
            get
            {
                String strQuery = "Select " + YearMoniker + " from " + VideoTableMoniker +
                                    " where " + MovieNameMoniker + " = '" + MovieName + "'";

                return (String)ExecuteSelect(strQuery, YearMoniker);
            }
            set
            {
                String strQuery = "Update videos set " +
                                    YearMoniker + " = '" + value + "' " +
                                    "where " + MovieNameMoniker + " = '" + MovieName + "'";

                ExecuteUpdate(strQuery);
            }
        }

        public Boolean HasSubtitle
        {
            get
            {
                String strQuery =   "Select " + SubtitleMoniker + " from " + VideoTableMoniker + 
                                    " where " + MovieNameMoniker + " = '" + MovieName + "'";

                return (Boolean)ExecuteSelect(strQuery, SubtitleMoniker);
            }
            set
            {
                String strYesNo = "No";
                if (value)
                    strYesNo = "Yes";

                String strQuery =   "Update videos set " +
                                    SubtitleMoniker + " = " + strYesNo + " " +
                                    "where " + MovieNameMoniker + " = '" + MovieName + "'";

                ExecuteUpdate(strQuery);
            }
        }
    }
}
