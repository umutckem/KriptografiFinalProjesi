using System.ComponentModel.DataAnnotations;

public class AesEncryptModel
{
    [Required(ErrorMessage = "Giriş tipi seçilmelidir.")]
    public string InputType { get; set; } // text, file, url

    public string InputData { get; set; } // For text or URL input

    public IFormFile InputFile { get; set; } // For file input

    [Required(ErrorMessage = "Giriş kodlaması seçilmelidir.")]
    public string InputEncoding { get; set; } // UTF8, ASCII, Unicode

    [Required(ErrorMessage = "Çıkış kodlaması seçilmelidir.")]
    public string OutputEncoding { get; set; } // Base64, Hex

    [Required(ErrorMessage = "Anahtar boyutu seçilmelidir.")]
    [Range(128, 256, ErrorMessage = "Anahtar boyutu 128, 192 veya 256 bit olmalıdır.")]
    public int KeySize { get; set; } // 128, 192, 256

    [Required(ErrorMessage = "Şifreleme modu seçilmelidir.")]
    public string Mode { get; set; } // CBC, ECB, CFB, OFB

    [Required(ErrorMessage = "Padding seçilmelidir.")]
    public string Padding { get; set; } // PKCS7, Zeros, None

    [Required(ErrorMessage = "Anahtar tipi seçilmelidir.")]
    public string KeyType { get; set; } // Raw, Passphrase

    [Required(ErrorMessage = "Anahtar veya passphrase girilmelidir.")]
    public string KeyInput { get; set; }

    public string HashAlgorithm { get; set; } // SHA256, SHA1, MD5 (required only for Passphrase)
}