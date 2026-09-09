using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IActivityFeedClient
{
    /// <summary>
    /// Get information about the activity feed endpoint's resources.
    /// </summary>
    WithRawResponseTask<IEnumerable<ListActivityFeedResponseItem>> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the Chimp Chatter for this account ordered by most recent.
    /// </summary>
    Task<Pager<ListChimpChatterActivityFeedResponseChimpChatterItem>> ListChimpChatterAsync(
        ListChimpChatterActivityFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
