
#nullable enable

namespace Spotify
{
    /// <summary>
    /// If `include_external=audio` is specified it signals that the client can play externally hosted audio content, and marks<br/>
    /// the content as playable in the response. By default externally hosted audio content is marked as unplayable in the response.
    /// </summary>
    public enum SearchIncludeExternal
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchIncludeExternalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchIncludeExternal value)
        {
            return value switch
            {
                SearchIncludeExternal.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchIncludeExternal? ToEnum(string value)
        {
            return value switch
            {
                "audio" => SearchIncludeExternal.Audio,
                _ => null,
            };
        }
    }
}