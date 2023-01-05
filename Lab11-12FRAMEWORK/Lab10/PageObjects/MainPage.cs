using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab10.PageObjects
{
    public class MainPage
    {
        private const string BASE_URL = "https://xistore.by/";

        private IWebDriver driver;
        private Actions action;

        private readonly By Korzina = By.XPath("/html/body/div[2]/div[1]/div/div/div/div[2]/a/span[1]");
        private readonly By Plus = By.XPath("/html/body/div[2]/div[5]/div/div/div/div/div[2]/div[2]/form/div[2]/div[1]/div[2]/div/div[1]/table/tbody/tr/td[5]/div/a[1]");
        private readonly By Telefoni = By.XPath("/html/body/div[2]/div[2]/div[1]/div[1]/div/div/div[2]/ul/li[1]/a");
        private readonly By SearchResultButton = By.XPath("//input[@name='apply']");
        private readonly By SearchElementField = By.XPath("/html/body/div[2]/header/div/div/div[2]/div/div/div/form/input");
        private readonly By Xiaomi11T = By.XPath("/html/body/div[2]/header/div/div/div[2]/div/div/div/div/div[1]/div[2]/div[4]/a");
        private readonly By Vikup = By.XPath("/html/body/div[2]/div[1]/div/div/div/nav[2]/ul/li[8]/a");
        private readonly By HeadPhones = By.XPath("/html/body/div[2]/div[2]/div[1]/div[1]/div/div/div[2]/ul/li[7]/div/div[1]/ul/li/ul[2]/li/span[13]/a/span[2]");
        private readonly By HeadPhonesPanel = By.XPath("/html/body/div[2]/div[2]/div[1]/div[1]/div/div/div[2]/ul/li[7]/a");
        

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));
        }

        public MainPage KorzinaClick()
        {
            action.MoveToElement(driver.FindElement(Korzina)).Click();
            action.Perform();
            return this;
        }

        public MainPage TelefoniClick()
        {
            action.MoveToElement(driver.FindElement(Telefoni)).Click();
            action.Perform();
            return this;
        }

        public MainPage ClickSearchTextField(string SearchText)
        {
            driver.FindElement(SearchElementField).SendKeys(SearchText);          
            return this;
        }

        public MainPage Xiaomi11TClick()
        {
            action.MoveToElement(driver.FindElement(Xiaomi11T)).Click();
            action.Perform();
            return this;
        }
        public MainPage Vikupp()
        {
            action.MoveToElement(driver.FindElement(Vikup)).Click();
            action.Perform();
            return this;
        }
        public MainPage Naushnikii()
        {
            action.MoveToElement(driver.FindElement(HeadPhonesPanel));
            action.Perform();
            return this;
        }

        public MainPage Naushniki()
        {
            action.MoveToElement(driver.FindElement(HeadPhones)).Click();
            action.Perform();
            return this;
        }

    }
}
