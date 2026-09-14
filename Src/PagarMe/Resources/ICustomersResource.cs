using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Operations on customers and on the cards and addresses stored on them.
/// </summary>
public interface ICustomersResource
{
    /// <summary>
    /// Creates a customer. <c>POST /customers</c>.
    /// </summary>
    /// <param name="request">The customer to create.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The created customer.</returns>
    Task<Customer> CreateAsync(
        CustomerRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a customer. <c>GET /customers/{customer_id}</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The customer.</returns>
    Task<Customer> GetAsync(string customerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a customer. <c>PUT /customers/{customer_id}</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="request">The new customer data.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated customer.</returns>
    Task<Customer> UpdateAsync(
        string customerId,
        CustomerRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists customers. <c>GET /customers</c>.
    /// </summary>
    /// <param name="request">Optional filters and paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of customers.</returns>
    Task<PagedResponse<Customer>> ListAsync(
        ListCustomersRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Stores a card on a customer. <c>POST /customers/{customer_id}/cards</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="request">The card data or token.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The stored card.</returns>
    Task<Card> CreateCardAsync(
        string customerId,
        CardRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a stored card. <c>GET /customers/{customer_id}/cards/{card_id}</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="cardId">The card identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The card.</returns>
    Task<Card> GetCardAsync(
        string customerId,
        string cardId,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the cards stored on a customer. <c>GET /customers/{customer_id}/cards</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="request">Optional paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of cards.</returns>
    Task<PagedResponse<Card>> ListCardsAsync(
        string customerId,
        ListRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a stored card. <c>PUT /customers/{customer_id}/cards/{card_id}</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="cardId">The card identifier.</param>
    /// <param name="request">The fields to change.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated card.</returns>
    Task<Card> UpdateCardAsync(
        string customerId,
        string cardId,
        UpdateCardRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a stored card. <c>DELETE /customers/{customer_id}/cards/{card_id}</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="cardId">The card identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The deleted card.</returns>
    Task<Card> DeleteCardAsync(
        string customerId,
        string cardId,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Renews an expired card using the brand's account updater.
    /// <c>POST /customers/{customer_id}/cards/{card_id}/renew</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="cardId">The card identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The renewed card.</returns>
    Task<Card> RenewCardAsync(
        string customerId,
        string cardId,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds an address to a customer. <c>POST /customers/{customer_id}/addresses</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="request">The address.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The created address.</returns>
    Task<Address> CreateAddressAsync(
        string customerId,
        AddressRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves an address. <c>GET /customers/{customer_id}/addresses/{address_id}</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="addressId">The address identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The address.</returns>
    Task<Address> GetAddressAsync(
        string customerId,
        string addressId,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the addresses of a customer. <c>GET /customers/{customer_id}/addresses</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="request">Optional paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of addresses.</returns>
    Task<PagedResponse<Address>> ListAddressesAsync(
        string customerId,
        ListRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates an address. <c>PUT /customers/{customer_id}/addresses/{address_id}</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="addressId">The address identifier.</param>
    /// <param name="request">The new address data.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated address.</returns>
    Task<Address> UpdateAddressAsync(
        string customerId,
        string addressId,
        AddressRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes an address. <c>DELETE /customers/{customer_id}/addresses/{address_id}</c>.
    /// </summary>
    /// <param name="customerId">The customer identifier.</param>
    /// <param name="addressId">The address identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The deleted address.</returns>
    Task<Address> DeleteAddressAsync(
        string customerId,
        string addressId,
        CancellationToken cancellationToken = default
    );
}
