using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using Avatrade.Pages;

namespace Avatrade
{
    public class Tests
    {
        private IWebDriver _driver;
        StartPage startPage;

        private const string TestEmail = "epamLabsTests@gmail.com";
        private const string TestPassword = "Pa$$w0rd";

        private const string ExpectedDeal = "BTCUSD";

        [SetUp]
        public void Setup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.avatrade.com/");
            _driver.Manage().Window.Maximize();
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            startPage = new StartPage(_driver);
            startPage.LogIn();
            startPage.InputEmail(TestEmail);
            startPage.InputPassword(TestPassword);
            startPage.SubmitAuthorization();
        }

        [Test]
        public void CreateDealToBuyBTCUSDTest()
        {
            startPage.SearchCurrencyInput(ExpectedDeal);
            startPage.SelectCurrency();
            startPage.CreateDeal();
            startPage.SwitchToDealPage();
            string actualDeal = startPage.GetActualDeal();

            Assert.AreEqual(ExpectedDeal, actualDeal);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}