namespace StockportGovUK.NetStandard.Models.Civica.Pay.Response
{
    public class RemoveItemResponse
    {
        public bool Success { get; set; }

        public string ResponseCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}