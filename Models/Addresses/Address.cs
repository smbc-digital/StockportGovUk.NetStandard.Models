namespace StockportGovUK.NetStandard.Models.Addresses
{
    public class Address
    {        
        public string SelectedAddress { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Town { get; set; }

        public string Postcode { get; set; }

        public string PlaceRef { get; set; }

        public bool IsAutomaticallyFound => SelectedAddress != null;
    }
}