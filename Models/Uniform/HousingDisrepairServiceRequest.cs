using StockportGovUK.NetStandard.Models.Verint;

namespace StockportGovUK.NetStandard.Models.Uniform
{
    public class HousingDisrepairServiceRequest
    {
        public string Description { get; set; }
        public string CrmReference { get; set; }
        public Address Property { get; set; }
        public Customer Customer { get; set; }
    }
}
