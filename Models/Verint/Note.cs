using System;

namespace StockportGovUK.NetStandard.Models.Models.Verint
{
    public class Note
    {
        public long ID { get; private set; }

        public string Text { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }
    }
}
