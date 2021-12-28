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
    class DealPage : PageBase
    {
        private By actualDealNameLocator = By.XPath("//div[@class='position-entity_symbol_name__1JKvF']");
        private By actualDealBuyDirectionLocator = By.XPath("//span[@data-key='positionsTableEntityBought']");
        private By actualDealSellDirectionLocator = By.XPath("//span[@data-key='positionsTableEntitySold']");
        private By closeDealPanelLocator = By
            .XPath("//tr[@class='table_row__1j9Kl position-table_row__2Hruu position-entity_row__7aHgc position-entity_rowSelected__jPxXQ']" + 
            "//li[@data-qa='position-entity__controls-cell-control-close-icon-container']");
        private By closeDealButtonLocator = By.XPath("//button[@class='button_container__1ULFl button.child_container__QkThO button_container_primary__urKYb']");
        private By switchToStartPageLocator = By.XPath("//li[@data-tour='homeScreen']");
        private By aggregateDealsCheckboxLocator = By.XPath("//span[@class='checkbox_view__3kaEA']");
        private By aggregateDealsRowLocator = By.XPath("//tr[@class='table_row__1j9Kl position-table_row__2Hruu position-aggregate-row_row__25ZaQ']");
        private By stopLossAndTakeProfitButtonsLocator = By
            .XPath("//tr[@class = 'table_row__1j9Kl position-table_row__2Hruu position-entity_row__7aHgc position-entity_rowSelected__jPxXQ']" +
            "//span[@data-key='positionsTableEntityAddProtection']");
        private By addStopLossAndTakeProfitToDealButtonLocator = By.XPath("//button[@class='button_container__1ULFl button.child_container__ND9eH button_container_primary__urKYb']");
        private By checkStopLossLocator = By.XPath("//span[@data-qa='position-entity__stop-loss-cell']");
        private By checkTakeProfitLocator = By.XPath("//span[@data-qa='position-entity__take-profit-cell']");
        public DealPage(IWebDriver _driver) : base(_driver) { }

        public List<IWebElement> GetExistedDealNames()
        {
            List<IWebElement> dealList = GetVisibilityElements(actualDealNameLocator, 10);

            Logger.WriteToLog($"List of existed deal names was recieved");
            return dealList;
               
        }

        public List<IWebElement> GetDealSellDirection()
        {
            List<IWebElement> dealList = GetVisibilityElements(actualDealSellDirectionLocator, 10);

            Logger.WriteToLog($"List of existed sell deal directions was recieved");
            return dealList;

        }

        public List<IWebElement> GetDealBuyDirection()
        {
            List<IWebElement> dealList = GetVisibilityElements(actualDealBuyDirectionLocator, 10);

            Logger.WriteToLog($"List of existed buy deal directions was recieved");
            return dealList;

        }

        public DealPage OpenCloseDealPanel()
        {
            IWebElement openCloseDealPanel = FindElementWithWaitElementIsVisible(closeDealPanelLocator, 10);
            openCloseDealPanel.Click();

            Logger.WriteToLog($"Close deal panel was opened");
            return this;
        }

        public DealPage CloseLastCreatedDeal()
        {
            IWebElement closeDealIcon = FindElementWithWaitElementIsVisible(closeDealButtonLocator, 10);
            closeDealIcon.Click();

            Logger.WriteToLog($"Close deal button was clicked");
            return this;
        }

        public DealPage AggregateDeals()
        {
            IWebElement aggregateDealsCheckbox = FindElementWithWaitElementToBeClickable(aggregateDealsCheckboxLocator, 10);
            aggregateDealsCheckbox.Click();

            Logger.WriteToLog($"Aggregate deals checkbox was clicked");
            return this;
        }
        public bool HasAggregatedDealsRow()
        {
            IWebElement aggregatedDealsRow = FindElementWithWaitElementIsVisible(aggregateDealsRowLocator, 10);

            Logger.WriteToLog($"Deals was aggregated");
            return aggregatedDealsRow.Displayed;
        }

        public DealPage OpenStopLossAndTakeProfitPanel()
        {
            List<IWebElement> stopLossBtn = GetVisibilityElements(stopLossAndTakeProfitButtonsLocator, 10);
            stopLossBtn[0].Click();

            Logger.WriteToLog($"Stop-loss panel was opened");
            return this;
        }

        public DealPage OpenTakeProfitPanel()
        {
            List<IWebElement> takeProfitBtn = GetVisibilityElements(stopLossAndTakeProfitButtonsLocator, 10);
            takeProfitBtn[0].Click();

            Logger.WriteToLog($"Take-profit panel was opened");
            return this;
        }

        public DealPage AddStopLossAndTakeProfitToDeal()
        {
            IWebElement addStopLossAndTakeProfitBtn = FindElementWithWaitElementToBeClickable(addStopLossAndTakeProfitToDealButtonLocator, 10);
            addStopLossAndTakeProfitBtn.Click();

            Logger.WriteToLog($"Stop-loss and Take-profit was added");
            return this;
        }

        public string GetStopLoss()
        {
            List<IWebElement> stopLoss = GetVisibilityElements(checkStopLossLocator, 10);

            Logger.WriteToLog($"Stop-loss was recieved");
            return stopLoss[0].Text;
        }
        public string GetTakeProfit()
        {
            List<IWebElement> takeProfit = GetVisibilityElements(checkTakeProfitLocator, 10);

            Logger.WriteToLog($"Take-profit was recieved");
            return takeProfit[0].Text;
        }

        public StartPage SwitchToStartPage()
        {
            IWebElement switchToStartPageBtn = FindElementWithWaitElementIsVisible(switchToStartPageLocator, 10);
            switchToStartPageBtn.Click();

            Logger.WriteToLog($"Page was switched to Start page");
            return new StartPage(_driver);
        }
    }
}
