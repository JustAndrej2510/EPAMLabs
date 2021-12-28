using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Avatrade.Service;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Avatrade.Driver
{
    public static class DriverManager
    {
        private static ThreadLocal<IWebDriver> _driver = new ThreadLocal<IWebDriver>();
        private static string _browser = DataReader.GetTestSettings().browser.Name;
        public static IWebDriver GetDriver()
        {
            if(_driver.Value != null)
            {
                return null;
            }

            switch (_browser)
            {
                case "Firefox":
                    {
                        _driver.Value = new FirefoxDriver();
                        break;
                    }
                default:
                    {
                        _driver.Value = new ChromeDriver();
                        break;
                    }

            }

            return _driver.Value;
        }

        public static void QuitDriver()
        {
            _driver.Value.Quit();
            _driver.Value = null;
        }
    }

    
}
