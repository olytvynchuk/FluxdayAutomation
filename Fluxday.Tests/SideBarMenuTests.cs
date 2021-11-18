using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.IO;
using System;
using Fluxday.Data;
using System.Threading;
using Framework.SeleniumUtils;
using Fluxday.Maps;
using Fluxday.Pages;

using static Fluxday.Pages.Pages;

namespace Fluxday.Tests
{
    public class SideBarMenuTests : BaseTests
    {  
        [Test]
        public void VerifyNavigationToFluxdayMyTasksPageFluxday()
        {
            var authorizationPage = new AuthorizationPage();
           // var sideBarMenuPage = new SideBarMenu();
            authorizationPage
                .LoginAs<AuthorizationPage>(TestData.adminUser, TestData.password)
                .ClickOnButton<HomePage>(SideBarMenuMap.MyTasksLink)

            //sideBarMenuPage
                .GoToMyTasksPage();            
            Assert.That(MyTasks.MyTasksTitle.Displayed);
        }

    }
}
