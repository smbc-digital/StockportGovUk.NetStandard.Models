﻿namespace StockportGovUK.NetStandard.Models.Civica.Pay.Request
{
    public class CreateBasketRequestBase : AuthenticatedRequest
    {
        public string ReturnURL { get; set; }

        public string CallingAppTranReference { get; set; }

    }
}