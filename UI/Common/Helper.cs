using System.Security.Cryptography;
using System.Text;

namespace PredictorUI.Common
{
    public static class Helper
    {
        public static string Encrypt(this string text)
        {
            return CalculateSHA256(text);
        }

        public static string Decrypt(this string text)
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(
                     Convert.FromBase64String(text), null, DataProtectionScope.LocalMachine));
        }

        public static string CalculateSHA256(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
