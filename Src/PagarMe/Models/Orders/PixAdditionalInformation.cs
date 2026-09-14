namespace PagarMe.Models;

/// <summary>
/// A name/value pair displayed to the payer of a Pix charge.
/// </summary>
public class PixAdditionalInformation
{
    /// <summary>
    /// The label.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The value.
    /// </summary>
    public string? Value { get; set; }
}
