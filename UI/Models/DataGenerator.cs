using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.UI.Models
{
    public static class DataGenerator
    {
        public static AddressFormModel GetAddressFormModel()
        {
            var faker = new Faker();

            return new AddressFormModel
            {
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName(),
                Address = faker.Address.StreetAddress(),
                PostalCode = "00001",
                City = faker.Address.City(),
                MobilePhone = faker.Phone.PhoneNumber(),
                AddressAlias = faker.Random.Word(),
            };
        }
    }
}
