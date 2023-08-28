using Net.Core.Core;
using NLog;
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
    public class BuyProductForm : BasePage
    {
        private IWebElement ContinuePurchasesButton => driver.FindElement(By.XPath("//*[contains(@class,'exclusive-medium')]//i[contains(@class,'chevron')]"));
        private IWebElement CheckoutButton => driver.FindElement(By.CssSelector("#layer_cart [href*='order']"));

        public BuyProductForm()
        {
            WaitHelper.WaitElement(driver, CheckoutButton);
        }

        public void ContinuePurchases()
        {
            LogSession.CurrentSession.Info("Continue shopping selected");

            WaitHelper.WaitElement(driver,() => ContinuePurchasesButton.Displayed);
            ContinuePurchasesButton.Click();
            Browser.Instance.ScreenShot("Continue Button");
        }

        public CartPage GoToCart()
        {
            LogSession.CurrentSession.Info("Purchases completed went to cart");

            WaitHelper.WaitElement(driver,() => CheckoutButton.Displayed);
            CheckoutButton.Click();
            Browser.Instance.ScreenShot("Checkout Button");

            return new CartPage();
        }
    }
}
