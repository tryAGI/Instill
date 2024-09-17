#nullable enable

namespace Instill
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Ask a question
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.QuestionAnsweringResponse> QuestionAnsweringAsync(
            string namespaceId,
            string catalogId,
            global::Instill.QuestionAnsweringBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Ask a question
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="question"></param>
        /// <param name="topK"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.QuestionAnsweringResponse> QuestionAnsweringAsync(
            string namespaceId,
            string catalogId,
            string? question = default,
            int topK = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}