using StockportGovUK.NetStandard.Models.Mail;

namespace StockportGovUK.NetStandard.Models.Models.BookSiteInspection
{
    public class BookSiteInspectionMailModel : BaseMailModel
    {
        public string Reference { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
        public bool HasCovidWarning { get; set; } = false;
    }
}
