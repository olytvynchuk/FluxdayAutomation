using OpenQA.Selenium;
using Framework.SeleniumUtils;
using OpenQA.Selenium.Support.UI;
using System;

namespace Fluxday
{
    public abstract class PageOperations<T> where T : class, new()
    {

        private static Lazy<T> _instance = new Lazy<T>(() => new T());
        public static T Instance
        {
            get => _instance.Value;
            set => _instance = null;
        }


        public virtual void EnterText(string elementType, string element, string value )
        {
            if (elementType == "XPath")
                Driver.FindElement(By.XPath(element)).SendKeys(value);
            if (elementType == "Id")
                Driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                Driver.FindElement(By.Name(element)).SendKeys(value);
        }
        public virtual void Click(string elementType, string element) 
        {
            if (elementType == "XPath")
                Driver.FindElement(By.XPath(element)).Click();
            if (elementType == "Id")
                Driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                Driver.FindElement(By.Name(element)).Click();
        }

        public virtual void SelectDropdown(string element, string value, string elementType) 
        {
            if (elementType == "XPath")
                new SelectElement(Driver.FindElement(By.XPath(element))).SelectByText(value);
            if (elementType == "Id")
                new SelectElement(Driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == "Name")
                new SelectElement(Driver.FindElement(By.Name(element))).SelectByText(value);
        }

    }
}
