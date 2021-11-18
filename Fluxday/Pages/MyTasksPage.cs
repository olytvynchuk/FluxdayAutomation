using Fluxday.Maps;
using Framework.SeleniumUtils;
using OpenQA.Selenium;

namespace Fluxday.Pages
{
    public class MyTasksPage : SideBarMenu
    {
        public readonly MyTasksPageMap Map;
        public MyTasksPage() : base()
        {
            Map = new MyTasksPageMap();
        }

        public IWebElement MyTasksTitle => Driver.FindElement(By.XPath(Map.MyTasksTitleXPath));
        public IWebElement CompletedLink => Driver.FindElement(By.XPath(Map.CompletedLinkXPath));
        public IWebElement PendingLink => Driver.FindElement(By.XPath(Map.PendingLinkXPath));
        
    }

}
