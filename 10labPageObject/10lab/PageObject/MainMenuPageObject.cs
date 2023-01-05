using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10lab.PageObject
{
    internal class MainMenuPageObject
    {
        private IWebDriver _webdriver;

        private readonly By _vikupButton = By.XPath("/html/body/div[2]/div[1]/div/div/div/nav[2]/ul/li[8]/a");
        private readonly By _telefoniButton = By.LinkText("Телефоны");

        public MainMenuPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }

        public void ClickVikupButton()
        {
            _webdriver.FindElement(_vikupButton).Click();
        }

        public void ClickTelefoniButton()
        {
            _webdriver.FindElement(_telefoniButton).Click();
        }
    }
}
