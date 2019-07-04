using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.Update
{
    public class FosteringCaseHouseholdUpdateModel
    {
        public string CaseReference { get; set; }

        public bool? AnyOtherPeopleInYourHousehold { get; set; }

        public bool? DoYouHaveAnyPets { get; set; }

        public List<OtherPerson> OtherPeopleInYourHousehold { get; set; }
    }
}
