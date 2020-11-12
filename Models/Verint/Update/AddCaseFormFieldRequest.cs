using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Verint.Update
{
    public class AddCaseFormFieldRequest
    {
        [Required]
        public string CaseReference { get; set; }

        [Required]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }
    }
}