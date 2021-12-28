using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Pages.Base
{
    internal abstract class PageBase
    {
        protected IWebDriver _driver;
        private WebDriverWait _wait;

        public PageBase(IWebDriver driver)
        {
            this._driver = driver;
        }

        public List<IWebElement> GetElements(By locator)
        {
            IReadOnlyCollection<IWebElement> readOnlyElements = _driver.FindElements(locator);
            List<IWebElement> elements = new List<IWebElement>();
            foreach (IWebElement element in readOnlyElements)
                elements.Add(element);

            return elements;
        }

        public List<IWebElement> GetVisibilityElements(By locator, double seconds)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
            IReadOnlyCollection<IWebElement> readOnlyElements = _driver.FindElements(locator);
            List<IWebElement> elements = new List<IWebElement>();
            foreach (IWebElement element in readOnlyElements)
                elements.Add(element);

            return elements;
        }
        public IWebElement FindElement(By locator)
        {
            return _driver.FindElement(locator);
        }

        public IWebElement FindElementWithWaitElementIsVisible(By locator, double seconds)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(seconds));
            return _wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement FindElementWithWaitElementToBeClickable(By locator, double seconds)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(seconds));
            return _wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public IWebElement FindElementWithWaitElementExists(By locator, double seconds)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(seconds));
            return _wait.Until(ExpectedConditions.ElementExists(locator));
        }

        public void SwitchToFrame(By frameLocator)
        {
            _driver.SwitchTo().Frame(FindElement(frameLocator));
        }
    }
}
