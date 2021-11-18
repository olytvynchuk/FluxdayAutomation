using Framework.SeleniumUtils;
using OpenQA.Selenium;

namespace Fluxday.Maps
{
    public class AuthorizationPageMap
    {
        public string UserNameFieldId => "user_email";
        public string PasswordFieldId => "user_password";
        public string SubmitButtonXPath => "//button[@class='btn-login']";
        public string RememberMeCheckboxXPath => "//input[@id='user_remember_me']";
        public string  RememberMeLabelXPath => "//*[text()='Remember_me']";
        public string UnsuccesfullLoginAlertXPath =>"//div[contains (@class,'alert')]";        

    }
}