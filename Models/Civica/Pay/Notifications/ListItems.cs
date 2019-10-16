using System.Xml.Serialization;

namespace StockportGovUK.NetStandard.Models.Civica.Pay.Notifications
{

    [XmlRoot(ElementName = "ListItems", Namespace = "http://schemas.datacontract.org/2004/07/epPaymentNotification")]
    public class ListItems
    {
        [XmlElement(ElementName = "ListItem", Namespace = "http://schemas.datacontract.org/2004/07/epPaymentNotification")]
        public ListItem ListItem { get; set; }
    }

}