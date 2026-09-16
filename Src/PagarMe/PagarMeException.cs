using System;

namespace PagarMe;

/// <summary>
/// Base exception for every failure raised by the SDK, including configuration, transport and serialization errors.
/// Failures reported by the API itself are raised as <see cref="PagarMeApiException" />.
/// </summary>
public class PagarMeException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PagarMeException" /> class.
    /// </summary>
    public PagarMeException() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="PagarMeException" /> class with a message.
    /// </summary>
    /// <param name="message">The error message.</param>
    public PagarMeException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="PagarMeException" /> class with a message and an inner exception.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="innerException">The exception that caused this one.</param>
    public PagarMeException(string message, Exception? innerException)
        : base(message, innerException) { }
}
