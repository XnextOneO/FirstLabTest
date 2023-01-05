using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab10.PageObjects
{
    public class TelefoniPage
    {
        private const string BASE_URL = "https://xistore.by/catalog/telefony/";

        private IWebDriver driver;
        private Actions action;


        private readonly By TelefonAdd = By.XPath("/html/body/div[2]/div[5]/div/div/div[3]/div/div/div[3]/div[1]/div[1]/div/a[6]");
        private readonly By TelefonAddPoco = By.XPath("/html/body/div[2]/div[5]/div/div/div[2]/div/div/div/a[4]");
        private readonly By TelefoniRedmi9A = By.XPath("/html/body/div[2]/div[5]/div/div/div[3]/div/div/div[3]/div[1]/div[1]/div/div[9]/a[1]/span[1]");
        private readonly By TelefonRedmiNote11 = By.XPath("/html/body/div[2]/div[5]/div/div/div[3]/div/div/div[3]/div[1]/div[2]/div/div[17]/a[1]");
        private readonly By SravnenieButton = By.XPath("/html/body/footer/div[3]");



        public TelefoniPage(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public TelefoniPage TelefoniAddClick()
        {
            action.MoveToElement(driver.FindElement(TelefonAdd)).Click();
            action.Perform();
            return this;
        }

        public TelefoniPage TelefoniPocoClick()
        {
            action.MoveToElement(driver.FindElement(TelefonAddPoco)).Click();
            action.Perform();
            return this;
        }

        public TelefoniPage TelefoniRedmi9AClick()
        {
            action.MoveToElement(driver.FindElement(TelefoniRedmi9A)).Click();
            action.Perform();
            return this;
        }

        public TelefoniPage TelefoniRedmiNote11Click()
        {
            action.MoveToElement(driver.FindElement(TelefonRedmiNote11)).Click();
            action.Perform();
            return this;
        }

        public TelefoniPage SravnenieClick()
        {
            action.MoveToElement(driver.FindElement(SravnenieButton)).Click();
            action.Perform();
            return this;
        }


    }
}
