using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Lab10.PageObjects
{
    public class KorzinaPage
    {
        private const string BASE_URL = "https://xistore.by/personal/order/make/";

        private IWebDriver driver;
        private Actions action;


        private readonly By KorzinaPlus = By.XPath("/html/body/div[2]/div[5]/div/div/div/div/div[2]/div[2]/form/div[2]/div[1]/div[2]/div/div[1]/table/tbody/tr/td[5]/div/a[1]");


        public KorzinaPage(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public KorzinaPage KorzinaPlusOne()
        {
            action.MoveToElement(driver.FindElement(KorzinaPlus)).Click();
            action.Perform();
            return this;
        }
    }
}
