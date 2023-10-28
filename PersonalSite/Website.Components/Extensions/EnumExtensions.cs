using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Website.Components.Extensions;

public static class EnumExtensions
{
    public static TAttribute? GetAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
    {
        return enumValue
            .GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<TAttribute>();
    }

    public static string GetDisplayName(this Enum enumValue)
    {
        return enumValue
            .GetAttribute<DisplayAttribute>()?.Name ?? enumValue.ToString();
    }
}
