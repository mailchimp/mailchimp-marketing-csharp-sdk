using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IBatchWebhooksClient
{
    /// <summary>
    /// Get all webhooks that have been configured for batches.
    /// </summary>
    Task<Pager<BatchWebhook>> ListAsync(
        ListBatchWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Configure a webhook that will fire whenever any batch request completes processing.  You may only have a maximum of 20 batch webhooks.
    /// </summary>
    WithRawResponseTask<BatchWebhook> CreateAsync(
        CreateBatchWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific batch webhook.
    /// </summary>
    WithRawResponseTask<BatchWebhook> GetAsync(
        GetBatchWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a batch webhook. Webhooks will no longer be sent to the given URL.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteBatchWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a webhook that will fire whenever any batch request completes processing.
    /// </summary>
    WithRawResponseTask<BatchWebhook> UpdateAsync(
        UpdateBatchWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
