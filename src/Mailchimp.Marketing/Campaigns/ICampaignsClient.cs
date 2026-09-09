using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface ICampaignsClient
{
    /// <summary>
    /// Get all campaigns in an account.
    /// </summary>
    Task<Pager<Campaigns>> ListAsync(
        ListCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new Mailchimp campaign.
    /// </summary>
    WithRawResponseTask<Campaign> CreateAsync(
        CreateCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific campaign.
    /// </summary>
    WithRawResponseTask<Campaign> GetAsync(
        GetCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a campaign from your Mailchimp account.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update some or all of the settings for a specific campaign.
    /// </summary>
    WithRawResponseTask<Campaign> UpdateAsync(
        UpdateCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel a Regular or Plain-Text Campaign after you send, before all of your recipients receive it. This feature is included with Mailchimp Pro.
    /// </summary>
    WithRawResponseTask CreateActionCancelSendAsync(
        CreateActionCancelSendCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove the guesswork for resending a campaign to certain segments. You can use this endpoint as a shortcut to replicate a campaign and resend it to common segments, such as those who didn't open the campaign, or any new subscribers since it was sent.
    /// </summary>
    WithRawResponseTask<Campaign> CreateActionCreateResendAsync(
        CreateActionCreateResendCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Pause an RSS-Driven campaign.
    /// </summary>
    WithRawResponseTask CreateActionPauseAsync(
        CreateActionPauseCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replicate a campaign in saved or send status.
    /// </summary>
    WithRawResponseTask<Campaign> CreateActionReplicateAsync(
        CreateActionReplicateCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Resume an RSS-Driven campaign.
    /// </summary>
    WithRawResponseTask CreateActionResumeAsync(
        CreateActionResumeCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Schedule a campaign for delivery. If you're using Multivariate Campaigns to test send times or sending RSS Campaigns, use the send action instead.
    /// </summary>
    WithRawResponseTask CreateActionScheduleAsync(
        CreateActionScheduleCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Send a Mailchimp campaign. For RSS Campaigns, the campaign will send according to its schedule. All other campaigns will send immediately.
    /// </summary>
    WithRawResponseTask CreateActionSendAsync(
        CreateActionSendCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Send a test email.
    /// </summary>
    WithRawResponseTask CreateActionTestAsync(
        CreateActionTestCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unschedule a scheduled campaign that hasn't started sending.
    /// </summary>
    WithRawResponseTask CreateActionUnscheduleAsync(
        CreateActionUnscheduleCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the the HTML and plain-text content for a campaign.
    /// </summary>
    WithRawResponseTask<CampaignContent> GetContentAsync(
        GetContentCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set the content for a campaign.
    /// </summary>
    WithRawResponseTask<CampaignContent> UpsertContentAsync(
        UpsertContentCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get team feedback while you're working together on a Mailchimp campaign.
    /// </summary>
    WithRawResponseTask<ListFeedbackCampaignsResponse> ListFeedbackAsync(
        ListFeedbackCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add feedback on a specific campaign.
    /// </summary>
    WithRawResponseTask<CreateFeedbackCampaignsResponse> CreateFeedbackAsync(
        CreateFeedbackCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a specific feedback message from a campaign.
    /// </summary>
    WithRawResponseTask<CampaignFeedback> GetFeedbackAsync(
        GetFeedbackCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a specific feedback message for a campaign.
    /// </summary>
    WithRawResponseTask DeleteFeedbackAsync(
        DeleteFeedbackCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific feedback message for a campaign.
    /// </summary>
    WithRawResponseTask<CampaignFeedback> UpdateFeedbackAsync(
        UpdateFeedbackCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Review the send checklist for a campaign, and resolve any issues before sending.
    /// </summary>
    WithRawResponseTask<ListSendChecklistCampaignsResponse> ListSendChecklistAsync(
        ListSendChecklistCampaignsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
