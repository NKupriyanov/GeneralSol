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
    public class SelectAddressPage : BasePage
    {
        private IWebElement AddressPageTitle => driver.FindElement(By.CssSelector("h1:first-child"));
        private IWebElement ContinueButton => driver.FindElement(By.XPath("//*[@name='processAddress']"));
        private IWebElement UpdateAddresseButton => driver.FindElement(By.XPath("//*[@class='address_update']//a[@title='Update']"));

        public SelectAddressPage()
        {
            WaitHelper.WaitElement(driver, AddressPageTitle);
        }

        [AllureStep]
        public NewAddressPage UpdateAddress()
        {
            UpdateAddresseButton.Click();
            LogSession.CurrentSession.Info("UpdateAddresseButton click");
            Browser.Instance.ScreenShot("Update Addresse Button click");

            return new NewAddressPage();
        }

        [AllureStep]
        public DeliveryMethodPage Continue()
        {
            ContinueButton.Click();
            LogSession.CurrentSession.Info("ContinueButton click");
            Browser.Instance.ScreenShot("Continue Button click");

            return new DeliveryMethodPage();
        }
    }
}
