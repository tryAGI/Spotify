
#nullable enable

namespace Spotify
{
    /// <summary>
    /// You can use Spotify's Web API to discover music and podcasts, manage your Spotify library, control audio playback, and much more. Browse our available Web API endpoints using the sidebar at left, or via the navigation bar on top of this page on smaller screens.<br/>
    /// In order to make successful Web API requests your app will need a valid access token. One can be obtained through &lt;a href="https://developer.spotify.com/documentation/general/guides/authorization-guide/"&gt;OAuth 2.0&lt;/a&gt;.<br/>
    /// The base URI for all Web API requests is `https://api.spotify.com/v1`.<br/>
    /// Need help? See our &lt;a href="https://developer.spotify.com/documentation/web-api/guides/"&gt;Web API guides&lt;/a&gt; for more information, or visit the &lt;a href="https://community.spotify.com/t5/Spotify-for-Developers/bd-p/Spotify_Developer"&gt;Spotify for Developers community forum&lt;/a&gt; to ask questions and connect with other developers.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISpotifyClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Spotify.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Spotify.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        ///
        /// </summary>
        public AlbumsClient Albums { get; }

        /// <summary>
        ///
        /// </summary>
        public ArtistsClient Artists { get; }

        /// <summary>
        ///
        /// </summary>
        public AudiobooksClient Audiobooks { get; }

        /// <summary>
        ///
        /// </summary>
        public ChaptersClient Chapters { get; }

        /// <summary>
        ///
        /// </summary>
        public EpisodesClient Episodes { get; }

        /// <summary>
        ///
        /// </summary>
        public LibraryClient Library { get; }

        /// <summary>
        ///
        /// </summary>
        public PlayerClient Player { get; }

        /// <summary>
        ///
        /// </summary>
        public PlaylistsClient Playlists { get; }

        /// <summary>
        ///
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        ///
        /// </summary>
        public ShowsClient Shows { get; }

        /// <summary>
        ///
        /// </summary>
        public TracksClient Tracks { get; }

        /// <summary>
        ///
        /// </summary>
        public UsersClient Users { get; }

    }
}