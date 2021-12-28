using Avatrade.Pages.Base;
using Avatrade.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Pages
{
    class LoginPage : PageBase
    {
        private By logInBtnLocator = By.XPath("//div[@class='log-in-desktop']//span[@class='link-btn']");
        private By inputEmailLocator = By.Id("input-email");
        private By inputPasswordLocator = By.Id("input-password");
        private By submitBtnLocator = By.XPath("//div[@class='button-wrapper']//button[@type='submit']");

        public LoginPage(IWebDriver _driver) : base(_driver) { }
        public LoginPage LogIn()
        {
            IWebElement logInBtn = FindElementWithWaitElementIsVisible(logInBtnLocator, 10);
            logInBtn.Click();

            Logger.WriteToLog("Login button was clicked");
            return this;

        }
        public LoginPage InputEmail(string testEmail)
        {
            var inputEmail = FindElementWithWaitElementIsVisible(inputEmailLocator, 10);
            inputEmail.SendKeys(testEmail);

            Logger.WriteToLog("Email was written in the input field");
            return this;
        }
        public LoginPage InputPassword(string testPassword)
        {
            IWebElement inputPassword = FindElementWithWaitElementIsVisible(inputPasswordLocator, 10);
            inputPassword.SendKeys(testPassword);

            Logger.WriteToLog("Password was written in the input field");
            return this;
        }
        public StartPage SubmitAuthorization()
        {
            IWebElement submitBtn = FindElement(submitBtnLocator);
            submitBtn.Click();

            Logger.WriteToLog("Authorization button was clicked");
            return new StartPage(_driver);
        }
    }
}
