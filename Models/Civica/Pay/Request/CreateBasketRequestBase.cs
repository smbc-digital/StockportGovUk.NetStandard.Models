namespace StockportGovUK.NetStandard.Models.Civica.Pay.Request
{
      public class CreateBasketRequestBase
      {
            public string CallingAppIdentifier { get; set; }

            public string CustomerID { get; set; }

            public string ApiPassword { get; set; }

            public string ReturnURL { get; set; }

            public string CallingAppTranReference { get; set; }

      }
}