using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.UI.Models
{
    public class AddressFormModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MobilePhone { get; set; }
        public string AddressAlias { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public override string? ToString()
        {
            return $"FirstName: {FirstName}"
                + $"LastName: {LastName}"
                + $"PostalCode: {PostalCode}"
                + $"Address: {Address}"
                + $"City: {City}"
                + $"MobilePhone: {MobilePhone}"
                + $"AddressAlias: {AddressAlias}";
        }
    }
}
