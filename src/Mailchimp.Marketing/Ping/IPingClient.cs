namespace Mailchimp.Marketing;

public partial interface IPingClient
{
    /// <summary>
    /// A health check for the API that won't return any account-specific information.
    /// </summary>
    WithRawResponseTask<ListPingResponse> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
