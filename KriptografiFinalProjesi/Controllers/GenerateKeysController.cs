using Microsoft.AspNetCore.Mvc;

namespace KriptografiFinalProjesi.Controllers
{
    public class GenerateKeysController : Controller
    {
        public IActionResult GenerateKeys()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult GenerateKeys(int bitLength)
        {
            if (bitLength != 1024 && bitLength != 2048 && bitLength != 4096)
            {
                ModelState.AddModelError("", "Geçersiz bit uzunluğu.");
                return View();
            }

            using (var rsa = System.Security.Cryptography.RSA.Create(bitLength))
            {
                var publicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());
                var privateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());

                ViewBag.PublicKey = publicKey;
                ViewBag.PrivateKey = privateKey;

                return View(); 
            }
        }
    }
}
