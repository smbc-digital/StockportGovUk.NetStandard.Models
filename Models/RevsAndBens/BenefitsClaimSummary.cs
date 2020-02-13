using System.Xml.Serialization;

namespace StockportGovUK.NetStandard.Models.RevsAndBens
{
    public class BenefitsClaimSummary
    {
        [XmlAttribute("PersonName")]
        public string PersonName { get; set; }

        [XmlAttribute("ClaimNumber")]
        public string Number { get; set; }

        [XmlAttribute("ClaimPlaceRef")]
        public string PlaceReference { get; set; }

        [XmlAttribute("ClaimStatus")]
        public string Status { get; set; }

        [XmlAttribute("PersonType")]
        public string PersonType { get; set; }

        [XmlElement("HBClaimAddress")]
        public string Address { get; set; }
    }
}