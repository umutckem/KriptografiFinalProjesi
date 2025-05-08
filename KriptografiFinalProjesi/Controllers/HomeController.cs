using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using KriptografiFinalProjesi.Helpers;
using KriptografiFinalProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KriptografiFinalProjesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GenerateKeys()
        {
            using (var rsa = System.Security.Cryptography.RSA.Create(2048))
            {
                var publicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());
                var privateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());

                ViewBag.PublicKey = publicKey;
                ViewBag.PrivateKey = privateKey;

                return View();
            }
        }

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
                ViewBag.Error = "Metin ve Public Key boþ olamaz.";
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
                ViewBag.Error = "Þifreleme sýrasýnda hata oluþtu: " + ex.Message;
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
                ViewBag.Error = "Þifreli metin ve Private Key boþ olamaz.";
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
                ViewBag.Error = "Çözme sýrasýnda hata oluþtu: " + ex.Message;
            }

            return View();
        }

        // SHA256 Hash
        public IActionResult Sha256Hash()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sha256Hash(string inputText)
        {
            if (!string.IsNullOrEmpty(inputText))
            {
                // HashHelper sýnýfý üzerinden SHA256 hash deðerini alýyoruz
                string hashValue = HashHelper.GetSha256Hash(inputText);
                ViewBag.HashResult = hashValue;
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
