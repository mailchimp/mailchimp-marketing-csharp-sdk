namespace Mailchimp.Marketing;

public partial interface ISearchMembersClient
{
    /// <summary>
    /// Search for list members. This search can be restricted to a specific list, or can be used to search across all lists in an account.
    /// </summary>
    WithRawResponseTask<ListSearchMembersResponse> ListAsync(
        ListSearchMembersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
