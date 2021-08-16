﻿using StockportGovUK.NetStandard.Models.Verint;

namespace StockportGovUK.NetStandard.Models.Models.Uniform
{
    public class HousingDisrepairServiceRequest
    {
        public string Resolved;
        public string Description { get; set; }
        public string CrmReference { get; set; }
        public Address Property { get; set; }
        public Customer Customer { get; set; }
    }
}
