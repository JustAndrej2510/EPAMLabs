using Avatrade.Driver;
using Avatrade.Model;
using Avatrade.Pages;
using Avatrade.Service;
using Avatrade.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Tests
{
    [SetUpFixture]
    public abstract class CommonConditions
    {
        protected IWebDriver _driver;
        internal StartPage _startPage;
        internal string _randomMessage;
        private const string url = "https://www.avatrade.com/";

        [SetUp]
        public void SetupLogin()
        {
            _driver = DriverManager.GetDriver();
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();

            User user = UserCreator.WithCredentialsFromProperty();

            _startPage = new LoginPage(_driver)
                .LogIn()
                .InputEmail(user.Email)
                .InputPassword(user.Password)
                .SubmitAuthorization();
            _randomMessage = RandomMessageGenerator.GenerateRandomMessage();
        }

        [TearDown]
        public void CloseBrowser()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                ScreenshotManager.MakeScreenShot();
            }
            DriverManager.QuitDriver();
        }
    }
}
