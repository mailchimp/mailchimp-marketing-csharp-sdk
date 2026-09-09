using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface ISmsCampaignsClient
{
    /// <summary>
    /// Get all SMS campaigns in an account.
    /// </summary>
    Task<Pager<SmsCampaign>> ListAsync(
        ListSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new SMS campaign.
    /// </summary>
    WithRawResponseTask<SmsCampaign> CreateAsync(
        CreateSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the details for a single SMS campaign.
    /// </summary>
    WithRawResponseTask<SmsCampaign> GetAsync(
        GetSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a campaign from your Mailchimp account.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an SMS campaign.
    /// </summary>
    WithRawResponseTask<SmsCampaign> UpdateAsync(
        UpdateSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel a scheduled or sending SMS campaign.
    /// </summary>
    WithRawResponseTask CreateActionCancelSendAsync(
        CreateActionCancelSendSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Schedule an SMS campaign for delivery.
    /// </summary>
    WithRawResponseTask CreateActionScheduleAsync(
        CreateActionScheduleSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Send an SMS campaign.
    /// </summary>
    WithRawResponseTask CreateActionSendAsync(
        CreateActionSendSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the content for an SMS campaign.
    /// </summary>
    WithRawResponseTask<SmsCampaignContent> GetContentAsync(
        GetContentSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set the content for an SMS campaign.
    /// </summary>
    WithRawResponseTask<SmsCampaignContent> UpsertContentAsync(
        UpsertContentSmsCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
