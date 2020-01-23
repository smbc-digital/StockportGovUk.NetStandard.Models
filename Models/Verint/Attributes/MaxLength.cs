using System;

namespace StockportGovUK.NetStandard.Models.Verint.Attributes
{
    public class MaxLength : Attribute
    {
        public MaxLength(int length)
        {
            Length = length;
        }

        public int Length { get; set; }
    }
}
