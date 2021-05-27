using System.Text;

namespace OSTLibrary.Securities
{
    // 참조사이트-https://sosopro.tistory.com/33
    public static class SHA256
    {
        public static string Encrypt(string data)
        {
            byte[] array = Encoding.UTF8.GetBytes(data);
            byte[] hashValue;
            string result = string.Empty;

            using (System.Security.Cryptography.SHA256 mySHA256 =
                System.Security.Cryptography.SHA256.Create())
            {
                hashValue = mySHA256.ComputeHash(array);
            }

            for (int i = 0; i < hashValue.Length; i++)
                result += hashValue[i].ToString("x2");
            
            return result;
        }
    }
}
