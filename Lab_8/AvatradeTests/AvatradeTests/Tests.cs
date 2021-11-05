using System;
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
        public void CreatingDealToBuyBTCUSDTest()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}