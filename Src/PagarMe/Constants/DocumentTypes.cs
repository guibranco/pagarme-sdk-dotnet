namespace PagarMe.Models;

/// <summary>
/// Customer document types.
/// </summary>
public static class DocumentTypes
{
    /// <summary>Brazilian individual taxpayer registry.</summary>
    public const string Cpf = "CPF";

    /// <summary>Brazilian company taxpayer registry.</summary>
    public const string Cnpj = "CNPJ";

    /// <summary>Passport, for foreign customers.</summary>
    public const string Passport = "PASSPORT";
}
