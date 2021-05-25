using System;
using System.Text;
using System.Security.Cryptography;

namespace OSTLibrary.Securities
{
    public static class _MD5
    {
        public static string Encrypt(string data)
        {
            var md5Hash = MD5.Create();
            byte[] temp = md5Hash.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder hdata = new StringBuilder();

            for (int i = 0; i < temp.Length; i++)
                hdata.Append(temp[i].ToString("x2"));

            return hdata.ToString();
        }
    }
}
