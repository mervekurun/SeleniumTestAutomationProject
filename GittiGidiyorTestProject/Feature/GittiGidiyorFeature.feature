Feature: GittiGidiyorFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@gittigidiyor
Scenario: GittiGidiyorTest 
* GittiGidiyor.com açılır
* Login yapılır
* Kullanıcı adı 'username' girilir
* Şifre adı 'password' girilir
* Giriş yapılır
* Bebek,Anne kategorisinin üzerine gelinir
* Biberon Maması linkine tıklanır
* Fiyat aralığı seçilir
* Ücretsiz Kargo seçilir
* ikinci ürün seçilir
* Sepete eklenir
* Alışveriş tamamlaya tıklanır
* Ad 'Merve' yazılır
* Soyad 'Kurun' yazılır
* Şehir 'İstanbul' seçilir 
* İlçe 'Kağıthane' seçilir 
* Adres 'İstanbul-Kağıthane' girilir
* Telefon Numarası '1234567' girilir
* Kaydet ve Devam Et tıklanır
* Devam Et butonuna tıklanır
* Kredi Kartı numarası '1234567890122345' girilir 
* Ad Soyad 'Merve Kurun' girilir
* Son Kullanma ayı '01' yılı '2020' girilir
* Güvenlik Kodu '123' girilir
* Ödeme Yap tıklanır

@gittigidiyorWithAddAddress
Scenario: GittiGidiyorTestWithAdress
* GittiGidiyor.com açılır
* Login yapılır
* Kullanıcı adı 'username' girilir
* Şifre adı 'password' girilir
* Giriş yapılır
* Bebek,Anne kategorisinin üzerine gelinir
* Biberon Maması linkine tıklanır
* Fiyat aralığı seçilir
* Ücretsiz Kargo seçilir
* ikinci ürün seçilir
* Sepete eklenir
* Alışveriş tamamlaya tıklanır
* Adres seçilir
* Devam Et butonuna tıklanır
* Kredi Kartı numarası '1234567890122345' girilir 
* Ad Soyad 'Merve Kurun' girilir
* Son Kullanma ayı '01' yılı '2020' girilir
* Güvenlik Kodu '123' girilir
* Ödeme Yap tıklanır