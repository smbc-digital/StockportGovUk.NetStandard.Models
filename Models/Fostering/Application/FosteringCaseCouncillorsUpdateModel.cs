using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StockportGovUK.NetStandard.Models.Attributes;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.Application
{
    public class FosteringCaseCouncillorsUpdateModel
    {
        [Required]
        public string CaseReference { get; set; }

        [Required]
        public FosteringCaseCouncillorsApplicantUpdateModel FirstApplicant { get; set; }

        public FosteringCaseCouncillorsApplicantUpdateModel SecondApplicant { get; set; }
    }

    public class FosteringCaseCouncillorsApplicantUpdateModel
    {
        [Required]
        public bool HasContactWithCouncillor { get; set; }

        [RequiredIf("HasContactWithCouncillor", "The CouncillorRelationshipDetails field is required.")]
        public List<CouncillorRelationshipDetailsUpdateModel> CouncillorRelationshipDetails { get; set; }
    }


    public class CouncillorRelationshipDetailsUpdateModel
    {
        [Required]
        public string CouncillorName { get; set; }

        [Required]
        public string Relationship { get; set; }
    }
}
