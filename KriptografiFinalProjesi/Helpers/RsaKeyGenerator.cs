using System.Security.Cryptography;
using System.Text;

public static class RsaKeyGenerator
{
    public static (string publicKey, string privateKey) GenerateKeys()
    {
        using (RSA rsa = RSA.Create(2048))
        {
            string publicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());
            string privateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());
            return (publicKey, privateKey);
        }
    }
}
