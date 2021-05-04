using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Verint
{
    public class NoteRequest
    {
        [RegularExpression("^$|^[0-9]{12}$", ErrorMessage = "CaseRef must be a valid reference number")]
        public long CaseRef { get; set; } 

        public int Interaction { get; set; } = 0;

        public string NoteName { get; set; }
    }
}
