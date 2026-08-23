
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum EpisodeBaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Episode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EpisodeBaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EpisodeBaseType value)
        {
            return value switch
            {
                EpisodeBaseType.Episode => "episode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EpisodeBaseType? ToEnum(string value)
        {
            return value switch
            {
                "episode" => EpisodeBaseType.Episode,
                _ => null,
            };
        }
    }
}