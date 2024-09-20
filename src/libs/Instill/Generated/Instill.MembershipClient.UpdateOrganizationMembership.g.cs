
#nullable enable

namespace Instill
{
    public partial class MembershipClient
    {
        partial void PrepareUpdateOrganizationMembershipArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string organizationId,
            ref string userId,
            ref string updateMask,
            global::Instill.OrganizationMembership request);
        partial void PrepareUpdateOrganizationMembershipRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string organizationId,
            string userId,
            string updateMask,
            global::Instill.OrganizationMembership request);
        partial void ProcessUpdateOrganizationMembershipResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateOrganizationMembershipResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Uppdate an organization membership<br/>
        /// Updates a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.UpdateOrganizationMembershipResponse> UpdateOrganizationMembershipAsync(
            string organizationId,
            string userId,
            string updateMask,
            global::Instill.OrganizationMembership request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateOrganizationMembershipArguments(
                httpClient: _httpClient,
                organizationId: ref organizationId,
                userId: ref userId,
                updateMask: ref updateMask,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/organizations/{organizationId}/memberships/{userId}",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("updateMask", updateMask) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateOrganizationMembershipRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                organizationId: organizationId,
                userId: userId,
                updateMask: updateMask,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateOrganizationMembershipResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateOrganizationMembershipResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Instill.UpdateOrganizationMembershipResponse), JsonSerializerContext) as global::Instill.UpdateOrganizationMembershipResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Uppdate an organization membership<br/>
        /// Updates a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="updateMask"></param>
        /// <param name="name">
        /// The resource name of the membership, which allows its access by<br/>
        /// organization and user ID.<br/>
        /// - Format: `organizations/{organization.id}/memberships/{user.id}`.
        /// </param>
        /// <param name="role">
        /// Role of the user in the organization.
        /// </param>
        /// <param name="organization">
        /// Organizations group several users. As entities, they can own resources such<br/>
        /// as pipelines or releases.
        /// </param>
        /// <param name="user">
        /// User describes an individual that interacts with Instill AI. It doesn't<br/>
        /// contain any private information about the user.
        /// </param>
        /// <param name="state">
        /// MembershipState describes the state of a user membership to an organization.<br/>
        ///  - MEMBERSHIP_STATE_ACTIVE: Active.<br/>
        ///  - MEMBERSHIP_STATE_PENDING: Pending, i.e., a request has been sent to the user to join an<br/>
        /// organization.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.UpdateOrganizationMembershipResponse> UpdateOrganizationMembershipAsync(
            string organizationId,
            string userId,
            string updateMask,
            string role,
            string? name = default,
            global::Instill.Organization? organization = default,
            global::Instill.User? user = default,
            global::Instill.MembershipState? state = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Instill.OrganizationMembership
            {
                Name = name,
                Role = role,
                Organization = organization,
                User = user,
                State = state,
            };

            return await UpdateOrganizationMembershipAsync(
                organizationId: organizationId,
                userId: userId,
                updateMask: updateMask,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}