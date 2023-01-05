using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab10.PageObjects
{
    public class RedmiBuds
    {
        private const string BASE_URL = "https://xistore.by/catalog/poco/smartfon_poco_m4_pro_5g/?offer=86966";

        private IWebDriver driver;
        private Actions action;


        private readonly By TrashBin = By.XPath("/html/body/div[2]/div[5]/div[1]/div/div[1]/div[3]/div[1]/div[9]/a[1]");
        private readonly By TrashPlus = By.XPath("/html/body/div[2]/div[5]/div/div/div/div/div[2]/div[2]/form/div[2]/div[1]/div[2]/div/div[1]/table/tbody/tr/td[5]/div/a[1]");


        public RedmiBuds(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));
        }


        public RedmiBuds Trash()
        {
            action.MoveToElement(driver.FindElement(TrashBin)).Click();
            action.Perform();
            return this;
        }

        public RedmiBuds TrashPlu()
        {
            action.MoveToElement(driver.FindElement(TrashPlus)).Click();
            action.Perform();
            return this;
        }

    }
}
