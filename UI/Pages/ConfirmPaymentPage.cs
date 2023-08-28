using Net.Core.Core;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;



namespace Net.Core.UI.Pages
{
    public class ConfirmPaymentPage : BasePage
    {
        private IWebElement ConfirmOrderButton => driver.FindElement(By.XPath("//*[@class='button btn btn-default button-medium']"));

        public ConfirmPaymentPage()
        {
            WaitHelper.WaitElement(driver, ConfirmOrderButton);
        }

        [AllureStep]
        public CompletePage ConfirmOrder()
        {
            ConfirmOrderButton.Click();
            LogSession.CurrentSession.Info("ConfirmOrderButton click");
            Browser.Instance.ScreenShot("Confirm Order Button click");
            return new CompletePage();
        }
    }
}
