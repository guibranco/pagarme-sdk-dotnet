namespace PagarMe.Models;

/// <summary>
/// The person who paid a Pix charge.
/// </summary>
public class PixPayer
{
    /// <summary>
    /// The payer name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The payer document number.
    /// </summary>
    public string? Document { get; set; }

    /// <summary>
    /// The payer document type.
    /// </summary>
    public string? DocumentType { get; set; }
}
