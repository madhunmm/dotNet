using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Shared_Expenses_Agent
{
    class Settings
    {
        private RegistryKey rk;
        private static String AgentMoniker = "Agent";
        private static String CacheMoniker = "Cache";
        private static String IntervalMoniker = "Interval";
        private static String LocationMoniker = "Location";
        private static String PasswordMoniker = "Password";
        private static String ServerCacheMoniker = "ServerCache";
        private static String ServerHostNameMoniker = "ServerHost";
        private static String strRegPath = "Software\\Shared Expenses";

        private static Settings m_settings;
        
        private Settings()
        {
            
        }

        public static Settings Instance()
        {
            if (m_settings == null)
            {
                m_settings = new Settings();
            }
            return m_settings;
        }

        private RegistryKey GetRegistryForRead()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(strRegPath);
            if (rk == null)
            {
                Registry.CurrentUser.CreateSubKey(strRegPath).Close();
                rk = Registry.CurrentUser.OpenSubKey(strRegPath);
            }
            return rk;
        }

        private RegistryKey GetRegistryForWrite()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(strRegPath, true);
            if (rk == null)
            {
                Registry.CurrentUser.CreateSubKey(strRegPath).Close();
                rk = Registry.CurrentUser.OpenSubKey(strRegPath, true);
            }
            return rk;
        }

        public String CacheDir
        {
            get
            {
                rk = GetRegistryForRead();
                if (rk != null)
                {
                    return (rk.GetValue(CacheMoniker) == null) ? "" : rk.GetValue(CacheMoniker).ToString();
                }
                return "";
            }
            set
            {
                rk = GetRegistryForWrite();
                if (rk != null)
                {
                    rk.SetValue(CacheMoniker, value, RegistryValueKind.String);
                }
                rk.Close();
            }
        }

        public String Location
        {
            get
            {
                rk = GetRegistryForRead();
                if (rk != null)
                {
                    return (rk.GetValue(LocationMoniker) == null) ? "" : rk.GetValue(LocationMoniker).ToString();
                }
                return "";
            }
            set
            {
                rk = GetRegistryForWrite();
                if (rk != null)
                {
                    rk.SetValue(LocationMoniker, value, RegistryValueKind.String);
                }
                rk.Close();
            }
        }

        public String ServerHostName
        {
            get
            {
                rk = GetRegistryForRead();
                if (rk != null)
                {
                    return (rk.GetValue(ServerHostNameMoniker) == null) ? "" : rk.GetValue(ServerHostNameMoniker).ToString();
                }
                return "";
            }
            set
            {
                rk = GetRegistryForWrite();
                if (rk != null)
                {
                    rk.SetValue(ServerHostNameMoniker, value, RegistryValueKind.String);
                }
                rk.Close();
            }
        }

        public String ServerCacheDir
        {
            get
            {
                rk = GetRegistryForRead();
                if (rk != null)
                {
                    return (rk.GetValue(ServerCacheMoniker) == null) ? "" : rk.GetValue(ServerCacheMoniker).ToString();
                }
                return "";
            }
            set
            {
                rk = GetRegistryForWrite();
                if (rk != null)
                {
                    rk.SetValue(ServerCacheMoniker, value, RegistryValueKind.String);
                }
                rk.Close();
            }
        }

        public String Password
        {
            get
            {
                rk = GetRegistryForRead();
                if (rk != null)
                {
                    return (rk.GetValue(PasswordMoniker) == null) ? "" : rk.GetValue(PasswordMoniker).ToString();
                }
                return "";
            }
            set
            {
                rk = GetRegistryForWrite();
                if (rk != null)
                {
                    rk.SetValue(PasswordMoniker, value, RegistryValueKind.String);
                }
                rk.Close();
            }
        }

        public int Interval
        {
            get
            {
                rk = GetRegistryForRead();
                if (rk != null)
                {
                    return (rk.GetValue(IntervalMoniker) == null) ? -1 : Int32.Parse(rk.GetValue(IntervalMoniker).ToString());
                }
                return -1;
            }
            set
            {
                rk = GetRegistryForWrite();
                if (rk != null)
                {
                    rk.SetValue(IntervalMoniker, value, RegistryValueKind.DWord);
                }
                rk.Close();
            }
        }

        public Boolean Agent
        {
            get
            {
                rk = GetRegistryForRead();
                if (rk != null)
                {
                    if(rk.GetValue(AgentMoniker) == null)
                    {
                        return false;
                    }
                    if ((int)rk.GetValue(AgentMoniker) == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            set
            {
                rk = GetRegistryForWrite();
                if (rk != null)
                {
                    rk.SetValue(AgentMoniker, value, RegistryValueKind.DWord);
                }
                rk.Close();
            }
        }
    }
}
