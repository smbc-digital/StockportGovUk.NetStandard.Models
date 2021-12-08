using StockportGovUK.NetStandard.Models.Addresses;
using StockportGovUK.NetStandard.Models.ContactDetails;

namespace StockportGovUk.NetStandard.Models.ParkingEnforcement
{
    public class ParkingEnforcementRequest
    {
        public bool IsARestrictedArea { get; set; }

        public ContactDetails ContactDetails { get; set; }

        public Street Street { get; set; }

        public string FurtherDetails { get; set; }
    }
}