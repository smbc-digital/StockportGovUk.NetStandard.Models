using System.Xml.Serialization;

namespace StockportGovUK.NetStandard.Models.RevsAndBens
{
    [XmlRoot("CtaxDetails")]
    public class CouncilTaxAccountSummary
    {
        [XmlElement("FinancialDetails")]
        public FinancialDetails FinancialDetails { get; set; }
    }

    [XmlRoot("FinancialDetails")]
    public class FinancialDetails
    {
        [XmlElement("RecYrTotals")]
        public RecievedYearTotal RecievedYearTotal { get; set; }
    }

    [XmlRoot("RecYrTotals")]
    public class RecievedYearTotal
    {
        [XmlElement("TotalCharge")]
        public string TotalCharge { get; set; }

        [XmlElement("TotalPayments")]
        public string TotalPayments { get; set; }

        [XmlElement("TotalBenefits")]
        public string TotalBenefits { get; set; }

        [XmlElement("BalanceOutstanding")]
        public string BalanceOutstanding { get; set; }
    }
}