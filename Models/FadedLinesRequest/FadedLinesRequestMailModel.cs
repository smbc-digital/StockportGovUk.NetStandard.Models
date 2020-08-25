using StockportGovUK.NetStandard.Models.Mail;

namespace StockportGovUK.NetStandard.Models.FadedLinesRequest
{
    public class FadedLinesRequestMailModel : BaseMailModel
    {
        public string Reference { get; set; }
        public string StreetInput { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
