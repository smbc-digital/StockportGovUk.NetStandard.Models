using System;
using System.Collections.Generic;
using StockportGovUK.NetStandard.Models.Enums;

namespace StockportGovUK.NetStandard.Models.Models.Fostering
{
    public class FosteringCase
    {
        public FosteringCaseStatuses Statuses { get; set; }

        public FosteringApplicant FirstApplicant { get; set; }

        public FosteringApplicant SecondApplicant { get; set; }

        public bool? AnyOtherPeopleInYourHousehold { get; set; }

        public bool? DoYouHaveAnyPets { get; set; }

        public List<OtherPerson> OtherPeopleInYourHousehold { get; set; }

        public string WithPartner { get; set; }

        public string PrimaryLanguage { get; set; }
       
        public string OtherLanguages { get; set; }

        public bool? MarriedOrInACivilPartnership { get; set; }
                
        public DateTime? DateOfMarriage { get; set; }

        public DateTime? DateMovedInTogether { get; set; }

        public string ReasonsForFostering { get; set; }

        public List<string> TypesOfFostering { get; set; }
    }

    public class FosteringApplicant
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool? EverBeenKnownByAnotherName { get; set; }

        public string Nationality { get; set; }

        public string Ethnicity { get; set; }

        public string Gender { get; set; }

        public string AnotherName { get; set; }

        public string SexualOrientation { get; set; }

        public string Religion { get; set; }

        public string PlaceOfBirth { get; set; }

        public bool? AreYouEmployed { get; set; }

        public string CurrentEmployer { get; set; }

        public string JobTitle { get; set; }

        public EHoursOfWork CurrentHoursOfWork { get; set; }

        public bool? PreviouslyApplied { get; set; }

        public bool? RegisteredDisabled { get; set; }

        public bool? Practitioner { get; set; }
    }

    public class FosteringCaseStatuses
    {
        public ETaskStatus TellUsAboutYourselfStatus { get; set; } 

        public ETaskStatus YourEmploymentDetailsStatus { get; set; }

        public ETaskStatus LanguageSpokenInYourHomeStatus { get; set; }

        public ETaskStatus YourPartnershipStatus { get; set; }

        public ETaskStatus YourFosteringHistoryStatus { get; set; }

        public ETaskStatus YourHealthStatus { get; set; }

        public ETaskStatus TellUsAboutYourInterestInFosteringStatus { get; set; }

        public ETaskStatus YourHouseholdStatus { get; set; }

        public ETaskStatus ChildrenLivingAwayFromYourHomeStatus { get; set; }
    }

    public class OtherPerson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }
    }
}