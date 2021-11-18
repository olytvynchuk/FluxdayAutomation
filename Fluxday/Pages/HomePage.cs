using Fluxday.Maps;
using Framework.SeleniumUtils;
using OpenQA.Selenium;

namespace Fluxday.Pages
{
    public class HomePage: SideBarMenu
    {
        private readonly HomePageMap Map;

        public HomePage() : base()
        {
            Map = new HomePageMap();
        }

        public IWebElement Entries => Driver.FindElement(By.XPath(Map.EntriesXPath));
        public IWebElement TaskForTitle => Driver.FindElement(By.XPath(Map.TaskForTitleXPath));
        public IWebElement Week => Driver.FindElement(By.XPath(Map.WeekXPath));
        public IWebElement Month => Driver.FindElement(By.XPath(Map.MonthXPath));
        public IWebElement AddLogRightButton => Driver.FindElement(By.XPath(Map.AddLogRightButtonXPath));
        public IWebElement AddLogLeftButton => Driver.FindElement(By.XPath(Map.AddLogLeftButtonXPath));
        public IWebElement PreviosIcon => Driver.FindElement(By.XPath(Map.PreviosIconXPath));
        public IWebElement NextIcon => Driver.FindElement(By.XPath(Map.NextIconXPath));

        public HomePage ClickOnNextIconButton()
        {
            ClickOnButton<HomePage>(NextIcon);
            return this;
        }

    }
}
