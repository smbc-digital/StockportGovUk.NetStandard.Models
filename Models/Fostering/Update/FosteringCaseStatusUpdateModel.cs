using StockportGovUK.NetStandard.Models.Enums;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.Update
{
    public class FosteringCaseStatusUpdateModel
    {
        public string CaseId { get; set; }

        public ETaskStatus Status { get; set; }

        public EFosteringHomeVisitForm Form { get; set; }
    }
}
