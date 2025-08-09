## Güvenli Veri Şifreleme

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

![Ekran görüntüsü 2025-05-31 162551](https://github.com/user-attachments/assets/b10e74a3-f121-43c2-8006-9a67fb525fec)
Bu ekran, SHA-256 tek yönlü hash algoritmasının uygulandığı bölümdür. Kullanıcı, burada ister metin ister dosya girerek hash (özet) değerini oluşturabilir.

![image](https://github.com/user-attachments/assets/91fbd80f-df94-44f2-8e64-43517c5e033a)
SHA-256 algoritması kullanılarak “Umutcan Kemahlı” metni hashlenmiştir.

![image](https://github.com/user-attachments/assets/b5e6504d-5ab6-43c4-8dc6-2fd6a507bcb1)
Hash işleminin sonucu ekranda görüntülenmektedir.

![image](https://github.com/user-attachments/assets/578e6c96-5849-4ca6-bddb-11738025ac3f)
Burada, bir dosyanın SHA-256 algoritması ile hash’lenmiş hali görülmektedir.

## AES

![image](https://github.com/user-attachments/assets/272a7367-6aa0-4ccb-a9ce-4910d376054c)
Bu ekran, AES algoritmasıyla şifreleme ve şifre çözme işlemlerinin yapıldığı bölümdür. Kullanıcı, dosya, metin veya URL girerek bir şifre belirleyebilir ve bu veriyi AES ile şifreleyebilir ya da daha önce şifrelenmiş veriyi girip çözümleyebilir.

![image](https://github.com/user-attachments/assets/8bcfd34d-a7fb-4aee-bd6d-0726d4c6191f)
Bu ekranda, AES şifreleme işlemi için “Deneme” adlı bir metin ve “1234” şifresi girilmiştir.

![image](https://github.com/user-attachments/assets/7ceb15df-23cf-45ef-86b4-8deecca7845f)
Bu ekranda, AES algoritmasıyla şifrelenen verinin şifreli (kriptolanmış) sonucu görüntülenmektedir.

![image](https://github.com/user-attachments/assets/ae7dc4f5-d484-4900-93bc-e5612b742639)
Bu ekranda, AES algoritmasıyla şifre çözme (decryption) işlemi gerçekleştirilmektedir.

![image](https://github.com/user-attachments/assets/64df8cec-fb5d-4ca6-b416-21a4a4ca0cc9)
Şifre çözme işleminin sonucu bu ekranda görüntülenmektedir.

![image](https://github.com/user-attachments/assets/58c69f3e-e019-4b0e-b4ce-abb6d7f5b357)
Burada, AES algoritmasıyla bir dosya türünün şifrelendiği görülmektedir.

Umutcan Kemahlı Tarafından Hazırlanmıştır
