using System.Security.Cryptography;
using System.Text;

public static class RsaEncryptor
{
    public static string Encrypt(string plainText, string base64PublicKey)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.ImportRSAPublicKey(Convert.FromBase64String(base64PublicKey), out _);
            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encrypted = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
            return Convert.ToBase64String(encrypted);
        }
    }
}
