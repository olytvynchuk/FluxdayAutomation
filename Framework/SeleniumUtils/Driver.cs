using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Framework.SeleniumUtils
{
    public static class Driver
    {
        [ThreadStatic]

        private static IWebDriver _driver;
        public static void Init()
        {
            _driver = new ChromeDriver(Path.GetFullPath("@../../../../../../_drivers"));
        }

        public static IWebDriver Current => _driver ?? throw new NullReferenceException("_driver is null.");

        public static void Goto(string url)
        {
            if (!url.StartsWith("https"))
            {
                url = $"https://{url}";
            }
            Current.Manage().Cookies.DeleteAllCookies();
            Debug.WriteLine(url);
            Current.Navigate().GoToUrl(url);
        }

        public static IWebElement FindElement(By by) 
        {
            return Current.FindElement(by);
        }

        public static IList<IWebElement> FindElements(By by) 
        {
            return Current.FindElements(by);
        }
    }
}
