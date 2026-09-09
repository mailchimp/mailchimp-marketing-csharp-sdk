using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IReportsClient
{
    /// <summary>
    /// Get campaign reports.
    /// </summary>
    Task<Pager<CampaignReport>> ListAsync(
        ListReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get report details for a specific sent campaign.
    /// </summary>
    WithRawResponseTask<CampaignReport> GetAsync(
        GetReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a list of abuse complaints for a specific campaign.
    /// </summary>
    WithRawResponseTask<ListAbuseReportsReportsResponse> ListAbuseReportsAsync(
        ListAbuseReportsReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific abuse report for a campaign.
    /// </summary>
    WithRawResponseTask<AbuseComplaint> GetAbuseReportAsync(
        GetAbuseReportReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get feedback based on a campaign's statistics. Advice feedback is based on campaign stats like opens, clicks, unsubscribes, bounces, and more.
    /// </summary>
    WithRawResponseTask<ListAdviceReportsResponse> ListAdviceAsync(
        ListAdviceReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about clicks on specific links in your Mailchimp campaigns.
    /// </summary>
    Task<Pager<ClickDetailReport>> ListClickDetailsAsync(
        ListClickDetailsReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get click details for a specific link in a campaign.
    /// </summary>
    WithRawResponseTask<ClickDetailReport> GetClickDetailAsync(
        GetClickDetailReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about list members who clicked on a specific link in a campaign.
    /// </summary>
    Task<Pager<ClickDetailMember>> ListClickDetailMembersAsync(
        ListClickDetailMembersReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific subscriber who clicked a link in a specific campaign.
    /// </summary>
    WithRawResponseTask<ClickDetailMember> GetClickDetailMemberAsync(
        GetClickDetailMemberReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get statistics for the top-performing email domains in a campaign.
    /// </summary>
    WithRawResponseTask<ListDomainPerformanceReportsResponse> ListDomainPerformanceAsync(
        ListDomainPerformanceReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get breakdown of product activity for a campaign
    /// </summary>
    Task<
        Pager<ListEcommerceProductActivityReportsResponseProductsItem>
    > ListEcommerceProductActivityAsync(
        ListEcommerceProductActivityReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a summary of social activity for the campaign, tracked by EepURL.
    /// </summary>
    WithRawResponseTask<ListEepurlReportsResponse> ListEepurlAsync(
        ListEepurlReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a list of member's subscriber activity in a specific campaign.
    /// </summary>
    Task<Pager<EmailActivity>> ListEmailActivityAsync(
        ListEmailActivityReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a specific list member's activity in a campaign including opens, clicks, and bounces.
    /// </summary>
    WithRawResponseTask<EmailActivity> GetEmailActivityAsync(
        GetEmailActivityReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get top open locations for a specific campaign.
    /// </summary>
    Task<Pager<ListLocationsReportsResponseLocationsItem>> ListLocationsAsync(
        ListLocationsReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get detailed information about any campaign emails that were opened by a list member.
    /// </summary>
    Task<Pager<OpenActivity>> ListOpenDetailsAsync(
        ListOpenDetailsReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific subscriber who opened a campaign.
    /// </summary>
    WithRawResponseTask<OpenActivity> GetOpenDetailAsync(
        GetOpenDetailReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about campaign recipients.
    /// </summary>
    Task<Pager<SentTo>> ListSentToAsync(
        ListSentToReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific campaign recipient.
    /// </summary>
    WithRawResponseTask<SentTo> GetSentToAsync(
        GetSentToReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a list of reports with child campaigns for a specific parent campaign.
    /// </summary>
    WithRawResponseTask<ListSubReportsReportsResponse> ListSubReportsAsync(
        ListSubReportsReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about members who have unsubscribed from a specific campaign.
    /// </summary>
    Task<Pager<Unsubscribes>> ListUnsubscribedAsync(
        ListUnsubscribedReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific list member who unsubscribed from a campaign.
    /// </summary>
    WithRawResponseTask<Unsubscribes> GetUnsubscribedAsync(
        GetUnsubscribedReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
