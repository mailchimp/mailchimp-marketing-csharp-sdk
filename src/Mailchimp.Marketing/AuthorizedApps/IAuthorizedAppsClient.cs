using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IAuthorizedAppsClient
{
    /// <summary>
    /// Get a list of an account's registered, connected applications.
    /// </summary>
    Task<Pager<ListAuthorizedAppsResponseAppsItem>> ListAsync(
        ListAuthorizedAppsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific authorized application.
    /// </summary>
    WithRawResponseTask<GetAuthorizedAppsResponse> GetAsync(
        GetAuthorizedAppsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
