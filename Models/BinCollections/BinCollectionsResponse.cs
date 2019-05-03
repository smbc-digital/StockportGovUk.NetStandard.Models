using Newtonsoft.Json;

namespace StockportGovUK.NetStandard.Models.BinCollections
{
    public class BinCollectionsResponse
    {
        [JsonProperty("Blue_Bin_Collection")]
        public string BlueBinCollection { get; set; }

        [JsonProperty("Brown_Bin_Collection")]
        public string BrownBinCollection { get; set; }

        [JsonProperty("Black_Bin_Collection")]
        public string BlackBinCollection { get; set; }

        [JsonProperty("Green_Bin_Collection")]
        public string GreenBinCollection { get; set; }
    }
}