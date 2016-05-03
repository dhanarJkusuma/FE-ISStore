using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Sales.libs
{
    class INIBuilder
    {
        string path;

        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        public INIBuilder(string path)
        {
            this.path = path;
        }

        public string Read(string section, string key)
        {
            int chars = 256;
            StringBuilder buffer = new StringBuilder(chars);
            string sDefault = "";
            if (GetPrivateProfileString(section, key, sDefault,
              buffer, chars, path) != 0)
            {
                return buffer.ToString();
            }
            else
            {
                return null;
            }
        }

        public static int GetLastError()
        {
            return Marshal.GetLastWin32Error();
        }


        public bool Write(string section, string key, string value)
        {
            return WritePrivateProfileString(section, key, value, path);
        }
    }
}
