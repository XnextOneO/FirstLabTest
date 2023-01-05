using _10lab.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FunctionalTests
{
    public class Tests  //Это интерфейс удаленного управления, который позволяет осуществлять самоанализ и контроль браузеров.
    {
        [Test]
        public void MyTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://xistore.by/";
            driver.Manage().Window.Maximize();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.ClickVikupButton();
            VikupPageObject zdes = new VikupPageObject(driver);
            zdes.ClickZdesButton();


        }
        
        [Test]
        public void MyTestSecond()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://xistore.by/";
            driver.Manage().Window.Maximize();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.ClickTelefoniButton();
            TelefoniPageObject telefoniPage = new TelefoniPageObject(driver);
            telefoniPage.ClickPocoButton();



        }







    }
}