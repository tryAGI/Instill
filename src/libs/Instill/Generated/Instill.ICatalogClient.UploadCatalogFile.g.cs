#nullable enable

namespace Instill
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Create a file
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UploadCatalogFileResponse> UploadCatalogFileAsync(
            string namespaceId,
            string catalogId,
            global::Instill.File request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a file
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UploadCatalogFileResponse> UploadCatalogFileAsync(
            string namespaceId,
            string catalogId,
            string name,
            global::Instill.FileType type,
            string? content = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}