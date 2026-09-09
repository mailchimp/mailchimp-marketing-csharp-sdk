namespace Mailchimp.Marketing;

public partial interface ISearchCampaignsClient
{
    /// <summary>
    /// Search all campaigns for the specified query terms.
    /// </summary>
    WithRawResponseTask<ListSearchCampaignsResponse> ListAsync(
        ListSearchCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
