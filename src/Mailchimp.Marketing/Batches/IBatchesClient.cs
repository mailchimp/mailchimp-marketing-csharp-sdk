using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IBatchesClient
{
    /// <summary>
    /// Get a summary of batch requests that have been made.
    /// </summary>
    Task<Pager<Batch>> ListAsync(
        ListBatchesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Begin processing a batch operations request.
    /// </summary>
    WithRawResponseTask<Batch> CreateAsync(
        CreateBatchesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the status of a batch request.
    /// </summary>
    WithRawResponseTask<Batch> GetAsync(
        GetBatchesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Stops a batch request from running. Since only one batch request is run at a time, this can be used to cancel a long running request. The results of any completed operations will not be available after this call.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteBatchesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
