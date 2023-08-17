using NLog;
using NUnit.Allure.Attributes;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;
using Net.Core.Core;

namespace Net.Core.UI.Pages
{
    public class HomePage : BasePage
    {
        private IWebElement InfoBlock => driver.FindElement (By.Id("cmsinfo_block"));
        private IWebElement AddTShirts => driver.FindElement (By.XPath("//*[@class='product-container']//img[contains(@class,'replace-2x')][contains(@src,'tshirts')][1]"));
        private IWebElement AddBlouse => driver.FindElement (By.XPath("//*[@class='product_img_link'][.//*[@title='Blouse']][1]"));
        private IWebElement AddDress => driver.FindElement (By.XPath("//*[@class='product_img_link'][.//*[@title='Printed Dress']][1]"));
        private IWebElement EnglishLanguage => driver.FindElement (By.XPath("//*[contains(text(),'English')]"));
        private IWebElement LanguageSelector => driver.FindElement (By.XPath("//div[@id='languages-block-top']"));
        private IWebElement CartPageButton => driver.FindElement(By.XPath("//*[@title='View my shopping cart']"));
        private IWebElement QuickAddTShirts => driver.FindElement(By.XPath("//*[@data-id-product='1'][1]"));
        private IWebElement QuickAddBlouse => driver.FindElement(By.XPath("//*[@data-id-product='2'][1]"));
        private IWebElement QuickAddDress => driver.FindElement(By.XPath("//*[@data-id-product='3'][1]"));
        
        [AllureStep]
        public CartPage AddProducts()
        {
            ActivateQuickViewTShirt();
            QuickAddTShirts.Click();
            new BuyProductForm().ContinuePurchases();
            LogSession.CurrentSession.Info($"Added TShirts");
            Browser.Instance.ScreenShot("Added TShirts");

            ActivateQuickViewBlouse();
            QuickAddBlouse.Click();
            new BuyProductForm().ContinuePurchases();
            LogSession.CurrentSession.Info($"Added Blouse");
            Browser.Instance.ScreenShot("Added Blouse");

            ActivateQuickViewDress();
            QuickAddDress.Click();
            new BuyProductForm().GoToCart();
            LogSession.CurrentSession.Info($"Added Dress");
            Browser.Instance.ScreenShot("Added Dress");

            return new CartPage();
        }
        
        public HomePage()
        {
            WaitHelper.WaitElement(driver, InfoBlock);
        }

        [AllureStep]
        public void ActivateQuickViewTShirt()
        {
            LogSession.CurrentSession.Info($"TShirts QuickView activated successfully");

            ActivateQuickView(AddTShirts);
        }

        [AllureStep]
        public void ActivateQuickViewBlouse()
        {
            LogSession.CurrentSession.Info($"Blouse QuickView activated successfully");

            ActivateQuickView(AddBlouse);
        }

        [AllureStep]
        public void ActivateQuickViewDress()
        {
            LogSession.CurrentSession.Info($"Dress QuickView activated successfully");

            ActivateQuickView(AddDress);
        }

        [AllureStep]
        public void ActivateQuickView(IWebElement product)
        {
            new Actions(driver)
                .MoveToElement(product)
                .Perform();
            Browser.Instance.ScreenShot("Quick View Product");
        }

        [AllureStep]
        public void LangagueSelect()
        {
            LogSession.CurrentSession.Info($"Language selection done");

            LanguageSelector.Click();
            Browser.Instance.ScreenShot("Language selection");
            EnglishLanguage.Click();
        }

        [AllureStep]
        public CartPage GoCartPage()
        {
            LangagueSelect();
            CartPageButton.Click();
            LogSession.CurrentSession.Info($"CartPageButton click");
            Browser.Instance.ScreenShot("CartPage Button click");

            return new CartPage();
        }
    }
}
