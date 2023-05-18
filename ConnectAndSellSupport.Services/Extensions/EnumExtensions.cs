using System;
using System.ComponentModel;
using System.Linq;

namespace ConnectAndSellSupport.Services.Extensions
{
    public static class EnumExtensions
    {
        public static T GetValueFromDescription<T>(this string description) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description.Equals(description, StringComparison.OrdinalIgnoreCase))
                    {
                        return (T)field.GetValue(null);
                    }
                }
                else
                {
                    if (field.Name.Equals(description, StringComparison.OrdinalIgnoreCase))
                    {
                        return (T)field.GetValue(null);
                    }
                }                
            }
            return default;
        }

        public static string GetDescription<T>(this T value) where T : Enum
        {
            var field = value.GetType().GetField(value.ToString());

            if (field.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] attributes && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
    }
}
