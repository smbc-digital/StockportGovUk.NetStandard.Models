using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.Civica.Pay.Response
{
    public class FullBasketSummaryResponse: BasketSummaryResponse
    {
        public List<BasketItem> BasketItems { get; set; }
    }
}