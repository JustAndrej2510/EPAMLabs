using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests
{
    public class Tests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private const string TestEmail = "epamLabsTest@gmail.com";
        private const string TestPassword = "Pa$$w0rd";

        private const string ExpectedDeal = "BTCUSD";

        [SetUp]
        public void StartPageSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.avatrade.com/");
            _driver.Manage().Window.Maximize();

            var logInBtn = _driver.FindElement(By.XPath("//div[@class='log-in-desktop']//span[@class='link-btn']"));
            logInBtn.Click();

            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var inputEmail = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='input-email']")));
            inputEmail.SendKeys(TestEmail);

            var inputPassword = _driver.FindElement(By.XPath("//input[@id='input-password']"));
            inputPassword.SendKeys(TestPassword);

            var submitBtn = _driver.FindElement(By.XPath("//div[@class='button-wrapper']//button[@type='submit']"));
            submitBtn.Click();
        }

        [Test]
        public void CreateDealToBuyBTCUSDTest()
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var searchCurrencyInput = _wait.Until(ExpectedConditions.ElementIsVisible(By
                .XPath("//input[@class='input_input__HVTcI input.child_input__2CwYp']")));
            searchCurrencyInput.SendKeys("BTCUSD");

            var selectCurrency = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//mark[text()='BTCUSD']/../..")));
            selectCurrency.Click();

            var createDealBtn = _wait.Until(ExpectedConditions.ElementIsVisible(By
                .XPath("//button[@class='button_container__1ULFl button.child_container__2Gdpz button_container_primary__urKYb']")));
           createDealBtn.Click();

            var switchToDealPageBtn = _driver.FindElement(By.XPath("//a[@href='/positions']"));
            switchToDealPageBtn.Click();

            _wait.Until(ExpectedConditions.ElementExists(By.XPath("//tr[@data-tour='positions']")));

            var actualDeal = _driver.FindElement(By.XPath("//tr[@data-tour='positions']/td[1]//div[text()='BTCUSD']")).Text;

            Assert.AreEqual(ExpectedDeal, actualDeal);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}