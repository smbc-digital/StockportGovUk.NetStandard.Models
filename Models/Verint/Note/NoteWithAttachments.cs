using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StockportGovUK.NetStandard.Models.FileManagement;

namespace StockportGovUK.NetStandard.Models.Verint
{
    public class NoteWithAttachments
    {
        [RegularExpression("^$|^[0-9]{12}$", ErrorMessage = "CaseRef must be a valid reference number")]
        public long CaseRef { get; set; } 
        
        [Required]
        public List<File> Attachments { get; set; }

        public string AttachmentsDescription { get; set; } = string.Empty;

        public int Interaction { get; set; } = 0;

        public string NoteName { get; set; }
    }
}
