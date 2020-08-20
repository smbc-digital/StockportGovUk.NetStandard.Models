using StockportGovUK.NetStandard.Models.Mail;

namespace StockportGovUK.NetStandard.Models.FlyTipping
{
    public class FlyPostingMailModel : BaseMailModel
    {
        public string Reference { get; set; }
        public string StreetInput { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
