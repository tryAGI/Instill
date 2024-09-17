#nullable enable

namespace Instill
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get a user<br/>
        /// Returns the details of a user by their ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetUserResponse> GetUserAsync(
            string userId,
            global::Instill.GetUserView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}