// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */



using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi : IApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;InlineResponseDefault&gt;&gt;</returns>
        Task<ApiResponse<InlineResponseDefault>> FooGetWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;InlineResponseDefault&gt;</returns>
        Task<InlineResponseDefault> FooGetAsync(System.Threading.CancellationToken? cancellationToken = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// An event to track the health of the server. 
        /// If you store these event args, be sure to purge old event args to prevent a memory leak.
        /// </summary>
        public event ClientUtils.EventHandler<ApiResponseEventArgs> ApiResponded;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<DefaultApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BasicTokenProvider"/>
        /// </summary>
        public TokenProvider<BasicToken> BasicTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="HttpSignatureTokenProvider"/>
        /// </summary>
        public TokenProvider<HttpSignatureToken> HttpSignatureTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="OauthTokenProvider"/>
        /// </summary>
        public TokenProvider<OAuthToken> OauthTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(ILogger<DefaultApi> logger, HttpClient httpClient, 
            TokenProvider<ApiKeyToken> apiKeyProvider, 
            TokenProvider<BearerToken> bearerTokenProvider, 
            TokenProvider<BasicToken> basicTokenProvider, 
            TokenProvider<HttpSignatureToken> httpSignatureTokenProvider, 
            TokenProvider<OAuthToken> oauthTokenProvider)
        {
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
            BearerTokenProvider = bearerTokenProvider;
            BasicTokenProvider = basicTokenProvider;
            HttpSignatureTokenProvider = httpSignatureTokenProvider;
            OauthTokenProvider = oauthTokenProvider;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="InlineResponseDefault"/>&gt;</returns>
        public async Task<InlineResponseDefault> FooGetAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<InlineResponseDefault> result = await FooGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="InlineResponseDefault"/>&gt;</returns>
        public async Task<InlineResponseDefault> FooGetOrDefaultAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<InlineResponseDefault> result = null;
            try 
            {
                result = await FooGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }
        

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="InlineResponseDefault"/></returns>
        public async Task<ApiResponse<InlineResponseDefault>> FooGetWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    UriBuilder uriBuilder = new UriBuilder();
                    uriBuilder.Host = HttpClient.BaseAddress.Host;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/foo";

                    request.RequestUri = uriBuilder.Uri;

                    string[] accepts = new string[] { 
                        "application/json" 
                    };

                    string accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));
                    
                    request.Method = new HttpMethod("GET");

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        DateTime requestedAt = DateTime.UtcNow;

                        string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                        if (ApiResponded != null)
                        {
                            try
                            {
                                ApiResponded.Invoke(this, new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/foo"));
                            }
                            catch(Exception e)
                            {
                                Logger.LogError(e, "An error occured while invoking ApiResponded.");
                            }
                        }

                        ApiResponse<InlineResponseDefault> apiResponse = new ApiResponse<InlineResponseDefault>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                            apiResponse.Content = System.Text.Json.JsonSerializer.Deserialize<InlineResponseDefault>(apiResponse.RawContent, ClientUtils.JsonSerializerOptions);

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                Logger.LogError(e, "An error occured while sending the request to the server.");
                throw;
            }
        }
    }
}
