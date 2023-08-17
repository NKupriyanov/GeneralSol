using Core.Configuration;
using Net.Core.Core;
using Net.Core.UI.Models;
using NLog;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;

namespace Net.Core.UI.Pages
{
    public class LoginPage : BasePage
    {
        private IWebElement UserMailInput => driver.FindElement(By.Id("email"));
        private IWebElement PasswordInput => driver.FindElement(By.Id("passwd"));
        private IWebElement SubmitLoginButtom => driver.FindElement(By.Id("SubmitLogin"));
        private IWebElement LoginButtom => driver.FindElement(By.ClassName("login"));
        private IWebElement ErrorMessage => driver.FindElement(By.XPath("//*[@class='alert alert-danger'][.//li[contains(text(),'Authentication failed')]]"));
        
        public LoginPage()
        {

        }

        [AllureStep]
        public LoginPage OpenPage()
        {
            LogSession.CurrentSession.Info($"Navigate to URL {AppConfiguration.Browser.Url}");

            Browser.Instance.NavigateToUrl(AppConfiguration.Browser.Url);
            WaitHelper.WaitElement(driver, LoginButtom);
            Browser.Instance.ScreenShot("LoginPage loaded");
            return this;
        }

        [AllureStep]
        public AccountPage Login()
        {
            var user = DataGenerator.GetStandartUser();
            UserMailInput.SendKeys(user.UserName);
            PasswordInput.SendKeys(user.Password);
            SubmitLoginButtom.Click();
            Browser.Instance.ScreenShot("SubmitLoginButtom Click");

            return new AccountPage();
        }

        [AllureStep]
        public LoginPage LoginWithError()
        {
            var user = DataGenerator.GetFakeUser();
            UserMailInput.SendKeys(user.UserName);
            PasswordInput.SendKeys(user.Password);
            SubmitLoginButtom.Click();

            return this;
        }

        [AllureStep]
        public string GetErrorMesage()
        {
            Browser.Instance.ScreenShot("Error message");
            return ErrorMessage.Text;
        }
    }

}
