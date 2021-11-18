using NUnit.Framework;
using Fluxday.Data;
using Fluxday.Pages;
using Fluxday.Maps;


namespace Fluxday.Tests
{
    [TestFixture]    
    public class AuthorizationPageTests : BaseTests
    {         
        private static string wrongTestData = TestDataGenerator.GenerateRandomStringForTest(10);
        private HeaderNav headerNav = new HeaderNav();
        private AuthorizationPage authorizationPage = new AuthorizationPage();

        [Test]
        [Description ("TestCase(WI-1), Processed (2021-08-28), Updated(2021-08-29)")]
        public void  VerifyLoginToAppAsAdmin()
        {              
            //var  authorizationPage = new AuthorizationPage();
            authorizationPage
               .LoginAs<AuthorizationPage>(TestData.adminUser,TestData.password);          
            Assert.That(headerNav.FluxdayLogo.Displayed);            
        }

        [Test]
        [Description("TestCase(WI-2), Processed (2021-08-29), Updated(2021-08-29)")]
        public void VerifyLoginToAppAsTeamLead()
        {             
            //var authorizationPage = new AuthorizationPage();
            authorizationPage
                .LoginAs<AuthorizationPage>(TestData.teamLead, TestData.password);
            Assert.That(headerNav.FluxdayLogo.Displayed);
        }

        [Test]
        [Description("TestCase(WI-3), Processed (2021-08-29), Updated(2021-08-29)")]
        public void LoginToAppWithIncorrectPassword()
        {          
            //var authorizationPage = new AuthorizationPage();
            authorizationPage
               .LoginAs<AuthorizationPage>(TestData.teamLead, wrongTestData);
            Assert.That(authorizationPage.UnsuccesfullLoginAlert.Displayed);
        }

        [Test]
        [Description("TestCase(WI-4), Processed (2021-08-29), Updated(2021-08-29)")]
        public void VerifyCheckBoxRememberMe()
        {           
            //var authorizationPage = new AuthorizationPage();
            authorizationPage
               .TypeTextToTextField<AuthorizationPage>(authorizationPage.EmailField, TestData.teamLead)
               .TypeTextToTextField<AuthorizationPage>(authorizationPage.PasswordField, TestData.password)
               .CheckRememberMeCheckbox()
               .SubmitLogin()
               .ReturnToAuthorizationPage()
               .TypeTextToTextField<AuthorizationPage>(authorizationPage.EmailField,TestData.teamLead)
               .SubmitLogin();
            Assert.That(headerNav.FluxdayLogo.Displayed);
        }

    }
}