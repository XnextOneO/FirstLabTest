using Lab10.Driver;
using Lab10.PageObjects;
using Lab10.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;



//model - сущность описываеь
//service - задает сущность и хранит данные

namespace Lab10
{
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Close()
        {
            Thread.Sleep(5000);
            steps.CloseBrowser();
        }

        [Test] //1. Просмотр телефонов модели Poco
        public void PocoModels()
        {
            steps.MainPageOpen();
          
            steps.TelefoniCheck();
            steps.PocoCheck();

        }


        [Test] //2. Просмотр хар-к телефона Poco
        public void ShowPocoModel()
        {
            steps.MainPageOpen();
            steps.TelefoniCheck();
            steps.PocoCheck();
            steps.ModelPocoClick();
            steps.MobilkaParam();
        }

        [Test] //3. Просмотр телефонов модели Poco
        public void Sravnenie()
        {
            steps.MainPageOpen();
            steps.TelefoniCheck();
            steps.TelefoniSravnenie();
        }

        [Test] //4. Добавление товара в корзину с указанием параметров
        public void InputXiaomi()
        {
            steps.MainPageOpen();
            steps.Input();
            steps.Xiaomi11TClick();
            

        }
       
        [Test] //7. Наушники
        public void POpitkaZaeb()
        {
            steps.MainPageOpen();
            steps.Headphones();
            steps.Xiaomi11TClick2();
            steps.Trashbin();
            steps.KorzinaOpen();
        }

        [Test] //5. Просмотр времени работы магазина со страницы товара
        public void WorkTime()
        {
            steps.MainPageOpen();
            steps.Input();
            steps.Xiaomi11TClick();
            steps.WorkTime();
        }

        [Test] //6. Просмотр правил выкупа оборудования
        public void RulesPayBack()
        {
            steps.MainPageOpen();
            steps.Vikup();
            steps.Here();
        }

        [Test] //7. Наушники
        public void Headphones()
        {
            steps.MainPageOpen();
            steps.Headphones();
            steps.Xiaomi11TClick2();
            steps.Trashbin();
        }

        [Test] //8. PlusKorzina
        public void PlusTrashbin()
        {
            steps.MainPageOpen();
            steps.Headphones();
            steps.Xiaomi11TClick2();
            steps.Trashbin();
            steps.KorzinaOpen();
            steps.TrashbinPlus();

        }

        [Test] //9. PlusKorzina
        public void MinusTrashbin()
        {
            steps.MainPageOpen();
            steps.Headphones();
            steps.Xiaomi11TClick2();
            steps.Trashbin();
            steps.KorzinaOpen();
            steps.TrashbinMinus();

        }






    }    
}
