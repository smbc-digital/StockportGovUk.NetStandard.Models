using System;

namespace StockportGovUK.NetStandard.Models.RevsAndBens
{
    public interface ITransactionModel
    {
        DateTime Date { get; set; }

        decimal Amount { get; set; }

        string Method { get; set; }

        string Description { get; set; }

        ETransactionType Type { get; set; }
    }

    public class TransactionModel : ITransactionModel
    {
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string Method { get; set; }

        public string Description { get; set; }

        public ETransactionType Type { get; set; }
    }

    public enum ETransactionType
    {
        Debit,
        Credit
    }
}
