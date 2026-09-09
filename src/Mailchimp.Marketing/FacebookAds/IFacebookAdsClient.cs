using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IFacebookAdsClient
{
    /// <summary>
    /// Get list of Facebook ads.
    /// </summary>
    Task<Pager<FacebookAds>> ListAsync(
        ListFacebookAdsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get details of a Facebook ad.
    /// </summary>
    WithRawResponseTask<FacebookAds> GetAsync(
        GetFacebookAdsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
