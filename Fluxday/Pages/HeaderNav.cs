using Fluxday.Maps;
using Framework.SeleniumUtils;
using OpenQA.Selenium;

namespace Fluxday.Pages
{
    public class HeaderNav
    {
        public readonly HeaderNavMap HeaderMap;
        public HeaderNav()
        {
            HeaderMap = new HeaderNavMap();
        }
        public IWebElement FluxdayLogo => Driver.FindElement(By.XPath(HeaderMap.AppLogoXPath));        
        public IWebElement AddNewTaskHeaderLink => Driver.FindElement(By.XPath(HeaderMap.AddNewTaskHeaderLinkXPath));       
       

    }
}
