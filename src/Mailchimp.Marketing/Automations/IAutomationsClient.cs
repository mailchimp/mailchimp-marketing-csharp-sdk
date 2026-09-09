using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IAutomationsClient
{
    /// <summary>
    /// Get a summary of an account's classic automations.
    /// </summary>
    Task<Pager<AutomationWorkflow>> ListAsync(
        ListAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new classic automation in your Mailchimp account.
    /// </summary>
    WithRawResponseTask<AutomationWorkflow> CreateAsync(
        CreateAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a summary of an individual classic automation workflow's settings and content. The `trigger_settings` object returns information for the first email in the workflow.
    /// </summary>
    WithRawResponseTask<AutomationWorkflow> GetAsync(
        GetAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archiving will permanently end your automation and keep the report data. You’ll be able to replicate your archived automation, but you can’t restart it.
    /// </summary>
    WithRawResponseTask CreateActionArchiveAsync(
        CreateActionArchiveAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Pause all emails in a specific classic automation workflow.
    /// </summary>
    WithRawResponseTask CreateActionPauseAllEmailAsync(
        CreateActionPauseAllEmailAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Start all emails in a classic automation workflow.
    /// </summary>
    WithRawResponseTask CreateActionStartAllEmailAsync(
        CreateActionStartAllEmailAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a summary of the emails in a classic automation workflow.
    /// </summary>
    WithRawResponseTask<ListEmailsAutomationsResponse> ListEmailsAsync(
        ListEmailsAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about an individual classic automation workflow email.
    /// </summary>
    WithRawResponseTask<AutomationWorkflowEmail> GetEmailAsync(
        GetEmailAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes an individual classic automation workflow email. Emails from certain workflow types, including the Abandoned Cart Email (abandonedCart) and Product Retargeting Email (abandonedBrowse) Workflows, cannot be deleted.
    /// </summary>
    WithRawResponseTask DeleteEmailAsync(
        DeleteEmailAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update settings for a classic automation workflow email.  Only works with workflows of type: abandonedBrowse, abandonedCart, emailFollowup, or singleWelcome.
    /// </summary>
    WithRawResponseTask<AutomationWorkflowEmail> UpdateEmailAsync(
        UpdateEmailAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Pause an automated email.
    /// </summary>
    WithRawResponseTask CreateEmailActionPauseAsync(
        CreateEmailActionPauseAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Start an automated email.
    /// </summary>
    WithRawResponseTask CreateEmailActionStartAsync(
        CreateEmailActionStartAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a classic automation email queue.
    /// </summary>
    WithRawResponseTask<ListEmailQueueAutomationsResponse> ListEmailQueueAsync(
        ListEmailQueueAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Manually add a subscriber to a workflow, bypassing the default trigger settings. You can also use this endpoint to trigger a series of automated emails in an API 3.0 workflow type.
    /// </summary>
    WithRawResponseTask<SubscriberInAutomationQueue> CreateEmailQueueAsync(
        CreateEmailQueueAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific subscriber in a classic automation email queue.
    /// </summary>
    WithRawResponseTask<SubscriberInAutomationQueue> GetEmailQueueAsync(
        GetEmailQueueAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about subscribers who were removed from a classic automation workflow.
    /// </summary>
    WithRawResponseTask<ListRemovedSubscribersAutomationsResponse> ListRemovedSubscribersAsync(
        ListRemovedSubscribersAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a subscriber from a specific classic automation workflow. You can remove a subscriber at any point in an automation workflow, regardless of how many emails they've been sent from that workflow. Once they're removed, they can never be added back to the same workflow.
    /// </summary>
    WithRawResponseTask<SubscriberRemovedFromAutomationWorkflow> CreateRemovedSubscriberAsync(
        CreateRemovedSubscriberAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific subscriber who was removed from a classic automation workflow.
    /// </summary>
    WithRawResponseTask<SubscriberRemovedFromAutomationWorkflow> GetRemovedSubscriberAsync(
        GetRemovedSubscriberAutomationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
