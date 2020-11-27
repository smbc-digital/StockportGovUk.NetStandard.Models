using StockportGovUK.NetStandard.Models.Mail;

namespace StockportGovUK.NetStandard.Models.Models.GenericReport
{
    public class GenericReportMailModel : BaseMailModel
    {
        public string Reference { get; set; }
        public bool ShowRefNumber { get; set; } = false;
        public string FormText { get; set; }
        public bool HasNext { get; set; } = false;
        public string[] HappensNextContent { get; set; }
    }
}
