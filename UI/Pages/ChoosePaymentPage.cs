using Net.Core.Core;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.UI.Pages
{
    public class ChoosePaymentPage : BasePage
    {
        private IWebElement ErrorMessage => driver.FindElement(By.XPath("//p[@class='alert alert-warning']"));

        public ChoosePaymentPage()
        {
            WaitHelper.WaitElement(driver, ErrorMessage);
        }

        [AllureStep]
        public string GetErrorMessage()
        {
            var message = ErrorMessage.Text;
            LogSession.CurrentSession.Info($"Error is - {message}");

            return message;
        }
    }
}
