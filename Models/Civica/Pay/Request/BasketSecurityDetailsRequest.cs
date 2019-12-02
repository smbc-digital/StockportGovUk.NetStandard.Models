namespace StockportGovUK.NetStandard.Models.Civica.Pay.Request
{
    public class BasketSecurityDetailsRequest : AuthenticatedRequest
    {
        public string BasketReference { get; set; }
    }
}