using Net.Core.UI.Pages;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.Tests.UI
{
    public class AddressTest : BaseTest
    {
        [Test]
        public void GoAddressInputTest()
        {
            new LoginPage()
               .OpenPage()
               .Login()
               .GoToAddressPage()
               .UpdateAddress()
               .InputNewAddress();
        }
    }
}
