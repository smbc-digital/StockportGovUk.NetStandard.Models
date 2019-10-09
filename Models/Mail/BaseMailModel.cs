namespace StockportGovUK.NetStandard.Models.Models.Mail
{
    public class BaseMailModel
    {
        public string RecipientAddress { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }
    }
}
