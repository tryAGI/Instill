
#nullable enable

namespace Instill
{
    public partial class MembershipClient
    {
        partial void PrepareListUserMembershipsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userId);
        partial void PrepareListUserMembershipsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userId);
        partial void ProcessListUserMembershipsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListUserMembershipsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List user memberships<br/>
        /// Returns the memberships of a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.ListUserMembershipsResponse> ListUserMembershipsAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListUserMembershipsArguments(
                httpClient: _httpClient,
                userId: ref userId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1beta/users/{userId}/memberships", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListUserMembershipsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListUserMembershipsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListUserMembershipsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Instill.ListUserMembershipsResponse), JsonSerializerContext) as global::Instill.ListUserMembershipsResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}