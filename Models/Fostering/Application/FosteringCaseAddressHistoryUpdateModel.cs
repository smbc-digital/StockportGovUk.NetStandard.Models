using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.Models.Fostering.Application
{
    public class FosteringCaseAddressHistoryUpdateModel
    {
        public string CaseReference { get; set; }

        public List<PreviousAddress> AddressHistory { get; set; }
    }
}
