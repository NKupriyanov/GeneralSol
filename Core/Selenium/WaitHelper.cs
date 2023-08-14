﻿using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SeleniumTests.Core.Selenium
{
    public class WaitHelper
    {
        public static void WaitElement(IWebDriver driver, By by, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElement(by));
        }

        public static void WaitElementWithTitle(IWebDriver driver, By by, string text, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElement(by).Text.ToLower() == text.ToLower());
        }

        public static void WaitElements(IWebDriver driver, By by, int count, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElements(by).Count == count);
        }
        public static void WaitElement(IWebDriver driver, IWebElement element, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(d => element);
        }
        public static void WaitElement(IWebDriver driver, Func<bool> condition, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(d => condition.Invoke());
        }

    }
}
