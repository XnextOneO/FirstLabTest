using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab10.PageObjects
{
    public class TelefonPoco
    {

        private const string BASE_URL = "https://xistore.by/catalog/poco/";

        private IWebDriver driver;
        private Actions action;


        private readonly By TelefonPocoClick = By.XPath("/html/body/div[2]/div[7]/div/div/div[3]/div/div[1]/div/a[3]");

        public TelefonPoco(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }


        public TelefonPoco TelefonPocoModelClick()
        {
            action.MoveToElement(driver.FindElement(TelefonPocoClick)).Click();
            action.Perform();
            return this;
        }



    }
}
