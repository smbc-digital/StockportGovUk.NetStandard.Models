namespace StockportGovUK.NetStandard.Models.Models.Fostering.Update
{
    public class FosteringCaseReferenceUpdateModel
    {
        public string CaseReference { get; set; }

        public ReferenceDetails FamilyReference { get; set; }

        public ReferenceDetails FirstPersonalReference { get; set; }

        public ReferenceDetails SecondPersonalReference { get; set; }
    }
}
