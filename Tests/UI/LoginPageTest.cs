using Net.Core.UI.Pages;
using OpenQA.Selenium;
using SeleniumTests.Core.Selenium;

namespace Net.Core.Tests.UI
{
    public class LoginPageTest : BaseTest
    {
        [Test]
        public void Login()
        {
            Assert.DoesNotThrow(() =>
            {
                new LoginPage()
                    .OpenPage()
                    .Login();
            });
        }

        [Test]
        public void LoginAndLogOut()
        {
            Assert.DoesNotThrow(() =>
            {
                new LoginPage()
                    .OpenPage()
                    .Login()
                    .GoToLogout();
            });
        }

        [Test]
        public void ErrorLogin()
        {
            var expectedMessage = "There is 1 error\r\nAuthentication failed.";
            
            var message = new LoginPage()
                .OpenPage()
                .LoginWithError()
                .GetErrorMesage();
            
            Assert.That(message, Is.EqualTo(expectedMessage));
        }
    }
}
