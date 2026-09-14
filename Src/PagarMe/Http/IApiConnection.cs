using System.Threading;
using System.Threading.Tasks;

namespace PagarMe.Http;

/// <summary>
/// Low level abstraction that sends requests to the API and maps the responses. Resources depend on this
/// interface so they can be tested without a real HTTP stack.
/// </summary>
internal interface IApiConnection
{
    /// <summary>
    /// Sends a request and deserializes the successful response body into <typeparamref name="TResponse" />.
    /// </summary>
    /// <typeparam name="TResponse">The type the JSON response is mapped to.</typeparam>
    /// <param name="request">The request to send.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The deserialized response.</returns>
    /// <exception cref="PagarMeApiException">The API answered with a non-successful status code.</exception>
    /// <exception cref="PagarMeException">The request could not be sent or the response could not be read.</exception>
    Task<TResponse> SendAsync<TResponse>(ApiRequest request, CancellationToken cancellationToken);
}
