using System;

namespace StockportGovUK.NetStandard.Models.Verint.Attributes
{
    [System.AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class IncludeIfNull : Attribute
    {
    }
}
