using System.ComponentModel.DataAnnotations;
using StockportGovUK.NetStandard.Models.Attributes;

namespace StockportGovUK.NetStandard.Models.Fostering.Application
{
    public class FosteringCaseGpDetailsUpdateModel
    {
        public string CaseReference { get; set; }

        public FosteringCaseGpDetailsApplicantUpdateModel FirstApplicant { get; set; }

        public FosteringCaseGpDetailsApplicantUpdateModel SecondApplicant { get; set; }
    }

    public class FosteringCaseGpDetailsApplicantUpdateModel
    {
        [Required]
        public string NameOfGp { get; set; }

        [Required]
        public string NameOfGpPractice { get; set; }

        [Required]
        public string GpPhoneNumber { get; set; }

        [Address]
        public Address GpAddress { get; set; }
    }
}
