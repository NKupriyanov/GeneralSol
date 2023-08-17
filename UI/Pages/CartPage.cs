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
    public class CartPage : BasePage
    {
        private IWebElement CartSummaryTitle => driver.FindElement(By.XPath("//*[contains(text(),'Shopping-cart summary')]"));
        private IWebElement ChekOutButton => driver.FindElement(By.XPath("//p[@class='cart_navigation clearfix']//a[@title='Proceed to checkout']"));
        private IWebElement CartQuantity => driver.FindElement(By.XPath("//span[@class='ajax_cart_quantity']"));

        public CartPage()
        {
            WaitHelper.WaitElement(driver, CartSummaryTitle);
        }

        [AllureStep]
        public SelectAddressPage ChekOut()
        {
            ChekOutButton.Click();
            LogSession.CurrentSession.Info("ChekOutButton click");
            Browser.Instance.ScreenShot("ChekOutButton click");

            return new SelectAddressPage();
        }

        [AllureStep]
        public string GetProductQuantity()
        {
            var count = CartQuantity.Text;
            LogSession.CurrentSession.Info($"Product Quantity is {count}");
            Browser.Instance.ScreenShot("Product Quantity");
            return count;
        }
    }
}
