using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.Update
{
    public class FosteringCaseUnderSixteenLivingAwayFromHomeUpdateModel
    {
        public string CaseReference { get; set; }

        public FosteringCaseUnderSixteenLivingAwayFromHomeApplicantUpdateModel FirstApplicant { get; set; }

        public FosteringCaseUnderSixteenLivingAwayFromHomeApplicantUpdateModel SecondApplicant { get; set; }

    }

    public class FosteringCaseUnderSixteenLivingAwayFromHomeApplicantUpdateModel
    {
        public bool? AnyChildrenUnderSixteen { get; set; }

        public List<OtherPerson> ChildrenUnderSixteenLivingAwayFromHome { get; set; }
    }
}
