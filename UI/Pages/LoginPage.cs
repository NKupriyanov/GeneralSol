using Core.Configuration;
using Net.Core.Core;
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

        public LoginPage()
        {
            WaitHelper.WaitElement(driver, LoginButtom);
        }

        [AllureStep]
        public LoginPage OpenPage()
        {
            LogSession.CurrentSession.Info($"Navigate to URL {AppConfiguration.Browser.Url}");

            Browser.Instance.NavigateToUrl(AppConfiguration.Browser.Url);
            return this;
        }

        [AllureStep]
        public AccountPage Login()
        {
            UserMailInput.SendKeys(AppConfiguration.Browser.Login);
            PasswordInput.SendKeys(AppConfiguration.Browser.Password);
            SubmitLoginButtom.Click();

            return new AccountPage();
        }
    }
}
