using StockportGovUK.NetStandard.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Organisation
{
    public class OrganisationSearch
    {
        [Required]
        public EOrganisationProvider OrganisationProvider { get; set; }

        [Required]
        [MinLength(3)]
        public string SearchTerm { get; set; }
    }
}
