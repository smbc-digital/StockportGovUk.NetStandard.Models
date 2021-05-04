using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StockportGovUK.NetStandard.Models.FileManagement;

namespace StockportGovUK.NetStandard.Models.Verint
{
    public class NoteWithAttachments: NoteRequest
    {
        [Required]
        public List<File> Attachments { get; set; }

        public string AttachmentsDescription { get; set; } = string.Empty;

    }
}
