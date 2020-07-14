using StockportGovUK.NetStandard.Models.Mail;

namespace StockportGovUK.NetStandard.Models.Models.TreePreservationOrder
{
    public class TreePreservationOrderMailModel : BaseMailModel
    {
        public string Reference { get; set; }
        public string StreetInput { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
