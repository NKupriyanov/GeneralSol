using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;


namespace Net.Core.UI.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        public BasePage()
        {
            driver = Browser.Instance.Driver;
        }

    }
}
