using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests.PageObject.Base
{
    abstract class PageBase
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public PageBase(IWebDriver driver)
        {
            this._driver = driver;
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
    }
}

