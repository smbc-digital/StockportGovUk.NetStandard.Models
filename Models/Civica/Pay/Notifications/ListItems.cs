using System.Xml.Serialization;

namespace StockportGovUK.NetStandard.Models.Civica.Pay.Notifications
{

    [XmlRoot(ElementName = "ListItems", Namespace = "http://schemas.datacontract.org/2004/07/epPaymentNotification")]
    public class ListItems
    {
      	[XmlRoot(ElementName="ListItems", Namespace="http://schemas.datacontract.org/2004/07/epPaymentNotification")]
        public List<ListItem> ListItem { get; set; }
    }

}