namespace StockportGovUK.NetStandard.Models.Models.Verint
{
    public class Organisation
    {
        public string Reference { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

        public SocialContact[] SocialContacts { get; set; }
    }
}
