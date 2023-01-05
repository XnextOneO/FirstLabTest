using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab10.PageObjects
{
    class Lite
    {
        private const string BASE_URL = "https://xistore.by/catalog/mi/smartfon_xiaomi_mi_11_lite_5g_ne/?offer=112634";

        private IWebDriver driver;
        private Actions action;


        private readonly By Black = By.XPath("/html/body/div[2]/div[5]/div[1]/div/div[1]/div[3]/div[1]/div[5]/div[1]/div[2]/div[1]/ul/li[2]/a/span/span");
        private readonly By AdddKorzina = By.XPath("/html/body/div[2]/div[5]/div[1]/div/div[1]/div[3]/div[1]/div[5]/div[1]/div[2]/div[1]/ul/li[2]/a/span/span");
        private readonly By TimeWork = By.XPath("/html/body/div[2]/div[5]/div[1]/div/div[1]/div[1]/div[4]/div[1]/div[3]/a");




        public Lite(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));
        }

        public Lite LiteToKorzina()
        {
            action.MoveToElement(driver.FindElement(Black)).Click();
           
            action.Perform();
            return this;
        }

        public Lite LiteToMusorka()
        {
            action.MoveToElement(driver.FindElement(AdddKorzina)).Click();
            action.Perform();
            return this;
        }

        public Lite WorkTime()
        {
            action.MoveToElement(driver.FindElement(TimeWork)).Click();
            action.Perform();
            return this;
        }
    }
}
