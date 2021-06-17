using StockportGovUK.NetStandard.Models.Mail;
using System;

namespace StockportGovUK.NetStandard.Models.Models.GenericReport
{
    public class GenericReportMailModel : BaseMailModel
    {
        public string Reference { get; set; }
        public string Header { get; set; }
        public bool ShowRefNumber { get; set; } = false;
        public string FormText { get; set; }
        public string[] HappensNextContent { get; set; }
        public bool HasNext => String.IsNullOrEmpty(HappensNextContent.ToString()) ? false : true;
        public string LeadingParagraph { get; set; }
        public bool HasLeadingParagraph => String.IsNullOrEmpty(LeadingParagraph) ? false : true;
    }
}
