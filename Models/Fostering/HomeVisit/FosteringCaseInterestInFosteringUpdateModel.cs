using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.Fostering.HomeVisit
{
    public class FosteringCaseInterestInFosteringUpdateModel
    {
        public string CaseReference { get; set; }

        public string ReasonsForFostering { get; set; }

        public List<string> TypesOfFostering { get; set; }
    }
}
