using Net.Core.Core;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;

namespace Net.Core.UI.Pages
{
    public class ChoosePaymentPage : BasePage
    {
        private IWebElement ErrorMessage => driver.FindElement(By.XPath("//p[@class='alert alert-warning']"));
        private IWebElement BankTransferButton => driver.FindElement(By.ClassName("bankwire"));

        public ChoosePaymentPage()
        {
            WaitHelper.WaitElement(driver, BankTransferButton);
        }

        [AllureStep]
        public string GetErrorMessage()
        {
            var message = ErrorMessage.Text;
            LogSession.CurrentSession.Info($"Error is - {message}");

            return message;
        }
        
        [AllureStep]
        public ConfirmPaymentPage SelectBankTransfer()
        {
            BankTransferButton.Click();
            LogSession.CurrentSession.Info("BankTransferButton click");

            return new ConfirmPaymentPage();
        }
    }
}
