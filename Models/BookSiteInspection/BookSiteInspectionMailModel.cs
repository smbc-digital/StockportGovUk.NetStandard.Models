using System;
using System.Collections.Generic;
using System.Text;

namespace StockportGovUK.NetStandard.Models.Models.BookSiteInspection {
    public class BookSiteInspectionMailModel {
        public string Reference { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
        public bool HasCovidWarning { get; set; } = false;
    }
}
