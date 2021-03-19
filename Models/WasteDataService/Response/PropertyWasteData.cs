using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.WasteDataService.Response
{
    public class PropertyWasteData
    {
        public long Uprn { get; set; }
        public string AddressLabel { get; set; }
        public BinRounds Rounds { get; set; } = new BinRounds();
        public bool UnsuitableForWheeledBins { get; set; }
        public string CollectionPoint { get; set; }
        public AssistedCollection AssistedCollection { get; set; }
        public int Contains { get; set; }
        public ContainedBy ContainedBy { get; set; }
        public List<History> History { get; set; }
    }
}
