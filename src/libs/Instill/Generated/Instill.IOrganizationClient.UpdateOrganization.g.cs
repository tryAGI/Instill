#nullable enable

namespace Instill
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Update an organization<br/>
        /// Accesses and updates an organization by ID.<br/>
        /// In REST requests, only the supplied organization fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateOrganizationResponse> UpdateOrganizationAsync(
            string organizationId,
            global::Instill.Organization request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an organization<br/>
        /// Accesses and updates an organization by ID.<br/>
        /// In REST requests, only the supplied organization fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="name">
        /// The name of the organization, defined by its ID.<br/>
        /// - Format: `organization/{organization.id}`.
        /// </param>
        /// <param name="uid">
        /// Organization UUID.
        /// </param>
        /// <param name="id">
        /// Resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.<br/>
        /// Note that the ID can be updated.
        /// </param>
        /// <param name="createTime">
        /// Creation time.
        /// </param>
        /// <param name="updateTime">
        /// Update time.
        /// </param>
        /// <param name="permission">
        /// Permission defines how a resource can be used.
        /// </param>
        /// <param name="profile">
        /// OrganizationProfile describes the public data of an organization.
        /// </param>
        /// <param name="owner">
        /// User describes an individual that interacts with Instill AI. It doesn't<br/>
        /// contain any private information about the user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateOrganizationResponse> UpdateOrganizationAsync(
            string organizationId,
            global::Instill.OrganizationProfile profile,
            string? name = default,
            string? uid = default,
            string? id = default,
            global::System.DateTime? createTime = default,
            global::System.DateTime? updateTime = default,
            global::Instill.Permission? permission = default,
            global::Instill.User? owner = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}