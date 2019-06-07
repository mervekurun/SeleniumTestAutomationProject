using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyorTestProject.PageModel
{
    public class Model
    {
        IWebDriver driver;

        public Model(IWebDriver driver){
            this.driver = driver;
        }
        public IWebElement Find(By by)
        {
            return driver.FindElement(by);
        }
        public void Click(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(150));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }
        public void SetText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }
        public void ScrollDown(IWebElement element)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            TimeSpan.FromSeconds(30);
            js.ExecuteScript("window.scrollTo("+element.Location.X+"," + element.Location.Y + ");");
        }
        public void Hover(IWebElement element)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Click().Build().Perform();
        }
        


    }
}
