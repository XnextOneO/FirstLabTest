using Lab10.Driver;
using Lab10.PageObjects;
using Lab10.Service;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Steps
{
    public class Steps
    {
        public IWebDriver driver;

        public void InitBrowser()
        {
            driver = DriverSingleton.OpenBrowser();
        }

        public void CloseBrowser()
        {
            Driver.DriverSingleton.CloseBrowser();
        }

        

        public void KorzinaOpen()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.OpenPage();
            mainPage.KorzinaClick();
        }

        

        public void KorzinaAdd()
        {
            TelefoniPage telefoniPage = new TelefoniPage(driver);
            telefoniPage.TelefoniAddClick();
        }

        public void KorzinaPlus()
        {
            KorzinaPage korzinaPage = new KorzinaPage(driver);
            korzinaPage.KorzinaPlusOne();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void MainPageOpen()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.OpenPage();
        }

        
        public void TelefoniCheck()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.TelefoniClick();

        }
        public void TelefoniSravnenie()
        {
            TelefoniPage telefoniPage = new TelefoniPage(driver);
            telefoniPage.TelefoniRedmi9AClick();
            telefoniPage.TelefoniRedmiNote11Click();
            telefoniPage.SravnenieClick();

        }
        public void PocoCheck()
        {
            TelefoniPage telefoniPage = new TelefoniPage(driver);
            telefoniPage.TelefoniPocoClick();
        }

        public void ModelPocoClick ()
        {
            TelefonPoco telefonPoco = new TelefonPoco(driver);
            telefonPoco.TelefonPocoModelClick();
        }

        public void MobilkaParam()
        {
            Mobilka mobilka = new Mobilka(driver);
            mobilka.MobilkaModelClick();
        }


        public void Input()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.ClickSearchTextField(CameraCreator.WithCredentials().GetModel());
        }

        public void Xiaomi11TClick()
        {
            Lite lite = new Lite(driver);
            lite.OpenPage();
            lite.LiteToKorzina();
           
        }

        public void Xiaomi11TClick2()
        {
            Lite lite = new Lite(driver);
 
            lite.LiteToMusorka();
        }

        public void WorkTime()
        {
            Lite lite = new Lite(driver);

            lite.WorkTime();
        }

        public void Here()
        {
            PayBack payBack = new PayBack(driver);
            payBack.Zdes();
        }

        public void Vikup()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.Vikupp();

        }

        public void Headphones()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.Naushnikii();
            mainPage.Naushniki();
        }


        public void Trashbin()
        {
            RedmiBuds redmiBuds = new RedmiBuds(driver);
            redmiBuds.Trash();

        }

        public void TrashbinPlus()
        {
            RedmiBuds redmiBuds = new RedmiBuds(driver);
            redmiBuds.TrashPlu();

        }


    }
}
