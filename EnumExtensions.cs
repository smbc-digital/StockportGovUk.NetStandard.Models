using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace StockportGovUK.NetStandard.Models
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue) => enumValue.GetType()?
                                                                                .GetMember(enumValue.ToString())?
                                                                                .First()?
                                                                                .GetCustomAttribute<DisplayAttribute>()?.Name;
        
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue) 
                where TAttribute : Attribute => enumValue.GetType()
                                                            .GetMember(enumValue.ToString())
                                                            .First()
                                                            .GetCustomAttribute<TAttribute>();
    }
}
