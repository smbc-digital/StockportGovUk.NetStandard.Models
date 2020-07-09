namespace StockportGovUK.NetStandard.Models.AbandonedVehicle
{
    public class AbandonedVehicleMailModel
    {
        public string Reference { get; set; }
        public StockportGovUK.NetStandard.Models.Addresses.Address StreetInput { get; set; }
    }
}
