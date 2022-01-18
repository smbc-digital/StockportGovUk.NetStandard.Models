namespace StockportGovUK.NetStandard.Models.Civica.Pay.Response
{
    public class CreateImmediateBasketResponse : CreateBasketResponse
    {
        public string ErrorSummary { get; set; }

        public dynamic FieldErrors { get; set; }
    }
}