using Framework.SeleniumUtils;
using OpenQA.Selenium;

namespace Fluxday.Maps
{
    public class SideBarMenuMap
    {    
        public string QuickSearchPlaceholderXPath => "//input[@id='search_keyword']";
        public string DashboardLinkXPath => "//a[@href= '/' and text()]";
        public string MyTasksLinkXPath => "//div[@class='show-for-small']//a[@href='/tasks']";
        public string DepartmentsLinkXPath => "//div[@class='show-for-small']//a[@href='/projects']";
        public string TeamLinkXPath => "//div[@class='show-for-small']//a[@href='/teams']";
        public string UsersLinkXPath => "//div[@class='show-for-small']//a[@href='/users']";
        public string OkrLinkXPath => "//div[@class='show-for-small']//a[@href='/okrs']";
        public string ReportsLinkXPath => "//div[@class='show-for-small']//a[@href='/reports/worklogs']";
        public string AdminUserLinkXPath => "//ul[@class='user-links side-nav sidebar-links']//a[@href='/users/FT1']";
        public string LogOutLinkXPath => "//ul[@class='user-links side-nav sidebar-links']//a[@data-method='delete']";


        

    }

}
