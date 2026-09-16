namespace PagarMe.Models;

/// <summary>
/// Payment method identifiers accepted by the API.
/// </summary>
public static class PaymentMethods
{
    /// <summary>Credit card.</summary>
    public const string CreditCard = "credit_card";

    /// <summary>Debit card.</summary>
    public const string DebitCard = "debit_card";

    /// <summary>Boleto bancário.</summary>
    public const string Boleto = "boleto";

    /// <summary>Pix instant payment.</summary>
    public const string Pix = "pix";

    /// <summary>Voucher (meal/food cards).</summary>
    public const string Voucher = "voucher";

    /// <summary>Bank transfer.</summary>
    public const string BankTransfer = "bank_transfer";

    /// <summary>SafetyPay.</summary>
    public const string SafetyPay = "safety_pay";

    /// <summary>Hosted checkout page.</summary>
    public const string Checkout = "checkout";

    /// <summary>Cash, confirmed manually.</summary>
    public const string Cash = "cash";
}
