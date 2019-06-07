using GittiGidiyorTestProject.PageModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GittiGidiyorTestProject.Test
{
    [Binding, Scope(Feature = "GittiGidiyorFeature")]
    public class GittiGidiyorTest
    {
        
        GittiGidiyorPage gittiGidiyor;
        IWebDriver driver = new ChromeDriver();
        [Before]
        public void Before() 
        {
         
         gittiGidiyor = new GittiGidiyorPage(driver);
         driver.Navigate().GoToUrl("https://www.gittigidiyor.com/");
         TimeSpan.FromSeconds(50);
           
        }
       [StepDefinition("GittiGidiyor.com açılır")]
        public void LaunchHomePage()
        {
            gittiGidiyor.LaunchHomePage();
        }

        [StepDefinition("Login yapılır")]
        public void Login()
        {
            gittiGidiyor.Login();
        }
        [StepDefinition("Kullanıcı adı '(.*)' girilir")]
        public void SetUserName(string userName)
        {
            gittiGidiyor.SetUserName(userName);
        }
        [StepDefinition("Şifre adı '(.*)' girilir")]
        public void SetLastName(string lastName)
        {
            gittiGidiyor.SetLastName(lastName);
        }
        [StepDefinition("Giriş yapılır")]
        public void ClickLoginEnter()
        {
            gittiGidiyor.ClickLoginEnter();
        }

        [StepDefinition("Bebek,Anne kategorisinin üzerine gelinir")]
        public void MouseOverCategory()
        {
            gittiGidiyor.MouseOverCategory();
        }

        [StepDefinition("Biberon Maması linkine tıklanır")]
        public void ClickCategory()
        {
            gittiGidiyor.ClickCategory();
        }
        [StepDefinition("Fiyat aralığı seçilir")]
        public void SelectPrice()
        {
            gittiGidiyor.SelectPrice();
        }
        [StepDefinition("Ücretsiz Kargo seçilir")]
        public void ClickCargo()
        {
            gittiGidiyor.ClickCargo();
        }
        [StepDefinition("ikinci ürün seçilir")]
        public void SelectProduct()
        {
            gittiGidiyor.SelectProduct();
        }
        [StepDefinition("Sepete eklenir")]
        public void ClickAddToBasket()
        {
            gittiGidiyor.ClickAddToBasket();
        }
        [StepDefinition("Alışveriş tamamlaya tıklanır")]
        public void ClickCompleteShopping()
        {
            gittiGidiyor.ClickCompleteShopping();
        }
        [StepDefinition("Ad '(.*)' yazılır")]
        public void SetName(string name)
        {
            gittiGidiyor.SetName(name);
        }
        [StepDefinition("Soyad '(.*)' yazılır")]
        public void SetSurname(string surName)
        {
            gittiGidiyor.SetSurname(surName);
        }
        [StepDefinition("Şehir '(.*)' seçilir")]
        public void SetCity(string city)
        {
            gittiGidiyor.SetCity(city);
        }
        [StepDefinition("İlçe '(.*)' seçilir")]
        public void SetDistrict(string district)
        {
            gittiGidiyor.SetDistrict(district);
        }
        [StepDefinition("Adres '(.*)' girilir")]
        public void SetAddress(string adress)
        {
            gittiGidiyor.SetAddress(adress);
        }
        [StepDefinition("Telefon Numarası '(.*)' girilir")]
        public void SetPhoneNumber(string phoneNumber)
        {
            gittiGidiyor.SetPhoneNumber(phoneNumber);
        }
        [StepDefinition("Kaydet ve Devam Et tıklanır")]
        public void ClickPostAdress()
        {
            gittiGidiyor.ClickPostAdress();
        }
        [StepDefinition("Adres seçilir")]
        public void SelectAddress()
        {
            gittiGidiyor.SelectAddress();
        }
        [StepDefinition("Devam Et butonuna tıklanır")]
        public void ClickPostAddress()
        {
            gittiGidiyor.ClickPostAddress();
        }
        [StepDefinition("Kredi Kartı numarası '(.*)' girilir")]
        public void SetCreditCartNumber(string cartNumber)
        {
            gittiGidiyor.SetCreditCartNumber(cartNumber);
        }
        [StepDefinition("Ad Soyad '(.*)' girilir")]
        public void SetOwnerName(string ownerName)
        {
            gittiGidiyor.SetOwnerName(ownerName);
        }
        [StepDefinition("Son Kullanma ayı '(.*)' yılı '(.*)' girilir")]
        public void SetDate(string cartMonth,string cartYear)
        {
            gittiGidiyor.SetDate(cartMonth, cartYear);
        }
        [StepDefinition("Güvenlik Kodu '(.*)' girilir")]
        public void SetCvcNumber(string cvcNumber)
        {
            gittiGidiyor.SetCvcNumber(cvcNumber);
        }
        [StepDefinition("Ödeme Yap tıklanır")]
        public void ClickBuyProduct()
        {
            gittiGidiyor.ClickBuyProduct();
        }
               
       [After]
        public void Close()
        {
           driver.Close();
        }
    }


}
