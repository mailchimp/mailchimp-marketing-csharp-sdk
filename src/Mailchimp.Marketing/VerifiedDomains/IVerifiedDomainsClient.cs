namespace Mailchimp.Marketing;

public partial interface IVerifiedDomainsClient
{
    /// <summary>
    /// Get all of the sending domains on the account.
    /// </summary>
    WithRawResponseTask<ListVerifiedDomainsResponse> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a domain to the account.
    /// </summary>
    WithRawResponseTask<CreateVerifiedDomainsResponse> CreateAsync(
        CreateVerifiedDomainsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the details for a single domain on the account.
    /// </summary>
    WithRawResponseTask<GetVerifiedDomainsResponse> GetAsync(
        GetVerifiedDomainsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a verified domain from the account.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteVerifiedDomainsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Verify a domain for sending.
    /// </summary>
    WithRawResponseTask<CreateActionVerifyVerifiedDomainsResponse> CreateActionVerifyAsync(
        CreateActionVerifyVerifiedDomainsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
