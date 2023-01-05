using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10lab.PageObject
{
    internal class TelefoniPageObject
    {

        private IWebDriver _webdriver;

        private readonly By _pocoButton = By.LinkText("POCO");

        public TelefoniPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }
        public void ClickPocoButton()
        {
            _webdriver.FindElement(_pocoButton).Click();
        }
    }
}
