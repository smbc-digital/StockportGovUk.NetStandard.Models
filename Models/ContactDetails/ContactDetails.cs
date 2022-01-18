using StockportGovUK.NetStandard.Models.Addresses;

namespace StockportGovUK.NetStandard.Models.ContactDetails
{
    public class ContactDetails
    {
        public Address Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
    }
}