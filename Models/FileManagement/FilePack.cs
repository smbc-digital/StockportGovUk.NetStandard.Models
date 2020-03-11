using System;
using System.Collections.Generic;
using System.Text;
using StockportGovUK.NetStandard.Models.FileManagement;

namespace StockportGovUK.NetStandard.Models.Models.FileManagement
{
    public class FilePack
    {
        public string Name { get; set; }

        public Dictionary<string, dynamic> Files { get; set; }
    }
}
