using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab10.PageObjects
{
    public class PayBack
    {
        private IWebDriver driver;
        private Actions action;

        private readonly By Here = By.XPath("/html/body/div[2]/div[5]/div/div/div/div/div/ul/li[2]/a");

        public PayBack(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public PayBack Zdes()
        {
            action.MoveToElement(driver.FindElement(Here)).Click();
            action.Perform();
            return this;
        }
    }
}
