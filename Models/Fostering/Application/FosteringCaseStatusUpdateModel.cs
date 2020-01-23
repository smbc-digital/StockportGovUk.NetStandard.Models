using StockportGovUK.NetStandard.Models.Enums;

namespace StockportGovUK.NetStandard.Models.Fostering.Application
{
    public class FosteringCaseStatusUpdateModel
    {
        public string CaseId { get; set; }

        public ETaskStatus Status { get; set; }

        public EFosteringApplicationForm Form { get; set; }
    }
}
