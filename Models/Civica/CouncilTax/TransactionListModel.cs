using System.Collections.Generic;
using System.Xml.Serialization;
using StockportGovUK.NetStandard.Models.RevsAndBens;

namespace StockportGovUK.NetStandard.Models.Civica.CouncilTax
{
    [XmlRoot(ElementName = "TranList")]
    public class TransactionListModel
    {
        [XmlElement(ElementName = "Transaction")]
        public List<Transaction> Transaction { get; set; }
    }
}

