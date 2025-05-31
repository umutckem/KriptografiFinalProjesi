using System.ComponentModel.DataAnnotations;

public class AesEncryptModel
{
    [Required(ErrorMessage = "Giriş tipi seçilmelidir.")]
    public string InputType { get; set; } 

    public string InputData { get; set; } 

    public IFormFile InputFile { get; set; } 

    [Required(ErrorMessage = "Giriş kodlaması seçilmelidir.")]
    public string InputEncoding { get; set; } 

    [Required(ErrorMessage = "Çıkış kodlaması seçilmelidir.")]
    public string OutputEncoding { get; set; } 

    [Required(ErrorMessage = "Anahtar boyutu seçilmelidir.")]
    [Range(128, 256, ErrorMessage = "Anahtar boyutu 128, 192 veya 256 bit olmalıdır.")]
    public int KeySize { get; set; } 

    [Required(ErrorMessage = "Şifreleme modu seçilmelidir.")]
    public string Mode { get; set; } 

    [Required(ErrorMessage = "Padding seçilmelidir.")]
    public string Padding { get; set; } 

    [Required(ErrorMessage = "Anahtar tipi seçilmelidir.")]
    public string KeyType { get; set; } 

    [Required(ErrorMessage = "Anahtar veya passphrase girilmelidir.")]
    public string KeyInput { get; set; }

    public string HashAlgorithm { get; set; } 
}