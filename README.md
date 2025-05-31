KriptografiFinalProjesi, temel kriptografi algoritmalarını kullanıcı dostu bir web arayüzü üzerinden uygulamaya olanak tanıyan bir ASP.NET Core tabanlı projedir. Proje kapsamında aşağıdaki şifreleme ve hash algoritmaları desteklenmektedir:

AES (Advanced Encryption Standard):
Simetrik anahtar şifreleme yöntemiyle metin, dosya veya URL tabanlı verilerin güvenli bir şekilde şifrelenmesini ve çözülmesini sağlar. Kullanıcılar kendi anahtarlarını olarak oluşturabilir.

RSA (Rivest–Shamir–Adleman):
Asimetrik anahtar yapısını kullanarak güvenli anahtar paylaşımı ve veri şifreleme imkânı sunar. Uygulama, anahtar çifti (public/private key) üretimi ve metin tabanlı veri şifreleme/çözme işlemlerini destekler.

SHA-256 (Secure Hash Algorithm 256-bit):
Giriş verisinin tek yönlü olarak sabit uzunlukta bir hash çıktısına dönüştürülmesini sağlar. Dosya, metin veya bağlantıdan elde edilen içerikler için dijital parmak izi oluşturulabilir.

online site : [http://kriptofinalprojesi.somee.com/](https://kriptografionlinetools.somee.com/)
## Ana Sayfa

![image](https://github.com/user-attachments/assets/1ff0a0ef-9ae6-436a-9155-124bc9f692a5)

Ana sayfada görüldüğü üzere, sistem RSA, AES ve SHA-256 gibi modern kriptografi algoritmalarını desteklemektedir. Bunların yanı sıra, site tasarımı JavaScript ve CSS kullanılarak geliştirilmiş olup kullanıcıya görsel olarak estetik ve işlevsel bir arayüz sunmaktadır.

## Rsa

![Ekran görüntüsü 2025-05-31 161545](https://github.com/user-attachments/assets/6f8452c5-7369-40a4-9f02-df8b6e44f788)
Burası, RSA anahtar üretme (Key Generation) ekranıdır. Kullanıcı bu ekrandan asimetrik şifreleme için gerekli olan genel (public) ve özel (private) anahtar çiftini oluşturabilir.

![Ekran görüntüsü 2025-05-31 161556](https://github.com/user-attachments/assets/eb03ee17-2d61-4109-9be6-202f9421c5f2)
Bu ekranda, RSA anahtar üretimi için 1024, 2048 ve 4096 bit olmak üzere üç farklı anahtar uzunluğu seçeneği sunulmaktadır. Kullanıcı, ihtiyaç duyduğu güvenlik seviyesine göre uygun anahtar uzunluğunu belirleyerek anahtar çiftini oluşturabilir.

![image](https://github.com/user-attachments/assets/e2f4380e-d19c-49fa-8138-06fb66bbb260)
Bu ekranda, 1024 bit uzunluğunda üretilmiş bir RSA public (genel) ve private (özel) anahtar çifti görüntülenmektedir.

![image](https://github.com/user-attachments/assets/191ffa49-2b4a-4f43-a8df-cbbe6ff8d38c)
Burası, RSA algoritmasıyla şifreleme işleminin gerçekleştirildiği ekrandır. Kullanıcı, bu alana bir metin ve bir public key (genel anahtar) girerek metni şifreleyebilir.

![image](https://github.com/user-attachments/assets/1547de21-d612-495a-9d22-78778f428fc1)
Bu ekranda, “Deneme” metni girilmiş ve bir public key kullanılarak RSA şifreleme işlemi denenmiştir. Kullanıcı, örnek bir veriyle şifreleme sürecini test edebilmektedir.

![image](https://github.com/user-attachments/assets/02660cec-7588-4e7a-ab2d-88e248f9ca71)
Bu ekranda, RSA algoritmasıyla gerçekleştirilen şifreleme işleminin sonucu görüntülenmektedir. Girilen metin, belirtilen public key kullanılarak şifrelenmiş ve elde edilen şifreli veri burada gösterilmiştir.

![Ekran görüntüsü 2025-05-31 162238](https://github.com/user-attachments/assets/76c8ad2c-f977-45d7-8873-f1c326f2f3f3)
Bu ekran, RSA algoritmasıyla şifre çözme (decryption) işleminin gerçekleştirildiği bölümdür. Kullanıcı, şifrelenmiş metni ve ilgili private key’i girerek orijinal metni geri elde edebilir.

![image](https://github.com/user-attachments/assets/4fbba5f8-5b61-441c-9f96-695ee1c75d7d)
Bu ekranda, RSA algoritması ile şifre çözme işlemi sonucunda elde edilen orijinal (çözümlenmiş) metin görüntülenmektedir.

## SHA256

![Ekran görüntüsü 2025-05-24 215631](https://github.com/user-attachments/assets/5bba94e7-576a-46d0-9d50-da63151342e6)
Bu ekran, SHA-256 algoritmasına göre özet (hash) oluşturmak için kullanılır.

## AES

![Ekran görüntüsü 2025-05-24 215638](https://github.com/user-attachments/assets/3ae9e5b9-e710-46f0-b5a4-6431016ab8b8)
Bu ekranda AES şifreleme yöntemi uygulanmaktadır.

Umutcan Kemahlı Tarafından Hazırlanmıştır
