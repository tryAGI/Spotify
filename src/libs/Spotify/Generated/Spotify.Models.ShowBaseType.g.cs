
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum ShowBaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Show,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShowBaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShowBaseType value)
        {
            return value switch
            {
                ShowBaseType.Show => "show",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShowBaseType? ToEnum(string value)
        {
            return value switch
            {
                "show" => ShowBaseType.Show,
                _ => null,
            };
        }
    }
}