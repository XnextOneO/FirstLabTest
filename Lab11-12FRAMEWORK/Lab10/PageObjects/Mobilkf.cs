using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Lab10.PageObjects
{
   public class Mobilka
    {
        private const string BASE_URL = "https://xistore.by/catalog/poco/smartfon_poco_m4_pro_5g/?offer=86966";

        private IWebDriver driver;
        private Actions action;


        private readonly By ParametrClick = By.XPath("/html/body/div[2]/div[5]/div[1]/div/div[1]/div[3]/div[1]/div[1]/div[1]/div[2]/a[2]");

        public Mobilka(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }


        public Mobilka MobilkaModelClick()
        {
            action.MoveToElement(driver.FindElement(ParametrClick)).Click();
            action.Perform();
            return this;
        }
    }
}
