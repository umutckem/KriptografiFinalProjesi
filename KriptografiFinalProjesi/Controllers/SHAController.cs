using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace KriptografiFinalProjesi.Controllers
{
    public class SHAController : Controller
    {

        
        public IActionResult Sha256Hash()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Sha256Hash(string inputText, IFormFile fileInput)
        {
            string hashValue = string.Empty;

            
            if (!string.IsNullOrEmpty(inputText))
            {
                hashValue = GetSha256Hash(inputText);
            }
            
            else if (fileInput != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    fileInput.CopyTo(memoryStream);
                    byte[] fileBytes = memoryStream.ToArray();
                    hashValue = GetSha256Hash(fileBytes);
                }
            }

            ViewBag.HashResult = hashValue;
            return View();
        }

        
        private string GetSha256Hash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        
        private string GetSha256Hash(byte[] inputBytes)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(inputBytes);
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

    }
}
