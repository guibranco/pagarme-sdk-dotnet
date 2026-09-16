using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Card tokenization. Tokens are created with the public key and carry no <c>Authorization</c> header,
/// so this endpoint can be called from front ends that must never see the secret key.
/// </summary>
public interface ITokensResource
{
    /// <summary>
    /// Tokenizes a card using the public key configured in <see cref="PagarMeClientOptions.PublicKey" />.
    /// <c>POST /tokens?appId={public_key}</c>.
    /// </summary>
    /// <param name="request">The card to tokenize.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The short lived token.</returns>
    /// <exception cref="PagarMeException">No public key is configured.</exception>
    Task<Token> CreateAsync(
        CreateTokenRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Tokenizes a card using an explicit public key. <c>POST /tokens?appId={public_key}</c>.
    /// </summary>
    /// <param name="request">The card to tokenize.</param>
    /// <param name="publicKey">The public key (<c>pk_...</c>).</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The short lived token.</returns>
    Task<Token> CreateAsync(
        CreateTokenRequest request,
        string publicKey,
        CancellationToken cancellationToken = default
    );
}
