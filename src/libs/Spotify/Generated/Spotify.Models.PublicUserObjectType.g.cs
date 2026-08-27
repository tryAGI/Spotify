
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum PublicUserObjectType
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicUserObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicUserObjectType value)
        {
            return value switch
            {
                PublicUserObjectType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicUserObjectType? ToEnum(string value)
        {
            return value switch
            {
                "user" => PublicUserObjectType.User,
                _ => null,
            };
        }
    }
}