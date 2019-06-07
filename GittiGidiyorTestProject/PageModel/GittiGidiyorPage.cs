using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GittiGidiyorTestProject.PageModel
{
    [Binding]
    [TestFixture]
    public class GittiGidiyorPage : Model
    {
        #region
        //IWebDriver driver = new ChromeDriver();

        ChromeOptions chromeOptions = new ChromeOptions();

        [FindsBy(How = How.ClassName, Using = "profile-name")]
        public IWebElement btnLogin;

        public IWebElement btnClosePopUp;

        public IWebElement txtUserName;

        public IWebElement txtLastName;

        public IWebElement chcCaptcha;

        public IWebElement btnCategory;

        public IWebElement lnkCategory;

        public IWebElement chkPrice;

        public IWebElement chkType;

        public IWebElement btnProduct;

        public IWebElement btnAddToBasket;

        public IWebElement btnCompleteShopping;

        public IWebElement btnAdress;

        public IWebElement btnAdressPost;

        public IWebElement txtCreditCartNumber;

        public IWebElement txtOwnerName;

        public IWebElement txtMonth;

        public IWebElement txtYear;

        public IWebElement txtCVCNumber;

        public IWebElement chc3DSecure;

        public IWebElement btnBuyProduct;

        public IWebElement txtName;

        public IWebElement txtSurname;

        public IWebElement txtCity;

        public IWebElement txtDistrict;

        public IWebElement txtAdress;

        public IWebElement txtPhoneNumber;

        public IWebElement btnPostAdress;

        public IWebElement tbCargo;

        public IWebElement btnCargo;
        #endregion

        public GittiGidiyorPage(IWebDriver driver):base(driver){

        }
        public void LaunchHomePage()
        {
            Click(Find((By.Id("gg-subscribe-close-button"))));
            chromeOptions.AddArguments("disable-popup-blocking");
            
        }
       
        public void Login()
        {
             Click(Find(By.ClassName("profile-name")));
        }
        public void SetUserName(string parameter)
        {
            SetText(Find(By.Id("L-UserNameField")), parameter);
        }
        public void SetLastName(string parameter)
        {
            SetText(Find(By.Id("L-PasswordField")), parameter);
        }
        public void ClickLoginEnter()
        {
            Click(Find(By.Id("gg-login-enter")));
        }
        public void CheckCaptcha()
        {
            Click(Find(By.Id("recaptcha-checkbox-border")));
        }
        public void MouseOverCategory()
        {
            Hover(Find(By.CssSelector("#header_wrapper > div.hidden-m.hidden-t.horizontal-menu.robot-header-horizontalMenu-container.gg-d-24.gg-w-24 > div:nth-child(5) > p")));
            
        }
        public void ClickCategory()
        {
            Click(Find(By.CssSelector("#header_wrapper > div.hidden-m.hidden-t.horizontal-menu.robot-header-horizontalMenu-container.gg-d-24.gg-w-24 > div:nth-child(5) > div > div:nth-child(2) > div:nth-child(2) > a:nth-child(2)")));
        }
        
        public void SelectPrice()
        {
            
            chkPrice = Find(By.CssSelector("#best-match-left > div:nth-child(4) > div > ul.filter_search_narrow_features.price-range-options > li:nth-child(3) > div > div"));
            ScrollDown(chkPrice);
            Click(chkPrice);
        }

        public void SelectProduct()
        {
            
            btnProduct = Find(By.XPath("//*[@id='product_id_421250356']"));
            ScrollDown(btnProduct);
            Click(btnProduct);
        }
        public void ClickAddToBasket()
        {            
            btnAddToBasket = Find(By.Id("add-to-basket"));
            ScrollDown(btnAddToBasket);
            Click(btnAddToBasket);
        }
        public void ClickCompleteShopping()
        {
            Click(Find(By.CssSelector("#submit-cart > div > div > div.gg-w-7.gg-d-8.gg-t-8.gg-m-24.right-box-container > div > div > div > div:nth-child(5) > input")));
        }
        public void SelectAddress()
        {
            Click(Find(By.Id("item-7053495")));
        }
        public void ClickPostAddress()
        {
            Click(Find(By.Id("post-address-form")));
        }
        public void SetCreditCartNumber(string parameter)
        {
            SetText(Find(By.Id("P-CCNumberField")), parameter);
        }
        public void SetOwnerName(string parameter)
        {
            SetText(Find(By.Id("P-CCOwnerName")), parameter);
        }
        public void SetDate(string parameter1,string parameter2)
        {
            SetText(Find(By.Id("P-CCMonthSelect")), parameter1);
            SetText(Find(By.Id("P-CCYearSelect")), parameter2);
        }
        public void SetCvcNumber(string parameter)
        {
            SetText(Find(By.Id("P-CVCNumberField")), parameter);
        }
        public void Click3DSecure()
        {
            Click(Find(By.Id("secure3D")));
        }
        public void ClickBuyProduct()
        {
            Click(Find(By.Id("BuyProduct")));
        }
        public void SetName(string parameter)
        {
            SetText(Find(By.Name("Name")), parameter);
        }
        public void SetSurname(string parameter)
        {
            SetText(Find(By.Name("SurName")), parameter);
        }
        public void SetCity(string parameter)
        {
            SetText(Find(By.Name("City")), parameter);
        }
        public void SetDistrict(string parameter)
        {
            SetText(Find(By.Name("District")), parameter);
        }
        public void SetAddress(string parameter)
        {
            SetText(Find(By.Name("Address")), parameter);
        }
        public void SetPhoneNumber(string parameter)
        {
            SetText(Find(By.Name("phone-number")), parameter);
        }
        public void ClickPostAdress()
        {
            Click(Find(By.ClassName("gg-ui-btn gg-ui-btn-blue gg-btn post-address")));
        }
        public void ClickCargo()
        {
            ScrollDown(Find(By.Id("search-page-tab-free-shipping")));
            Click(Find(By.Id("search-page-tab-free-shipping")));
            
        }


    }


}
