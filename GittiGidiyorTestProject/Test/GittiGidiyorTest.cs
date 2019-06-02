using GittiGidiyorTestProject.PageModel;
using NUnit.Framework;
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
       GittiGidiyorPage gittiGidiyor=new GittiGidiyorPage();

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
        [StepDefinition("Fiyat seçilir")]
        public void SelectPrice()
        {
            gittiGidiyor.SelectPrice();
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
        [StepDefinition("Alışveriş tamamlanır")]
        public void ClickCompleteShopping()
        {
            gittiGidiyor.ClickCompleteShopping();
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

        /*[StepDefinition("Mama tipi seçilir")]
         public void SelectType()
         {
             gittiGidiyor.SelectType();
         }*/







    }


}
