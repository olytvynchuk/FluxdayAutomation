using Fluxday.Maps;
using Framework.SeleniumUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Fluxday.Pages
{
    public class SideBarMenu 
    {
        private readonly SideBarMenuMap Map;        
        public SideBarMenu()
        {
            Map = new SideBarMenuMap();            
        }
        
        public IWebElement QuickSearchPlaceholder => Driver.FindElement(By.XPath(Map.QuickSearchPlaceholderXPath));
        public IWebElement DashboardLink => Driver.FindElement(By.XPath(Map.DashboardLinkXPath));
        public IWebElement MyTasksLink => Driver.FindElement(By.XPath(Map.MyTasksLinkXPath));
        public IWebElement DepartmentsLink => Driver.FindElement(By.XPath(Map.DepartmentsLinkXPath));
        public IWebElement TeamLink => Driver.FindElement(By.XPath(Map.TeamLinkXPath));
        public IWebElement UsersLink => Driver.FindElement(By.XPath(Map.UsersLinkXPath));
        public IWebElement OKRLink => Driver.FindElement(By.XPath(Map.OkrLinkXPath));
        public IWebElement ReportsLink => Driver.FindElement(By.XPath(Map.ReportsLinkXPath));
        public IWebElement AdminUserLink => Driver.FindElement(By.XPath(Map.AdminUserLinkXPath));
        public IWebElement LogOutLink => Driver.FindElement(By.XPath(Map.LogOutLinkXPath));

        public virtual T TypeTextToTextField<T>(IWebElement field, string text) where T : class, new()
        {
            field.SendKeys(text);
            return new();
        }

        public T ClickOnButton<T>(IWebElement button) where T : class, new() 
        {
            button.Click();
            return new();
        }

        public AuthorizationPage ReturnToAuthorizationPage() 
        {
            ClickOnButton<AuthorizationPage>(LogOutLink);
            return new AuthorizationPage();
        }       
    }           
}


