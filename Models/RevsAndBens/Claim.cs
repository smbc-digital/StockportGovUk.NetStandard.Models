using System;
using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.RevsAndBens
{
    public class Claim
    {
        public ClaimDetails Details { get; set; }
        
        public List<BenefitsDocument> Documents { get; set; }

        public List<Payment> HousingBenefitPaymentHistory { get; set; }

        public List<Payment> CouncilTaxPaymentHistory { get; set; }

        public BenefitsSummary BenefitsSummary { get; set; }
    }

    public class ClaimDetails
    {
        public string Number { get; set; }

        public string Status { get; set; }

        public string Address { get; set; }

        public NextPayment NextPayment { get; set; }

        public CurrentEntitlement CurrentEntitlement { get; set; }

        public BenefitsCombinationEnum BenefitsCombination { get; set; }
    }

    public class NextPayment
    {
        public DateTime DueDate { get; set; }

        public decimal Amount { get; set; }

        public string Payee { get; set; }

        public decimal PaidUpToAmount { get; set; }

        public string Schedule { get; set; }

        public string Method { get; set; }

        public string Status { get; set; }
    }

    public class CurrentEntitlement
    {
        public decimal WeeklyHousingBenefitEntitlement { get; set; }

        public decimal WeeklyCtaxBenefitEntitlement { get; set; }
    }

    public enum BenefitsCombinationEnum
    {
        AllBenefits = 0,
        HousingBenefitOnly = 1,
        CouncilTaxSupportOnly = 2
    }

    public class BenefitsSummary
    {
        public int TaxYear { get; set; }

        public string AccountReference { get; set; }

        public decimal TotalBill { get; set; }

        public decimal TotalBenefits { get; set; }

        public decimal BalanceOutstanding { get; set; }
    }

    public class BenefitsDocument
    {
        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public bool Downloaded { get; set; }

        public string Id { get; set; }

        public string Type { get; set; }

        public string AccountReference { get; set; }
    }

    public class Payment
    {
        public DateTime DatePaid { get; set; }

        public decimal Amount { get; set; }

        public DateTime PeriodStart { get; set; }

        public DateTime PeriodEnd { get; set; }

        public string Type { get; set; }

        public string Payee { get; set; }

        public bool OnAct { get; set; }

        public string CouncilTaxReference { get; set; }
    }
}
