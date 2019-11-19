using System;

namespace StockportGovUK.NetStandard.Models.Models.RevsAndBens
{
    public class TransactionModel
    {
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string Method { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }
    }
}
