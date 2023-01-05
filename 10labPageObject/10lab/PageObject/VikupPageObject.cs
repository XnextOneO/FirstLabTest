using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10lab.PageObject
{
    internal class VikupPageObject
    {
        private IWebDriver _webdriver;

        private readonly By _zdesButton = By.XPath("/html/body/div[2]/div[5]/div/div/div/div/div/ul/li[2]/a");

        public VikupPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }
        public void ClickZdesButton()
        {
            _webdriver.FindElement(_zdesButton).Click();
        }
    }
}
