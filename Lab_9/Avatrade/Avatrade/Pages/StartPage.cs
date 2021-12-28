using Avatrade.Pages.Base;
using Avatrade.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Pages
{
    class StartPage : PageBase
    {
       
        private By searchCurrencyInputLocator = By.XPath("//input[@class='input_input__HVTcI input.child_input__2CwYp']");
        private By selectCurrencyLocator = By.XPath("//mark[text()='BTCUSD']/../..");
        private By createDealToBuyBtnLocator = By
            .XPath("//button[@class='button_container__1ULFl button.child_container__2Gdpz button_container_primary__urKYb']");
        private By selectSellDealBtnLocator = By.XPath("//span[@data-key='orderEntryPanelSideSell']");
        private By switchToDealPageBtnLocator = By.XPath("//li[@data-tour='positionsMenu']//a[@class='aside_link__1hN4T']");
        private By switchToOrderPageBtnLocator = By.XPath("//li[@data-tour='positionsMenu']//following::li[1]");
        private By switchToChatPageBtnLocator = By.XPath("//li[@data-tour='positionsMenu']//following::li[4]");

        public StartPage(IWebDriver driver) : base(driver) {}

        public StartPage SearchCurrencyInput(string currency)
        {
            IWebElement searchCurrencyInput = FindElementWithWaitElementIsVisible(searchCurrencyInputLocator, 10);
            searchCurrencyInput.SendKeys(currency);

            Logger.WriteToLog($"Search currency {currency} was started");
            return this;
        }

        public StartPage SelectCurrency()
        {
            IWebElement searchCurrency = FindElementWithWaitElementIsVisible(selectCurrencyLocator, 10);
            searchCurrency.Click();

            Logger.WriteToLog($"Currency was selected");
            return this;
        }

        public StartPage CreateDeal()
        {
            IWebElement createDealBtn = FindElementWithWaitElementIsVisible(createDealToBuyBtnLocator, 10);
            createDealBtn.Click();

            Logger.WriteToLog($"Create deal button was clicked");
            return this;
        }

        public StartPage SelectSellDeal()
        {
            IWebElement createDealBtn = FindElementWithWaitElementIsVisible(selectSellDealBtnLocator, 10);
            createDealBtn.Click();

            Logger.WriteToLog($"Create deal to sell currency button was clicked");
            return this;
        }

        public OrderPage SwitchToOrderPage()
        {
            IWebElement switchToOrderPageBtn = FindElementWithWaitElementToBeClickable(switchToOrderPageBtnLocator, 10);
            switchToOrderPageBtn.Click();

            Logger.WriteToLog($"Page was switched to Order page");
            return new OrderPage(_driver);
        }

        public DealPage SwitchToDealPage()
        {
            IWebElement switchToDealPageBtn = FindElementWithWaitElementIsVisible(switchToDealPageBtnLocator, 10);
            switchToDealPageBtn.Click();

            Logger.WriteToLog($"Page was switched to Deal page");
            return new DealPage(_driver);
        }

        public ChatPage SwitchToChatPage()
        {
            IWebElement switchToChatPageBtn = FindElementWithWaitElementIsVisible(switchToChatPageBtnLocator, 10);
            switchToChatPageBtn.Click();

            Logger.WriteToLog($"Page was switched to Chat page");
            return new ChatPage(_driver);
        }
    }
}
