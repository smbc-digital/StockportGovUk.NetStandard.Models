using StockportGovUK.NetStandard.Models.Enums;

namespace StockportGovUK.NetStandard.Models.TrackAReport.Requests
{
    public class TrackAReportRequest
    {
        public string ReferenceNumber { get; set; }

        public EAssetType AssetType { get; set; }
        
        public string AssetId { get; set; }
    }
}
