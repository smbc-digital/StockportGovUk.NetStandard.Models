using StockportGovUK.NetStandard.Models.Verint;

namespace StockportGovUK.NetStandard.Models.Models.Uniform
{
    public class BonfireNuisanceServiceRequest
    {
        public string BonfireNuisanceCode { get; set; }
        public string Description { get; set; }
        public string CrmReference { get; set; }
        public Address Property { get; set; }
        public Customer Customer { get; set; }
    }
}