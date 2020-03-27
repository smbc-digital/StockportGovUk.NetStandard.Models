namespace StockportGovUK.NetStandard.Models.FileManagement
{
    public class File
    {
        public string TrustedOriginalFileName { get; set; }
        public string Content { get; set; }
        public string UntrustedOriginalFileName { get; set; }
        public string KeyName { get; set; }
    }
}