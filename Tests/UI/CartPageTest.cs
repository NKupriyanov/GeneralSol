using Net.Core.UI.Pages;

namespace Net.Core.Tests.UI
{
    public class CartPageTest : BaseTest
    {
        [Test]
        public void AddProducts()
        {
            var count = new LoginPage()
                .OpenPage()
                .Login()
                .GoToHomePage()
                .AddProducts()
                .GetProductQuantity();

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.Not.Null);
                Assert.That(count, Is.EqualTo("3"));
            });
        }

        [Test]
        public void CheckErrorOnDelivery()
        {
            var expectedMessage = "You must agree to the terms of service before continuing.";

            var message = new LoginPage()
                .OpenPage()
                .Login()
                .GoToHomePage()
                .AddProducts()
                .ChekOut()
                .Continue()
                .ContinueWithOutCheckBox()
                .GetErrorMessage();

            Assert.That(message, Is.EqualTo(expectedMessage));
        }
        
        [Test]
        public void BuyProducts()
        {
            new LoginPage()
                .OpenPage()
                .Login()
                .GoToHomePage()
                .AddProducts()
                .ChekOut()
                .Continue()
                .ContinueWithCheckBox()
                .SelectBankTransfer()
                .ConfirmOrder()
                .BackHome();
        }
    }
}
