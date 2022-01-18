using System.ComponentModel.DataAnnotations;
using StockportGovUK.NetStandard.Models.Enums;

namespace StockportGovUK.NetStandard.Models.Street
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
