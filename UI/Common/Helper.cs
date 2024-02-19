using System.Security.Cryptography;
using System.Text;

namespace PredictorUI.Common
{
    public static class Helper
    {
        public static string Encrypt(this string text)
        {
            return Convert.ToBase64String(
                ProtectedData.Protect(Encoding.Unicode.GetBytes(text), null, scope: DataProtectionScope.LocalMachine));
        }

        public static string Decrypt(this string text)
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(
                     Convert.FromBase64String(text), null, DataProtectionScope.LocalMachine));
        }
    }
}
