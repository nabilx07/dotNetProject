using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Penerangan.Emedia2u.Web.Managers;
using Penerangan.Emedia2u.Web.DTO;
using System.Security.Cryptography;
using System.Globalization;
using System.IO;

namespace Penerangan.Emedia2u.Web.Helper
{
    public static class Utility
    {
        public static string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext); // henter info fra windows registry
            if (regKey != null && regKey.GetValue("Content Type") != null)
            {
                mimeType = regKey.GetValue("Content Type").ToString();
            }
            else if (ext == ".txt")
            {
                mimeType = "text/plain";
            }

            else if (ext == ".doc") // a couple of extra info, due to missing information on the server
            {
                mimeType = "application/msword";
            }
            else if (ext == ".pdf")
            {
                mimeType = "application/pdf";
            }
            return mimeType;
        }
        public static string GetUserWithPaddingChar(int runNoLength, string runNoValue, string paddingChar)
        {
            return DoMath(runNoLength, runNoValue, paddingChar);
        }
        public static string GetRunNo(string runNoType)
        {
            //int runNoLength = 10;
            //string paddingChar = "ADU";
            //string runNoValue = "9000000200";

            RunNoDTO dto =RunNoManager.GetRunNo(runNoType);

            return DoMath(dto.RunNoLength, dto.RunNoValue, dto.PaddingChr);
           
        }
        public static void UpdateRunNo(string runNoType)
        {
            RunNoManager.UpdateRunNo(runNoType);
        }
        //public static string GetUserID()
        //{
        //    int runNoLength = 5;
        //    string paddingChar = "USR";
        //    string runNoValue = "9340";

        //    return DoMath(runNoLength, runNoValue, paddingChar);

        //}

        public static byte[] HashPassword(string txtPassword)
        {
            HashAlgorithm hashAl = HashAlgorithm.Create("MD5");
            byte[] myPasswordInBytes = Encoding.UTF8.GetBytes(txtPassword);

            byte[] myHashedPassword = hashAl.ComputeHash(myPasswordInBytes);

            return myHashedPassword;

        }

        

        private static string DoMath(int runNoLength, string runNoValue, string paddingChar)
        {
            StringBuilder runNo = new StringBuilder();

            int max = runNoLength - runNoValue.Length;

            for (int i = 0; i < max; i++)
            {
                runNo.Append("0");
            }

            StringBuilder str = new StringBuilder();

            str.Append(paddingChar).Append(runNo).Append(runNoValue);


            return str.ToString();
        }

        public static string GetMonth(int month)
        {
            string m = null;

            switch(month)
            {
                case 1:
                   m = "Januari";
                   break;
                case 2:
                   m = "Februari";
                   break;
                case 3:
                   m = "Mac";
                   break;
                case 4:
                   m = "April";
                   break;
                case 5:
                   m = "May";
                   break;
                case 6:
                   m = "Jun";
                   break;
                case 7:
                   m = "Julai";
                   break;
                case 8:
                   m = "Ogos";
                   break;
                case 9:
                   m = "September";
                   break;
                case 10:
                   m = "Oktober";
                   break;
                case 11:
                   m = "November";
                   break;
                case 12:
                   m = "Disember";
                   break;
                  
            }

            return m;

        }

        public static int GetMonth(string month)
        {
            int m = 0;

            switch (month)
            {
                case "Januari":
                    m = 1;
                    break;
                case "Februari":
                    m = 2;
                    break;
                case "Mac":
                    m = 3;
                    break;
                case "April":
                    m = 4;
                    break;
                case "May":
                    m = 5;
                    break;
                case "Jun":
                    m =6;
                    break;
                case "Julai":
                    m = 7;
                    break;
                case "Ogos":
                    m = 8;
                    break;
                case "September":
                    m = 9;
                    break;
                case "Oktober":
                    m = 10;
                    break;
                case "November":
                    m = 11;
                    break;
                case "Disember":
                    m = 12;
                    break;

            }

            return m;

        }

        public static DateTime GetDate(string date)
        {
            try
            {
                return DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception err)
            {
                              
                return new DateTime(1900,01,01);
            }
        }

        public static string ToDateString(string date)
        {
            if(string.IsNullOrEmpty(date))
            {
                return "";
            }
           
            return DateTime.Parse(date).ToString("dd-MM-yyyy");

        }

        /*public static List<string> GetUserRoles(string userName)
        {
           // char[] separator = { ',' };
            
            UserDTO user = UserManager.Load(userName);

            List<string> listOfRole = user.KodUserRole.Split(',').ToList();

            return listOfRole;
        }*/

        /*public static int GetUserID(string userName)
        {
            return UserManager.GetUserID(userName);
        }*/
    }
}
