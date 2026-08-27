
#nullable enable

namespace Spotify
{
    public partial class PlaylistsClient
    {


        private static readonly global::Spotify.EndPointSecurityRequirement s_GetPlaylistsItemsSecurityRequirement0 =
            new global::Spotify.EndPointSecurityRequirement
            {
                Authorizations = new global::Spotify.EndPointAuthorizationRequirement[]
                {                    new global::Spotify.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Spotify.EndPointSecurityRequirement[] s_GetPlaylistsItemsSecurityRequirements =
            new global::Spotify.EndPointSecurityRequirement[]
            {                s_GetPlaylistsItemsSecurityRequirement0,
            };
        partial void PrepareGetPlaylistsItemsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string playlistId,
            ref string? market,
            ref string? fields,
            ref int? limit,
            ref int? offset,
            ref string? additionalTypes);
        partial void PrepareGetPlaylistsItemsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string playlistId,
            string? market,
            string? fields,
            int? limit,
            int? offset,
            string? additionalTypes);
        partial void ProcessGetPlaylistsItemsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetPlaylistsItemsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Playlist Items<br/>
        /// Get full details of the items of a playlist owned by a Spotify user.<br/>
        /// **Note**: This endpoint is only accessible for playlists owned by the current user or playlists the user is a collaborator of. A `403 Forbidden` status code will be returned if the user is neither the owner nor a collaborator of the playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="market">
        /// An [ISO 3166-1 alpha-2 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).<br/>
        ///   If a country code is specified, only content that is available in that market will be returned.&lt;br/&gt;<br/>
        ///   If a valid user access token is specified in the request header, the country associated with<br/>
        ///   the user account will take priority over this parameter.&lt;br/&gt;<br/>
        ///   _**Note**: If neither market or user country are provided, the content is considered unavailable for the client._&lt;br/&gt;<br/>
        ///   Users can view the country that is associated with their account in the [account settings](https://www.spotify.com/account/overview/).<br/>
        /// Example: ES
        /// </param>
        /// <param name="fields">
        /// Filters for the query: a comma-separated list of the<br/>
        /// fields to return. If omitted, all fields are returned. For example, to get<br/>
        /// just the total number of items and the request limit:&lt;br/&gt;`fields=total,limit`&lt;br/&gt;A<br/>
        /// dot separator can be used to specify non-reoccurring fields, while parentheses<br/>
        /// can be used to specify reoccurring fields within objects. For example, to<br/>
        /// get just the added date and user ID of the adder:&lt;br/&gt;`fields=items(added_at,added_by.id)`&lt;br/&gt;Use<br/>
        /// multiple parentheses to drill down into nested objects, for example:&lt;br/&gt;`fields=items(track(name,href,album(name,href)))`&lt;br/&gt;Fields<br/>
        /// can be excluded by prefixing them with an exclamation mark, for example:&lt;br/&gt;`fields=items.track.album(!external_urls,images)`<br/>
        /// Example: items(added_by.id,track(name,href,album(name,href)))
        /// </param>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="offset">
        /// The index of the first item to return. Default: 0 (the first item). Use with limit to get the next set of items.<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </param>
        /// <param name="additionalTypes">
        /// A comma-separated list of item types that your client supports besides the default `track` type. Valid types are: `track` and `episode`.&lt;br/&gt;<br/>
        /// _**Note**: This parameter was introduced to allow existing clients to maintain their current behaviour and might be deprecated in the future._&lt;br/&gt;<br/>
        /// In addition to providing this parameter, make sure that your client properly handles cases of new types in the future by checking against the `type` field of each object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Spotify.PagingPlaylistTrackObject> GetPlaylistsItemsAsync(
            string playlistId,
            string? market = default,
            string? fields = default,
            int? limit = default,
            int? offset = default,
            string? additionalTypes = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetPlaylistsItemsAsResponseAsync(
                playlistId: playlistId,
                market: market,
                fields: fields,
                limit: limit,
                offset: offset,
                additionalTypes: additionalTypes,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Playlist Items<br/>
        /// Get full details of the items of a playlist owned by a Spotify user.<br/>
        /// **Note**: This endpoint is only accessible for playlists owned by the current user or playlists the user is a collaborator of. A `403 Forbidden` status code will be returned if the user is neither the owner nor a collaborator of the playlist.
        /// </summary>
        /// <param name="playlistId">
        /// The [Spotify ID](/documentation/web-api/concepts/spotify-uris-ids) of the playlist.<br/>
        /// Example: 3cEYpjA9oz9GiPac4AsH4n
        /// </param>
        /// <param name="market">
        /// An [ISO 3166-1 alpha-2 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).<br/>
        ///   If a country code is specified, only content that is available in that market will be returned.&lt;br/&gt;<br/>
        ///   If a valid user access token is specified in the request header, the country associated with<br/>
        ///   the user account will take priority over this parameter.&lt;br/&gt;<br/>
        ///   _**Note**: If neither market or user country are provided, the content is considered unavailable for the client._&lt;br/&gt;<br/>
        ///   Users can view the country that is associated with their account in the [account settings](https://www.spotify.com/account/overview/).<br/>
        /// Example: ES
        /// </param>
        /// <param name="fields">
        /// Filters for the query: a comma-separated list of the<br/>
        /// fields to return. If omitted, all fields are returned. For example, to get<br/>
        /// just the total number of items and the request limit:&lt;br/&gt;`fields=total,limit`&lt;br/&gt;A<br/>
        /// dot separator can be used to specify non-reoccurring fields, while parentheses<br/>
        /// can be used to specify reoccurring fields within objects. For example, to<br/>
        /// get just the added date and user ID of the adder:&lt;br/&gt;`fields=items(added_at,added_by.id)`&lt;br/&gt;Use<br/>
        /// multiple parentheses to drill down into nested objects, for example:&lt;br/&gt;`fields=items(track(name,href,album(name,href)))`&lt;br/&gt;Fields<br/>
        /// can be excluded by prefixing them with an exclamation mark, for example:&lt;br/&gt;`fields=items.track.album(!external_urls,images)`<br/>
        /// Example: items(added_by.id,track(name,href,album(name,href)))
        /// </param>
        /// <param name="limit">
        /// The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50.<br/>
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="offset">
        /// The index of the first item to return. Default: 0 (the first item). Use with limit to get the next set of items.<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </param>
        /// <param name="additionalTypes">
        /// A comma-separated list of item types that your client supports besides the default `track` type. Valid types are: `track` and `episode`.&lt;br/&gt;<br/>
        /// _**Note**: This parameter was introduced to allow existing clients to maintain their current behaviour and might be deprecated in the future._&lt;br/&gt;<br/>
        /// In addition to providing this parameter, make sure that your client properly handles cases of new types in the future by checking against the `type` field of each object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Spotify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Spotify.AutoSDKHttpResponse<global::Spotify.PagingPlaylistTrackObject>> GetPlaylistsItemsAsResponseAsync(
            string playlistId,
            string? market = default,
            string? fields = default,
            int? limit = default,
            int? offset = default,
            string? additionalTypes = default,
            global::Spotify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetPlaylistsItemsArguments(
                httpClient: HttpClient,
                playlistId: ref playlistId,
                market: ref market,
                fields: ref fields,
                limit: ref limit,
                offset: ref offset,
                additionalTypes: ref additionalTypes);


            var __authorizations = global::Spotify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetPlaylistsItemsSecurityRequirements,
                operationName: "GetPlaylistsItemsAsync");

            using var __timeoutCancellationTokenSource = global::Spotify.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Spotify.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Spotify.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Spotify.PathBuilder(
                                path: $"/playlists/{playlistId}/items",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("market", market)
                                .AddOptionalParameter("fields", fields)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("additional_types", additionalTypes)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Spotify.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                global::Spotify.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetPlaylistsItemsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    playlistId: playlistId!,
                    market: market,
                    fields: fields,
                    limit: limit,
                    offset: offset,
                    additionalTypes: additionalTypes);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Spotify.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Spotify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetPlaylistsItems",
                                methodName: "GetPlaylistsItemsAsync",
                                pathTemplate: "$\"/playlists/{playlistId}/items\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Spotify.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Spotify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Spotify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetPlaylistsItems",
                                methodName: "GetPlaylistsItemsAsync",
                                pathTemplate: "$\"/playlists/{playlistId}/items\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Spotify.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Spotify.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Spotify.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Spotify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Spotify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetPlaylistsItems",
                                methodName: "GetPlaylistsItemsAsync",
                                pathTemplate: "$\"/playlists/{playlistId}/items\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Spotify.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetPlaylistsItemsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Spotify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Spotify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetPlaylistsItems",
                                methodName: "GetPlaylistsItemsAsync",
                                pathTemplate: "$\"/playlists/{playlistId}/items\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Spotify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Spotify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetPlaylistsItems",
                                methodName: "GetPlaylistsItemsAsync",
                                pathTemplate: "$\"/playlists/{playlistId}/items\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad or expired token. This can happen if the user revoked a token or the access token has expired. You should re-authenticate the user.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Spotify.GetPlaylistsItemsResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Spotify.GetPlaylistsItemsResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Spotify.GetPlaylistsItemsResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Spotify.ApiException<global::Spotify.GetPlaylistsItemsResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Bad OAuth request (wrong consumer key, bad nonce, expired timestamp...). Unfortunately, re-authenticating the user won't help here.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Spotify.GetPlaylistsItemsResponse2? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Spotify.GetPlaylistsItemsResponse2.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Spotify.GetPlaylistsItemsResponse2.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Spotify.ApiException<global::Spotify.GetPlaylistsItemsResponse2>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The app has exceeded its rate limits.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Spotify.GetPlaylistsItemsResponse3? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Spotify.GetPlaylistsItemsResponse3.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Spotify.GetPlaylistsItemsResponse3.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Spotify.ApiException<global::Spotify.GetPlaylistsItemsResponse3>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetPlaylistsItemsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Spotify.PagingPlaylistTrackObject.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Spotify.AutoSDKHttpResponse<global::Spotify.PagingPlaylistTrackObject>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Spotify.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Spotify.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Spotify.PagingPlaylistTrackObject.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Spotify.AutoSDKHttpResponse<global::Spotify.PagingPlaylistTrackObject>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Spotify.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Spotify.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}