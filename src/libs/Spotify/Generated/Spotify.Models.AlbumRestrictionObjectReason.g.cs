
#nullable enable

namespace Spotify
{
    /// <summary>
    /// The reason for the restriction. Albums may be restricted if the content is not available in a given market, to the user's subscription type, or when the user's account is set to not play explicit content.<br/>
    /// Additional reasons may be added in the future.
    /// </summary>
    public enum AlbumRestrictionObjectReason
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
        /// <summary>
        ///
        /// </summary>
        Market,
        /// <summary>
        ///
        /// </summary>
        Product,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlbumRestrictionObjectReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlbumRestrictionObjectReason value)
        {
            return value switch
            {
                AlbumRestrictionObjectReason.Explicit => "explicit",
                AlbumRestrictionObjectReason.Market => "market",
                AlbumRestrictionObjectReason.Product => "product",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlbumRestrictionObjectReason? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => AlbumRestrictionObjectReason.Explicit,
                "market" => AlbumRestrictionObjectReason.Market,
                "product" => AlbumRestrictionObjectReason.Product,
                _ => null,
            };
        }
    }
}