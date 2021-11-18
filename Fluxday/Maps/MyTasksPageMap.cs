using Framework.SeleniumUtils;
using OpenQA.Selenium;

namespace Fluxday.Maps
{
    public class MyTasksPageMap
    {
        public string MyTasksTitleXPath = "//div[@class='title']";
        public string CompletedLinkXPath = "//a[@href='#completed']";
        public string PendingLinkXPath = "//a[@href='#penging']";      
    }
}
