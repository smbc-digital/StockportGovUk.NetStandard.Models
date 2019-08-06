using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.HomeVisit
{
    public class FosteringCaseHouseholdUpdateModel
    {
        public string CaseReference { get; set; }

        public bool? AnyOtherPeopleInYourHousehold { get; set; }

        public bool? DoYouHaveAnyPets { get; set; }

        public string PetsInformation { get; set; }

        public List<OtherPerson> OtherPeopleInYourHousehold { get; set; }
    }
}
