using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace KriptografiFinalProjesi.Controllers
{
    public class RSAController : Controller
    {

        [HttpGet]
        public IActionResult EncryptPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EncryptPage(string plainText, string publicKey)
        {
            if (string.IsNullOrWhiteSpace(plainText) || string.IsNullOrWhiteSpace(publicKey))
            {
                ViewBag.Error = "Metin ve Public Key boş olamaz.";
                return View();
            }

            try
            {
                byte[] publicKeyBytes = Convert.FromBase64String(publicKey);
                using (var rsa = System.Security.Cryptography.RSA.Create())
                {
                    rsa.ImportRSAPublicKey(publicKeyBytes, out _);

                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                    byte[] encryptedBytes = rsa.Encrypt(plainBytes, RSAEncryptionPadding.Pkcs1);
                    string encryptedText = Convert.ToBase64String(encryptedBytes);

                    ViewBag.EncryptedText = encryptedText;
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Şifreleme sırasında hata oluştu: " + ex.Message;
            }

            return View();
        }

        [HttpGet]
        public IActionResult DecryptPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DecryptPage(string encryptedText, string privateKey)
        {
            if (string.IsNullOrWhiteSpace(encryptedText) || string.IsNullOrWhiteSpace(privateKey))
            {
                ViewBag.Error = "Şifreli metin ve Private Key boş olamaz.";
                return View();
            }

            try
            {
                byte[] privateKeyBytes = Convert.FromBase64String(privateKey);
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

                using (var rsa = System.Security.Cryptography.RSA.Create())
                {
                    rsa.ImportRSAPrivateKey(privateKeyBytes, out _);

                    byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.Pkcs1);
                    string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                    ViewBag.DecryptedText = decryptedText;
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Çözme sırasında hata oluştu: " + ex.Message;
            }

            return View();
        }
    }
}
