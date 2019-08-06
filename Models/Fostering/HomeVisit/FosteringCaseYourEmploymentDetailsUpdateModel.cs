﻿using StockportGovUK.NetStandard.Models.Enums;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.HomeVisit
{
    public class FosteringCaseYourEmploymentDetailsUpdateModel
    {
        public string CaseReference { get; set; }

        public FosteringCaseYourEmploymentDetailsApplicantUpdateModel FirstApplicant { get; set; }

        public FosteringCaseYourEmploymentDetailsApplicantUpdateModel SecondApplicant { get; set; }
    }

    public class FosteringCaseYourEmploymentDetailsApplicantUpdateModel
    {
        public bool? AreYouEmployed { get; set; }

        public string CurrentEmployer { get; set; }

        public string JobTitle { get; set; }

        public EHoursOfWork CurrentHoursOfWork { get; set; }
    }
}
