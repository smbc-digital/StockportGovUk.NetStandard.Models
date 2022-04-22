﻿using System.Xml.Serialization;

namespace StockportGovUK.NetStandard.Models.Civica.CouncilTax
{
    [XmlRoot("Documents")]
    public class CouncilTaxDocumentsResponse
    {
        [XmlArrayItem("Document")]
        public CouncilTaxDocumentReference[] DocumentList { get; set; }
    }

    [XmlRoot("Document")]
    public class CouncilTaxDocumentReference
    {
        [XmlElement("DocumentName")]
        public string DocumentName { get; set; }

        [XmlAttribute("datecreated")]
        public string DateCreated { get; set; }

        [XmlAttribute("downloaded")]
        public string Downloaded { get; set; }

        [XmlAttribute("id")]
        public string DocumentId { get; set; }

        [XmlAttribute("type")]
        public string DocumentType { get; set; }

        [XmlElement("Ref1")]
        public string AccountReference { get; set; }

        [XmlElement("Module")]
        public string Module { get; set; }
    }
}
