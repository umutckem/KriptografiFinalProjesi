using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace KriptografiFinalProjesi.Controllers
{
    public class AESController : Controller
    {
        public IActionResult AesEncrypt() => View();

        [HttpPost]
        public async Task<IActionResult> AesEncrypt(string inputType, string passphrase, string textInput, string urlInput, IFormFile fileInput, string operation)
        {
            string result = "";
            try
            {
                
                string inputData = inputType switch
                {
                    "text" => textInput,
                    "url" => await new HttpClient().GetStringAsync(urlInput),
                    "file" => await ReadFileAsync(fileInput),
                    _ => throw new Exception("Geçersiz girdi tipi")
                };

                
                byte[] salt;
                if (operation == "encrypt")
                {
                    salt = RandomNumberGenerator.GetBytes(16); 
                }
                else
                {
                    byte[] allData = Convert.FromBase64String(inputData);
                    salt = allData.Take(16).ToArray();
                    inputData = Encoding.UTF8.GetString(allData.Skip(16).ToArray());
                }

                
                using var keyGen = new Rfc2898DeriveBytes(passphrase, salt, 10000, HashAlgorithmName.SHA256);
                byte[] key = keyGen.GetBytes(32); 
                byte[] iv = keyGen.GetBytes(16);  

                using var aes = Aes.Create();
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                if (operation == "encrypt")
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(inputData);
                    using var encryptor = aes.CreateEncryptor();
                    byte[] encrypted = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                    byte[] output = salt.Concat(encrypted).ToArray();
                    result = Convert.ToBase64String(output);
                }
                else 
                {
                    byte[] allBytes = Convert.FromBase64String(textInput);
                    byte[] encryptedData = allBytes.Skip(16).ToArray(); // 16 byte salt başta
                    using var decryptor = aes.CreateDecryptor();
                    byte[] decrypted = decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                    result = Encoding.UTF8.GetString(decrypted);
                }

                ViewBag.Result = result;
            }
            catch (Exception ex)
            {
                ViewBag.Result = "Hata: " + ex.Message;
            }

            return View();
        }

        private async Task<string> ReadFileAsync(IFormFile file)
        {
            using var reader = new StreamReader(file.OpenReadStream());
            return await reader.ReadToEndAsync();
        }
    }
}
