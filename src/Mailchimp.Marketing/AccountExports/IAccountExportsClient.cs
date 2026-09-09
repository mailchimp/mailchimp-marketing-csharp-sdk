using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IAccountExportsClient
{
    /// <summary>
    /// Get a list of account exports for a given account.
    /// </summary>
    Task<Pager<ListAccountExportsResponseExportsItem>> ListAsync(
        ListAccountExportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new account export in your Mailchimp account.
    /// </summary>
    WithRawResponseTask<CreateAccountExportsResponse> CreateAsync(
        CreateAccountExportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific account export.
    /// </summary>
    WithRawResponseTask<GetAccountExportsResponse> GetAsync(
        GetAccountExportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
