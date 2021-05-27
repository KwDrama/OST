using System.Text;

namespace OSTLibrary.Securities
{
    // 참조사이트-MSDN
    public static class MD5
    {
        public static string Encrypt(string data)
        {
            byte[] md5Bytes = System.Security.Cryptography.MD5.Create()
                .ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder hdata = new StringBuilder();

            for (int i = 0; i < md5Bytes.Length; i++)
                hdata.Append(md5Bytes[i].ToString("x2"));

            return hdata.ToString();
        }
    }
}
