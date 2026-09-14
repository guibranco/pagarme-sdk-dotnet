using System;

namespace PagarMe.Models;

/// <summary>
/// A short lived card token.
/// </summary>
public class Token
{
    /// <summary>
    /// The token identifier (<c>token_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The token type (<c>card</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// When the token was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the token expires. Tokens are valid for a short period only.
    /// </summary>
    public DateTimeOffset? ExpiresAt { get; set; }

    /// <summary>
    /// Masked information about the tokenized card.
    /// </summary>
    public TokenCard? Card { get; set; }
}
