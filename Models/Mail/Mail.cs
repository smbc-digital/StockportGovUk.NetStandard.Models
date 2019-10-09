using StockportGovUK.NetStandard.Models.Enums;

namespace StockportGovUK.NetStandard.Models.Models.Mail
{
    public class Mail 
    {
        public string Payload { get; set; }

        public EMailTemplate Template { get; set; }
    }
}
