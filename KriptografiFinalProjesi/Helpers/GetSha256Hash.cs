using System.Security.Cryptography;
using System.Text;

namespace KriptografiFinalProjesi.Helpers
{
    public static class HashHelper
    {
        // SHA256 Hash hesaplama metodunu statik hale getirdim
        public static string GetSha256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
