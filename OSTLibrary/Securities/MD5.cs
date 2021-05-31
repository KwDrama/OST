using System;
using System.Text;

namespace OSTLibrary.Securities
{
    // 참조사이트-MSDN
    public static class MD5
    {
        static Random r = new Random(DateTime.Now.Millisecond);

        public static string Encrypt(string data)
        {
            var md5Hash = System.Security.Cryptography.MD5.Create();
            byte[] temp = md5Hash.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder hdata = new StringBuilder();

            for (int i = 0; i < temp.Length; i++)
                hdata.Append(temp[i].ToString("x2"));

            return hdata.ToString();
        }
        public static string NextRandom() => Encrypt(r.Next().ToString());
    }
}
