namespace Mailchimp.Marketing;

public partial interface IRootClient
{
    /// <summary>
    /// Get links to all other resources available in the API.
    /// </summary>
    WithRawResponseTask<ListRootResponse> ListAsync(
        ListRootRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
