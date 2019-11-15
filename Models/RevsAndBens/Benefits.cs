using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace StockportGovUK.NetStandard.Models.Models.RevsAndBens
{
    public class Benefits
    {
        public string ClaimNumber { get; set; }

        public string ClaimStatus { get; set; }

        public string ClaimAddress { get; set; }

        public string PersonType { get; set; }

        public string ClaimType { get; set; }

        public NextPayment NextPayment { get; set; }

        public CurrentEntitlement CurrentEntitlement { get; set; }

        public HousingBenefitHistory HousingBenefitHistory { get; set; }

        public CouncilTaxBenefitHistory CouncilTaxBenefitHistory { get; set; }

        public List<Document> Documents { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public BenefitsComboEnum BenefitsCombination { get; set; }
    }

    public enum BenefitsComboEnum
    {
        AllBenefits = 0,
        HousingBenefitOnly = 1,
        CouncilTaxSupportOnly = 2
    }

    public class NextPayment
    {
        public string NextPaymentDate { get; set; }

        public string NextPaymentAmount { get; set; }

        public string NextPaymentPayee { get; set; }

        public string NextPaymentMethod { get; set; }

        public int PaymentFrequencyInWeeks { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentStatusEnum PaymentStatus { get; set; }

        public DateTime NextPaymentDateActual
        {
            get
            {
                DateTime dt;
                DateTime.TryParse(NextPaymentDate, new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
                return dt;
            }
        }
    }

    public enum PaymentStatusEnum
    {
        Expected = 0,
        Reduced = 1,
        Increased = 2
    }

    public class CurrentEntitlement
    {
        public string WeeklyHousingBenefitEntitlement { get; set; }

        public string WeeklyCtaxBenefitEntitlement { get; set; }
    }

    public class HousingBenefitHistory
    {
        public List<HousingBenefitsPaymentDetail> PaymentHistory { get; set; }

        public List<Entitlement> EntitlementHistory { get; set; }
    }

    public class CouncilTaxBenefitHistory
    {
        public List<CtaxBenefitsPaymentDetail> PaymentHistory { get; set; }

        public List<Entitlement> EntitlementHistory { get; set; }

        public CtaxBenefitsSummary CurrentSummary { get; set; }
    }

    public class CtaxBenefitsSummary
    {
        public int TaxYear { get; set; }

        public string AccountReference { get; set; }

        public string TotalBill { get; set; }

        public List<CouncilTaxBenefitsPayment> BenefitsBreakdown { get; set; }

        public string TotalBenefits { get; set; }

        public string TotalPayments { get; set; }

        public string BalanceOutstanding { get; set; }
    }

    public class CouncilTaxBenefitsPayment
    {
        public string PaymentDate { get; set; }

        public string PaymentPeriod { get; set; }

        public string Amount { get; set; }
    }

    public class Document
    {
        public string Id { get; set; }

        public string DateCreated { get; set; }

        public string Downloaded { get; set; }

        public string DocType { get; set; }

        public string DocName { get; set; }

        public string ClaimNumber { get; set; }

        public string OtherReference { get; set; }
    }

    public abstract class PaymentDetail
    {
        public string DatePaid { get; set; }

        public string PayAmount { get; set; }

        public string PeriodStart { get; set; }

        public string PeriodEnd { get; set; }

        public DateTime DatePaidActual
        {
            get
            {
                DateTime dt;
                DateTime.TryParse(DatePaid, new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
                return dt;
            }
        }
    }

    public class HousingBenefitsPaymentDetail : PaymentDetail
    {
        public string Payee { get; set; }
    }

    public class CtaxBenefitsPaymentDetail : PaymentDetail
    {
        public string OnAct { get; set; }

        public string CouncilTaxReference { get; set; }
    }

    public class Entitlement
    {
        public string PeriodStart { get; set; }

        public string PeriodEnd { get; set; }

        public string WeeklyBenefit { get; set; }

        public string PeriodStatus { get; set; }
    }
}
