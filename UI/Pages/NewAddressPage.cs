using Net.Core.Core;
using Net.Core.UI.Models;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTests.Core.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.UI.Pages
{
    public class NewAddressPage : BasePage
    {
        private IWebElement AddressPageTitle =>
        driver.FindElement(By.XPath("//*[@class='info-title']"));
        private IWebElement FirstNameInput => driver.FindElement(By.Id("firstname"));
        private IWebElement LastNameInput => driver.FindElement(By.Id("lastname"));
        private IWebElement AddressInput => driver.FindElement(By.Id("address1"));
        private IWebElement PostalCodeInput => driver.FindElement(By.Id("postcode"));
        private IWebElement CityInput => driver.FindElement(By.Id("city"));
        private IWebElement CountrySelect => driver.FindElement(By.XPath("//*[@id='id_country']"));
        private IWebElement MobilePhoneInput => driver.FindElement(By.Id("phone_mobile"));
        private IWebElement AddresAlias => driver.FindElement(By.XPath("//*[@id='alias']"));
        private IWebElement StateSelect => driver.FindElement(By.XPath("//*[@id='id_state']"));
        private IWebElement SaveAndContinueButton => driver.FindElement(By.Id("submitAddress"));

        public NewAddressPage()
        {
            WaitHelper.WaitElement(driver, AddressPageTitle);
        }
        [AllureStep]
        public SelectAddressPage InputNewAddress()
        {
            var customer = DataGenerator.GetAddressFormModel();
            InputAddress(customer);
            return new SelectAddressPage();
        }

        [AllureStep]
        private void InputAddress(AddressFormModel customer)
        {
            LogSession.CurrentSession.Info($"Input User Addres data: {customer}");
            FirstNameInput.SendKeys(customer.FirstName);
            LastNameInput.SendKeys(customer.LastName);
            PostalCodeInput.SendKeys(customer.PostalCode);
            AddressInput.SendKeys(customer.Address);
            CityInput.SendKeys(customer.City);
            MobilePhoneInput.SendKeys(customer.MobilePhone);
            AddresAlias.SendKeys(customer.AddressAlias);
            SelectCountry();
            SelectState();
            SaveAndContinue();
        }

        private void SelectCountry()
        {
            var select = new SelectElement(CountrySelect);
            select.SelectByValue("216");
        }

        private void SelectState()
        {
            var select = new SelectElement(StateSelect);
            select.SelectByValue("326");
        }

        [AllureStep]
        private void SaveAndContinue()
        {
            SaveAndContinueButton.Click();
            LogSession.CurrentSession.Info("SaveAndContinueButton click");
        }
    }
}
