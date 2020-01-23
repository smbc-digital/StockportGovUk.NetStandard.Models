using StockportGovUK.NetStandard.Models.Enums;

namespace StockportGovUK.NetStandard.Models.Fostering.HomeVisit
{
    public class FosteringCaseStatusUpdateModel
    {
        public string CaseId { get; set; }

        public ETaskStatus Status { get; set; }

        public EFosteringHomeVisitForm Form { get; set; }
    }
}
