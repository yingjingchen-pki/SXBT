using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace SXPWDLib
{
    [ComVisible(true)]
    public class Authentication : ISXAuth
    {
        public string GeneratePwdByName(string username)
        {
            return GeneratePasswordByName(username);
        }

        public static string GeneratePasswordByName(string username)
        {
            string salt = "XQk";
            string retVal = GenerateMD5ByAddingSalt(username, salt);
            return retVal;
        }

        private static string GenerateMD5ByAddingSalt(string inputString, string salt)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                return "";
            }
            if (salt == null)
            {
                salt = "";
            }

            byte[] result = Encoding.Default.GetBytes(inputString + salt);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            string retVal = BitConverter.ToString(output).Replace("-", "");
            return retVal;
        }
    }
}
