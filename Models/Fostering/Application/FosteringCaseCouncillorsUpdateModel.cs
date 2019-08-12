using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.Application
{
    public class FosteringCaseCouncillorsUpdateModel
    {
        [Required]
        public string CaseReference { get; set; }

        public FosteringCaseCouncillorsApplicantUpdateModel FirstApplicant { get; set; }

        public FosteringCaseCouncillorsApplicantUpdateModel SecondApplicant { get; set; }
    }

    public class FosteringCaseCouncillorsApplicantUpdateModel
    {
        [Required]
        public bool HasContactWithCouncillor { get; set; }

        [Required]
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
