using System;
using System.Text;

namespace OSTLibrary.Securities
{
    public static class AES256
    {
        public static byte[] Encrypt(byte[] data, string key)
        {
            throw new NotImplementedException();
        }
        public static string Encrypt(string data, string key)
            => Encoding.Default.GetString(Encrypt(Encoding.Default.GetBytes(data), key));

        public static byte[] Decrypt(byte[] data, string key)
        {
            throw new NotImplementedException();
        }
        public static string Decrypt(string data, string key)
            => Encoding.Default.GetString(Decrypt(Encoding.Default.GetBytes(data), key));
    }
}
