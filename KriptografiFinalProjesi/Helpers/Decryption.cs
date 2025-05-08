using System.Security.Cryptography;
using System.Text;

public static class RsaDecryptor
{
    public static string Decrypt(string base64EncryptedText, string base64PrivateKey)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.ImportRSAPrivateKey(Convert.FromBase64String(base64PrivateKey), out _);
            byte[] encryptedData = Convert.FromBase64String(base64EncryptedText);
            byte[] decrypted = rsa.Decrypt(encryptedData, RSAEncryptionPadding.Pkcs1);
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
