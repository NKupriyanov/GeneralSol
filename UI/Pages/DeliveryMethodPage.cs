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
    public class DeliveryMethodPage : BasePage
    {
        private IWebElement ContinueButton => driver.FindElement(By.Name("processCarrier"));
        private IWebElement AgreeCheckBox => driver.FindElement(By.Id("uniform-cgv"));
        private IWebElement StepShiping => driver.FindElement(By.XPath("//*[@class='step_current four']"));
        private IWebElement ErrorMessage => driver.FindElement(By.XPath("//p[@class='fancybox-error']"));

        public DeliveryMethodPage()
        {
            WaitHelper.WaitElement(driver, StepShiping);
        }

        [AllureStep]
        public DeliveryMethodPage ContinueWithOutCheckBox()
        {
            ContinueButton.Click();
            LogSession.CurrentSession.Info("ContinueButton click");

            return this;
        }

        [AllureStep]
        public string GetErrorMessage()
        {
            var message = ErrorMessage.Text;
            LogSession.CurrentSession.Info($"Error is - {message}");

            return message;
        }

        [AllureStep]
        public ChoosePaymentPage ContinueWithCheckBox()
        {
            AgreeCheckBox.Click();
            ContinueButton.Click();
            LogSession.CurrentSession.Info("AgreeCheckBox and ContinueButton click");

            return new ChoosePaymentPage();
        }
    }
}
