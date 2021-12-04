using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Extension
{
    public static class UserTypeExtensions
    {
        public static string GetEnumDisplayName(this Enum enumValue)
        {
            var result = enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttributes<DisplayAttribute>().First().Name;

            return result;
        }
    }
    
}
