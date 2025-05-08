using System.Security.Cryptography;
using System.Text;

public static class RsaHelper
{
    private static RSA _rsa;

    static RsaHelper()
    {
        _rsa = RSA.Create(2048);
    }

    public static string GetPublicKey()
    {
        return Convert.ToBase64String(_rsa.ExportRSAPublicKey());
    }

    public static string Encrypt(string plainText)
    {
        byte[] data = Encoding.UTF8.GetBytes(plainText);
        byte[] encryptedData = _rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
        return Convert.ToBase64String(encryptedData);
    }

    public static string Decrypt(string encryptedText)
    {
        byte[] data = Convert.FromBase64String(encryptedText);
        byte[] decryptedData = _rsa.Decrypt(data, RSAEncryptionPadding.Pkcs1);
        return Encoding.UTF8.GetString(decryptedData);
    }
}
