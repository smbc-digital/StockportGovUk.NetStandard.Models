using StockportGovUK.NetStandard.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Models.Street
{
    public class StreetSearch
    {
        [Required]
        public EStreetProvider StreetProvider { get; set; }

        [Required]
        [MinLength(3)]
        public string SearchTerm { get; set; }
    }
}
