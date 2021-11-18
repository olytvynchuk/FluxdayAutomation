using Fluxday.Maps;
using Framework.SeleniumUtils;
using OpenQA.Selenium;



namespace Fluxday.Pages
{
    public class AuthorizationPage : SideBarMenu
    {     

        public IWebElement EmailField => Driver.FindElement(By.Id(Map.UserNameFieldId));
        public IWebElement PasswordField => Driver.FindElement(By.Id(Map.PasswordFieldId));
        public IWebElement RememberMeCheckbox => Driver.FindElement(By.XPath(Map.RememberMeCheckboxXPath));
        public IWebElement RememberMeLabel => Driver.FindElement(By.XPath(Map.RememberMeLabelXPath));
        public IWebElement SignInButton => Driver.FindElement(By.XPath(Map.SubmitButtonXPath));
        public IWebElement UnsuccesfullLoginAlert => Driver.FindElement(By.XPath(Map.UnsuccesfullLoginAlertXPath));

        public AuthorizationPageMap Map => new AuthorizationPageMap();
        
        public HomePage SubmitLogin()
        {
            ClickOnButton<AuthorizationPage>(SignInButton);//SignInButton.Click();
            return new HomePage();
        }

        public AuthorizationPage CheckRememberMeCheckbox() 
        {
            RememberMeCheckbox.Click();
            return this;
        }

        //public HomePage LoginAs(string userName, string password)
        //{            
        //    TypeTextToTextField<AuthorizationPage>(EmailField, userName);
        //    TypeTextToTextField<AuthorizationPage>(PasswordField, password);
        //    return SubmitLogin();
        //}

        public T LoginAs<T>(string userName, string password) where T : class, new()
        {
            TypeTextToTextField<AuthorizationPage>(EmailField, userName);
            TypeTextToTextField<AuthorizationPage>(PasswordField, password);
            SubmitLogin();
            return new();
        }
    }
}
