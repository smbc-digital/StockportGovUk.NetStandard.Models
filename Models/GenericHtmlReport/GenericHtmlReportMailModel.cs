using StockportGovUK.NetStandard.Models.Mail;

namespace StockportGovUK.NetStandard.Models.Models.GenericHtmlReport
{
    public class GenericHtmlReportMailModel : BaseMailModel
    {
        public string Reference { get; set; }
        public string Header { get; set; }
        public bool ShowRefNumber { get; set; } = false;
        public string FormText { get; set; }
    }
}
