using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="ICustomersResource" />
internal sealed class CustomersResource : ICustomersResource
{
    private const string BasePath = "customers";
    private const string CardsSegment = "cards";
    private const string AddressesSegment = "addresses";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomersResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public CustomersResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Customer> CreateAsync(
        CustomerRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Customer>(BasePath, request, null, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Customer> GetAsync(string customerId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        return _connection.GetAsync<Customer>(
            ApiPath.Join(BasePath, customerId),
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Customer> UpdateAsync(
        string customerId,
        CustomerRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNull(request, nameof(request));
        return _connection.PutAsync<Customer>(
            ApiPath.Join(BasePath, customerId),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<PagedResponse<Customer>> ListAsync(
        ListCustomersRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        return _connection.GetAsync<PagedResponse<Customer>>(BasePath, request, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Card> CreateCardAsync(
        string customerId,
        CardRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Card>(
            ApiPath.Join(BasePath, customerId, CardsSegment),
            request,
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Card> GetCardAsync(
        string customerId,
        string cardId,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNullOrWhiteSpace(cardId, nameof(cardId));
        return _connection.GetAsync<Card>(
            ApiPath.Join(BasePath, customerId, CardsSegment, cardId),
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<PagedResponse<Card>> ListCardsAsync(
        string customerId,
        ListRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        return _connection.GetAsync<PagedResponse<Card>>(
            ApiPath.Join(BasePath, customerId, CardsSegment),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Card> UpdateCardAsync(
        string customerId,
        string cardId,
        UpdateCardRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNullOrWhiteSpace(cardId, nameof(cardId));
        Guard.NotNull(request, nameof(request));
        return _connection.PutAsync<Card>(
            ApiPath.Join(BasePath, customerId, CardsSegment, cardId),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Card> DeleteCardAsync(
        string customerId,
        string cardId,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNullOrWhiteSpace(cardId, nameof(cardId));
        return _connection.DeleteAsync<Card>(
            ApiPath.Join(BasePath, customerId, CardsSegment, cardId),
            null,
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Card> RenewCardAsync(
        string customerId,
        string cardId,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNullOrWhiteSpace(cardId, nameof(cardId));
        return _connection.PostAsync<Card>(
            ApiPath.Join(BasePath, customerId, CardsSegment, cardId, "renew"),
            null,
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Address> CreateAddressAsync(
        string customerId,
        AddressRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Address>(
            ApiPath.Join(BasePath, customerId, AddressesSegment),
            request,
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Address> GetAddressAsync(
        string customerId,
        string addressId,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNullOrWhiteSpace(addressId, nameof(addressId));
        return _connection.GetAsync<Address>(
            ApiPath.Join(BasePath, customerId, AddressesSegment, addressId),
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<PagedResponse<Address>> ListAddressesAsync(
        string customerId,
        ListRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        return _connection.GetAsync<PagedResponse<Address>>(
            ApiPath.Join(BasePath, customerId, AddressesSegment),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Address> UpdateAddressAsync(
        string customerId,
        string addressId,
        AddressRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNullOrWhiteSpace(addressId, nameof(addressId));
        Guard.NotNull(request, nameof(request));
        return _connection.PutAsync<Address>(
            ApiPath.Join(BasePath, customerId, AddressesSegment, addressId),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Address> DeleteAddressAsync(
        string customerId,
        string addressId,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(customerId, nameof(customerId));
        Guard.NotNullOrWhiteSpace(addressId, nameof(addressId));
        return _connection.DeleteAsync<Address>(
            ApiPath.Join(BasePath, customerId, AddressesSegment, addressId),
            null,
            null,
            cancellationToken
        );
    }
}
