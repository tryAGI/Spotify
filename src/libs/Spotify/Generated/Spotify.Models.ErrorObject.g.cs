
#nullable enable

namespace Spotify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ErrorObject
    {
        /// <summary>
        /// The HTTP status code (also returned in the response header; see [Response Status Codes](/documentation/web-api/concepts/api-calls#response-status-codes) for more information).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Status { get; set; }

        /// <summary>
        /// A short description of the cause of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorObject" /> class.
        /// </summary>
        /// <param name="status">
        /// The HTTP status code (also returned in the response header; see [Response Status Codes](/documentation/web-api/concepts/api-calls#response-status-codes) for more information).
        /// </param>
        /// <param name="message">
        /// A short description of the cause of the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorObject(
            int status,
            string message)
        {
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorObject" /> class.
        /// </summary>
        public ErrorObject()
        {
        }

    }
}