using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.Application
{
    public class FosteringCaseAddressHistoryUpdateModel
    {
        public string CaseReference { get; set; }

        public FosteringCaseAddressHistoryApplicantUpdateModel FirstApplicant { get; set; }

        public FosteringCaseAddressHistoryApplicantUpdateModel SecondApplicant { get; set; }
    }

    public class FosteringCaseAddressHistoryApplicantUpdateModel
    {
        public List<PreviousAddress> AddressHistory { get; set; }
    }
}
