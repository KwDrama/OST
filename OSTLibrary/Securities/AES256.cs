using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace OSTLibrary.Securities
{
    // 참조사이트-https://h5bak.tistory.com/148 
    public static class AES256
    {
        public static byte[] Encrypt(byte[] data, string key)
        {
            SHA256Managed sha256Managed = new SHA256Managed();
            RijndaelManaged aes = new RijndaelManaged();

            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            // salt = 비밀번호의 길이를 sha256 해쉬값
            var salt = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(key.Length.ToString()));

            // PBKDF2(Key - Based Key Derivation Function)
            // 65525번 반복
            var PBKDF2Key = new Rfc2898DeriveBytes(key, salt, 65535, HashAlgorithmName.SHA256);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            byte[] xBuff = null;
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(secretKey, iv), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                }
                xBuff = ms.ToArray();
            }
            return xBuff;
        }
        public static string Encrypt(string data, string key)
            => Encoding.Default.GetString(Encrypt(Encoding.Default.GetBytes(data), key));

        public static byte[] Decrypt(byte[] data, string key)
        {
            SHA256Managed sha256Managed = new SHA256Managed();
            RijndaelManaged aes = new RijndaelManaged();

            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            // salt = 비밀번호의 길이를 sha256 해쉬값
            var salt = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(key.Length.ToString()));

            // PBKDF2(Key - Based Key Derivation Function)
            // 65525번 반복
            var PBKDF2Key = new Rfc2898DeriveBytes(key, salt, 65535, HashAlgorithmName.SHA256);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            byte[] xBuff = null;
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(secretKey, iv), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                }
                xBuff = ms.ToArray();
            }
            return xBuff;
        }
        public static string Decrypt(string data, string key)
            => Encoding.Default.GetString(Decrypt(Encoding.Default.GetBytes(data), key));
    }
}
