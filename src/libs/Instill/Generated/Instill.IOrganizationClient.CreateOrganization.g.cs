#nullable enable

namespace Instill
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Create an organization<br/>
        /// Creates an organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.CreateOrganizationResponse> CreateOrganizationAsync(
            global::Instill.Organization request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an organization<br/>
        /// Creates an organization.
        /// </summary>
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
        /// <param name="owner">
        /// The user that owns the organization.
        /// </param>
        /// <param name="profile">
        /// Profile.
        /// </param>
        /// <param name="permission"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.CreateOrganizationResponse> CreateOrganizationAsync(
            global::Instill.OrganizationProfile profile,
            string? name = default,
            string? uid = default,
            string? id = default,
            global::System.DateTime? createTime = default,
            global::System.DateTime? updateTime = default,
            global::Instill.User? owner = default,
            global::Instill.Permission? permission = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}