namespace StockportGovUK.NetStandard.Models.FormBuilder
{
    public class PostPaymentUpdateRequest
    {
        public string Reference { get; set; }

        public EPaymentStatus PaymentStatus { get; set; }
    }
}