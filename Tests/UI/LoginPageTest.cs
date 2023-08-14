using Net.Core.UI.Pages;

namespace Net.Core.Tests.UI
{
    public class LoginPageTest : BaseTest
    {
        [Test]
        public void Login()
        {
            Assert.DoesNotThrow(() =>
            {
                new LoginPage().Login();
            });
        }
    }

}
