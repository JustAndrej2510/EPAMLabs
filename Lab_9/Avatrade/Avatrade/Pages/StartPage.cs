using Avatrade.Pages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Pages
{
    class StartPage : PageBase
    {
        private By logInBtnLocator = By.XPath("//div[@class='log-in-desktop']//span[@class='link-btn']");
        private By inputEmailLocator = By.Id("input-email");
        private By inputPasswordLocator = By.Id("input-password");
        private By submitBtnLocator = By.XPath("//div[@class='button-wrapper']//button[@type='submit']");
        private By searchCurrencyInputLocator = By.XPath("//input[@class='input_input__HVTcI input.child_input__2CwYp']");
        private By selectCurrencyLocator = By.XPath("//mark[text()='BTCUSD']/../..");
        private By createDealBtnLocator = By
            .XPath("//button[@class='button_container__1ULFl button.child_container__2Gdpz button_container_primary__urKYb']");
        private By switchToDealPageBtnLocator = By.XPath("//li[@data-tour='positionsMenu']//a[@class='aside_link__1hN4T']");
        //private By dealPositionsLocator = By.XPath("//li[@data-tour='positionsMenu']//a[@class='aside_link__1hN4T']");
        private By actualDealLocator = By.XPath("//tr[@data-tour='positions']/td[1]//div[text()='BTCUSD']");
        public StartPage(IWebDriver driver) : base(driver)
        {

        }

        public void LogIn()
        {
            IWebElement logInBtn = FindElementWithWaitElementIsVisible(logInBtnLocator, 5);
            //IWebElement logInBtn = FindElement(logInBtnLocator);
            logInBtn.Click();

        }
        public void InputEmail(string testEmail)
        {
            //FindElementWithWaitElementExists(popupLocator, 5);
            var inputEmail = FindElementWithWaitElementIsVisible(inputEmailLocator, 5);
            inputEmail.SendKeys(testEmail);
        }
        public void InputPassword(string testPassword)
        {
            IWebElement inputPassword = FindElementWithWaitElementIsVisible(inputPasswordLocator, 5);
            inputPassword.SendKeys(testPassword);
        }
        public void SubmitAuthorization()
        {
            IWebElement submitBtn = FindElement(submitBtnLocator);
            submitBtn.Click();
        }

        public void SearchCurrencyInput(string currency)
        {
            IWebElement searchCurrencyInput = FindElementWithWaitElementIsVisible(searchCurrencyInputLocator, 5);
            searchCurrencyInput.SendKeys(currency);
        }

        public void SelectCurrency()
        {
            IWebElement searchCurrency = FindElementWithWaitElementIsVisible(selectCurrencyLocator, 5);
            searchCurrency.Click();
        }

        public void CreateDeal()
        {
            IWebElement createDealBtn = FindElementWithWaitElementIsVisible(createDealBtnLocator, 5);
            createDealBtn.Click();
        }

        public void SwitchToDealPage()
        {
            IWebElement switchToDealPageBtn = FindElement(switchToDealPageBtnLocator);
            switchToDealPageBtn.Click();
        }

        public string GetActualDeal()
        {
            //var dealPositions = FindElementWithWaitElementExists(dealPositionsLocator, 5);
            return FindElementWithWaitElementIsVisible(actualDealLocator, 5).Text;
        }
    }
}
