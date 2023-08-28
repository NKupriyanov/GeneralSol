
using Allure.Commons;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;

namespace Net.Core.Tests.UI
{
    [AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    public class BaseTest
    {
        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Browser.Instance.ScreenShot("Failscreen");
            }
            else
            {
                Browser.Instance.ScreenShot("Pass_screen");
            }

            Browser.Instance.CloseBrowser();
        }
    }
}