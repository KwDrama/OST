using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace OSTLibrary.Securities
{
    class AESEncrypt
    {
        private SHA256Managed sha256Managed = new SHA256Managed();
        private RijndaelManaged aes = new RijndaelManaged();

        public AESEncrypt()
        {
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
        }


        //AES_256 암호화
        public byte[] AESEncrypt256(byte[] encryptData, String password)
        {
            // Salt는 비밀번호의 길이를 SHA256 해쉬값으로 한다.
            var salt = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(password.Length.ToString()));
            Console.WriteLine("Salt(Base64) : " + Convert.ToBase64String(salt));


            //PBKDF2(Password-Based Key Derivation Function)
            //반복은 65535번
            var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535, HashAlgorithmName.SHA256);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            Console.WriteLine("SecretKey(Base64) : " + Convert.ToBase64String(secretKey));
            Console.WriteLine("IV(Base64) : " + Convert.ToBase64String(iv));

            byte[] xBuff = null;
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(secretKey, iv), CryptoStreamMode.Write))
                {
                    cs.Write(encryptData, 0, encryptData.Length);
                }
                xBuff = ms.ToArray();
            }
            return xBuff;
        }

        //AES_256 복호화
        public byte[] AESDecrypt256(byte[] decryptData, String password)
        {
            // Salt는 비밀번호의 길이를 SHA256 해쉬값으로 한다.
            var salt = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(password.Length.ToString()));

            //PBKDF2(Password-Based Key Derivation Function)
            //반복은 65535번
            var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535, HashAlgorithmName.SHA256);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            byte[] xBuff = null;
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(secretKey, iv), CryptoStreamMode.Write))
                {
                    cs.Write(decryptData, 0, decryptData.Length);
                }
                xBuff = ms.ToArray();
            }
            return xBuff;
        }
    }
    // 참조사이트-https://h5bak.tistory.com/148 
    public static class AES256
    {
        public static byte[] Encrypt(byte[] data, string key)
        {
            AESEncrypt aes = new AESEncrypt();
            return aes.AESEncrypt256(data, key);
        }
        public static string Encrypt(string data, string key)
            => Encoding.Default.GetString(Encrypt(Encoding.Default.GetBytes(data), key));

        public static byte[] Decrypt(byte[] data, string key)
        {
            AESEncrypt aes = new AESEncrypt();
            return aes.AESDecrypt256(data, key);
        }
        public static string Decrypt(string data, string key)
            => Encoding.Default.GetString(Decrypt(Encoding.Default.GetBytes(data), key));
    }
}