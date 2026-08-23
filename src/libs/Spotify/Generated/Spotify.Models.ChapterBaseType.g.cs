
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum ChapterBaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Episode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChapterBaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChapterBaseType value)
        {
            return value switch
            {
                ChapterBaseType.Episode => "episode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChapterBaseType? ToEnum(string value)
        {
            return value switch
            {
                "episode" => ChapterBaseType.Episode,
                _ => null,
            };
        }
    }
}