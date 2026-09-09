using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IConnectedSitesClient
{
    /// <summary>
    /// Get all connected sites in an account.
    /// </summary>
    Task<Pager<ConnectedSite>> ListAsync(
        ListConnectedSitesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new Mailchimp connected site.
    /// </summary>
    WithRawResponseTask<ConnectedSite> CreateAsync(
        CreateConnectedSitesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific connected site.
    /// </summary>
    WithRawResponseTask<ConnectedSite> GetAsync(
        GetConnectedSitesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a connected site from your Mailchimp account.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteConnectedSitesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Verify that the connected sites script has been installed, either via the script URL or fragment.
    /// </summary>
    WithRawResponseTask CreateActionVerifyScriptInstallationAsync(
        CreateActionVerifyScriptInstallationConnectedSitesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
