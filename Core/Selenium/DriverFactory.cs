using Core.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumTests.Core.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium
{
    public class DriverFactory
    {
        public static IWebDriver GetChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();

            if(AppConfiguration.Browser.Hedless) options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            options.AddArgument("incognito");
            options.AddArgument("--start-maximized");
            
            var driver = new ChromeDriver(options);
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);

            return driver;
        }

        public static IWebDriver GetFirefoxDriver()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("--headless");

            return new FirefoxDriver(options);
        }
    }
}
