using StockportGovUK.NetStandard.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Addresses
{
    public class AddressSearch
    {
        [Required]
        public EAddressProvider AddressProvider { get; set; }

        [Required]
        [MinLength(3)]
        public string SearchTerm { get; set; }
    }
}
