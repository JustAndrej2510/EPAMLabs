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
    class OrderPage : PageBase
    {
        private By existedOrdersLocator = By.XPath("//div[@class='order-entity_symbolCell__3Z9If']");
        public OrderPage(IWebDriver _driver) : base(_driver) { }

        public List<IWebElement> GetListOfExistedOrders()
        {
            List<IWebElement> orderList = GetVisibilityElements(existedOrdersLocator, 10);

            Logger.WriteToLog($"List of the existed deals was recieved");
            return orderList;
        }
    }
}
