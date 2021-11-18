using Framework.SeleniumUtils;
using OpenQA.Selenium;

namespace Fluxday.Maps
{
    public class HomePageMap
    {
        public string EntriesXPath => "//div[@class='title'and text()='Entries']";
        public string TaskForTitleXPath => "//div[@class='left' and contains(text(),'Tasks')]";
        public string WeekXPath => "//a[@href='#week']";
        public string MonthXPath => "//a[@href='#month']";
        public string AddLogRightButtonXPath => "//a[@class='btn btn-sec right']";
        public string AddLogLeftButtonXPath => "//a[@class='btn btn-sec left']";
        public string PreviosIconXPath => "//div[@class='prev icon']";
        public string NextIconXPath => "//div[@class='next icon']";
    }
}
