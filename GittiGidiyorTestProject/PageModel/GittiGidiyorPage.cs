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

namespace GittiGidiyorTestProject.PageModel
{
    public class GittiGidiyorPage
    {
        #region
        IWebDriver driver = new ChromeDriver();

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
        #endregion
        public void LaunchHomePage()
        {

            driver.Navigate().GoToUrl("https://www.gittigidiyor.com/");
            btnClosePopUp =driver.FindElement(By.Id("gg-subscribe-close-button"));
            btnClosePopUp.Click();
            TimeSpan.FromSeconds(50);
            chromeOptions.AddArguments("disable-popup-blocking");
            
        }
       
        public void Login()
        {

            btnLogin = driver.FindElement(By.ClassName("profile-name"));
            btnLogin.Click();
        }
        public void SetUserName(string parameter)
        {
            txtUserName = driver.FindElement(By.Id("L-UserNameField"));
            txtUserName.SendKeys(parameter);
        }
        public void SetLastName(string parameter)
        {
            txtLastName = driver.FindElement(By.Id("L-PasswordField"));
            txtLastName.SendKeys(parameter);
        }
        public void ClickLoginEnter()
        {
            btnLogin = driver.FindElement(By.Id("gg-login-enter"));
            btnLogin.Click();
        }
        public void CheckCaptcha()
        {
            chcCaptcha = driver.FindElement(By.Id("recaptcha-checkbox-border"));
            chcCaptcha.Click();
        }
        public void MouseOverCategory()
        {
            Actions builder = new Actions(driver);
            btnCategory = driver.FindElement(By.CssSelector("#header_wrapper > div.hidden-m.hidden-t.horizontal-menu.robot-header-horizontalMenu-container.gg-d-24.gg-w-24 > div:nth-child(5) > p"));
            builder.MoveToElement(btnCategory).Click().Build().Perform();
        }
        public void ClickCategory()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(150));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#header_wrapper > div.hidden-m.hidden-t.horizontal-menu.robot-header-horizontalMenu-container.gg-d-24.gg-w-24 > div:nth-child(5) > div > div:nth-child(2) > div:nth-child(2) > a:nth-child(2)")));
            element.Click();
        }
        public void ScrollDown(int parameter)
        {
            IJavaScriptExecutor js=driver as IJavaScriptExecutor;
            TimeSpan.FromSeconds(30);
            js.ExecuteScript("window.scrollTo(0, "+parameter+");");
        }
        public void SelectPrice()
        {
            ScrollDown(500);
            chkPrice = driver.FindElement(By.CssSelector("#best-match-left > div:nth-child(4) > div > ul.filter_search_narrow_features.price-range-options > li:nth-child(3) > div > div"));
            TimeSpan.FromSeconds(100); 
            chkPrice.Click();
        }
        /*public void SelectType()
        {
            ScrollDown(1200);
            chkType = driver.FindElement(By.XPath("//*[@id='best - match - left']/div[9]/div/ul/li[3]/div/span/div/label"));
            ScrollDown(chkType.Location.Y);
            chkType.Click();
        }*/

        public void SelectProduct()
        {
            ScrollDown(500);
            btnProduct = driver.FindElement(By.XPath("//*[@id='product_id_421250356']"));
            btnProduct.Click();
        }
        public void ClickAddToBasket()
        {
            ScrollDown(300);
            btnAddToBasket = driver.FindElement(By.Id("add-to-basket"));
            btnAddToBasket.Click();
        }
        public void ClickCompleteShopping()
        {
            btnCompleteShopping = driver.FindElement(By.CssSelector("#submit-cart > div > div > div.gg-w-7.gg-d-8.gg-t-8.gg-m-24.right-box-container > div > div > div > div:nth-child(5) > input"));
            btnCompleteShopping.Click();
        }
        public void SelectAddress()
        {
            btnAdress = driver.FindElement(By.Id("item-7053495"));
            btnAdress.Click();
        }
        public void ClickPostAddress()
        {
            btnAdressPost = driver.FindElement(By.Id("post-address-form"));
            btnAdressPost.Click();
        }
        public void SetCreditCartNumber(string parameter)
        {
            txtCreditCartNumber = driver.FindElement(By.Id("P-CCNumberField"));
            txtCreditCartNumber.SendKeys(parameter);
        }
        public void SetOwnerName(string parameter)
        {
            txtOwnerName = driver.FindElement(By.Id("P-CCOwnerName"));
            txtOwnerName.SendKeys(parameter);
        }
        public void SetDate(string parameter1,string parameter2)
        {
            txtMonth = driver.FindElement(By.Id("P-CCMonthSelect"));
            txtYear = driver.FindElement(By.Id("P-CCYearSelect"));
            txtMonth.SendKeys(parameter1);
            txtYear.SendKeys(parameter2);
        }
        





    }


}
