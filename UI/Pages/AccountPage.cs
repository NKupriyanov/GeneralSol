using Net.Core.Core;
using NLog;
using NUnit.Allure.Attributes;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;


namespace Net.Core.UI.Pages
{
    public class AccountPage : BasePage
    {
        private IWebElement AccountHeader => driver.FindElement (By.ClassName("page-heading"));
        private IWebElement HomePageHeader => driver.FindElement (By.Id("header_logo"));
        private IWebElement LogoutButton => driver.FindElement (By.ClassName("logout"));

        public AccountPage()
        {
            WaitHelper.WaitElement(driver, AccountHeader);
        }

        [AllureStep]
        public HomePage GoToHomePage()
        {
            LogSession.CurrentSession.Info($"Moved to homepage");

            HomePageHeader.Click();
            return new HomePage();
        }

        [AllureStep]
        public LoginPage GoToLogout()
        {
            LogSession.CurrentSession.Info($"Sign out of account");

            LogoutButton.Click();
            return new LoginPage();
        }
    }
}
