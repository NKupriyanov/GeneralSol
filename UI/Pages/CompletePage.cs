using Net.Core.Core;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;


namespace Net.Core.UI.Pages
{
    public class CompletePage : BasePage
    {
        private IWebElement BackToOrdersButton => driver.FindElement(By.XPath("//*[@title='Back to orders']"));

        public CompletePage()
        {
            WaitHelper.WaitElement(driver, BackToOrdersButton);
        }

        [AllureStep]
        public HomePage BackHome()
        {
            BackToOrdersButton.Click();
            LogSession.CurrentSession.Info("BackToOrdersButton click");
            Browser.Instance.ScreenShot("Back To Orders Button click");

            return new HomePage();
        }
    }
}
