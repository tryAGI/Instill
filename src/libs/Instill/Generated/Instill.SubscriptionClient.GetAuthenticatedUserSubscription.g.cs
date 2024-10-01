
#nullable enable

namespace Instill
{
    public partial class SubscriptionClient
    {
        partial void PrepareGetAuthenticatedUserSubscriptionArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareGetAuthenticatedUserSubscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessGetAuthenticatedUserSubscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAuthenticatedUserSubscriptionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get the subscription of the authenticated user<br/>
        /// Returns the subscription details of the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.GetAuthenticatedUserSubscriptionResponse> GetAuthenticatedUserSubscriptionAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetAuthenticatedUserSubscriptionArguments(
                httpClient: _httpClient);

            var __pathBuilder = new PathBuilder(
                path: "/v1beta/user/subscription",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetAuthenticatedUserSubscriptionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetAuthenticatedUserSubscriptionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetAuthenticatedUserSubscriptionResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Instill.GetAuthenticatedUserSubscriptionResponse), JsonSerializerContext) as global::Instill.GetAuthenticatedUserSubscriptionResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}