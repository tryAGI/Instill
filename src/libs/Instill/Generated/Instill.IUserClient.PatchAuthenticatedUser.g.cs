#nullable enable

namespace Instill
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Update the authenticated user<br/>
        /// Updates the information of the authenticated user.<br/>
        /// In REST requests, only the supplied user fields will be taken into account<br/>
        /// when updating the resource.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.PatchAuthenticatedUserResponse> PatchAuthenticatedUserAsync(
            global::Instill.AuthenticatedUser request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the authenticated user<br/>
        /// Updates the information of the authenticated user.<br/>
        /// In REST requests, only the supplied user fields will be taken into account<br/>
        /// when updating the resource.
        /// </summary>
        /// <param name="name">
        /// The name of the user, defined by its ID.<br/>
        /// - Format: `users/{user.id}`.
        /// </param>
        /// <param name="uid">
        /// User UUID. This field is optionally set by users on creation (it will be<br/>
        /// server-generated if unspecified).
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
        /// <param name="email">
        /// Email.
        /// </param>
        /// <param name="customerId">
        /// Stripe customer ID. This field is used in Instill Cloud.
        /// </param>
        /// <param name="role">
        /// Role.<br/>
        /// It must be one of the following allowed roles:<br/>
        /// - `manager`<br/>
        /// - `ai-researcher`<br/>
        /// - `ai-engineer`<br/>
        /// - `data-engineer`<br/>
        /// - `data-scientist`<br/>
        /// - `analytics-engineer`<br/>
        /// - `hobbyist`
        /// </param>
        /// <param name="newsletterSubscription">
        /// This defines whether the user is subscribed to Instill AI's newsletter.
        /// </param>
        /// <param name="cookieToken">
        /// Console cookie token.
        /// </param>
        /// <param name="profile">
        /// UserProfile describes the public data of a user.
        /// </param>
        /// <param name="onboardingStatus">
        /// OnboardingStatus describes the status of the user onboarding process.<br/>
        ///  - ONBOARDING_STATUS_IN_PROGRESS: In progress, i.e., the user has initiated the onboarding process<br/>
        /// but has not yet completed it.<br/>
        ///  - ONBOARDING_STATUS_COMPLETED: Completed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.PatchAuthenticatedUserResponse> PatchAuthenticatedUserAsync(
            string id,
            string email,
            bool newsletterSubscription,
            string? name = default,
            string? uid = default,
            global::System.DateTime? createTime = default,
            global::System.DateTime? updateTime = default,
            string? customerId = default,
            string? role = default,
            string? cookieToken = default,
            global::Instill.UserProfile? profile = default,
            global::Instill.OnboardingStatus? onboardingStatus = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}