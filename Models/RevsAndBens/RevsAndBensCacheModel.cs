using System;
using System.Collections.Generic;
using System.Text;

namespace StockportGovUK.NetStandard.Models.Models.RevsAndBens
{
    public class RevsAndBensCacheModel
    {
        public Dashboard Dashboard { get; set; }

        public Benefits Benefits { get; set; }
    }

    public class Dashboard
    {
        public bool IsBenefitClaimant { get; set; }
    }
}
