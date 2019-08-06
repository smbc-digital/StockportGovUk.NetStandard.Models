using System;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.HomeVisit
{
    public class FosteringCaseHealthUpdateModel
    {
        public string CaseReference { get; set; }

        public FosteringCaseHealthApplicantUpdateModel FirstApplicant { get; set; }

        public FosteringCaseHealthApplicantUpdateModel SecondApplicant { get; set; }
    }

    public class FosteringCaseHealthApplicantUpdateModel
    {
        public bool? RegisteredDisabled { get; set; }

        public bool? Practitioner { get; set; }
    }
}