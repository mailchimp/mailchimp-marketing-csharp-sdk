namespace Mailchimp.Marketing;

public partial interface ILandingPagesClient
{
    /// <summary>
    /// Get all landing pages.
    /// </summary>
    WithRawResponseTask<ListLandingPagesResponse> ListAsync(
        ListLandingPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an unpublished and contentless Mailchimp landing page.
    /// </summary>
    WithRawResponseTask<LandingPage> CreateAsync(
        CreateLandingPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific page.
    /// </summary>
    WithRawResponseTask<LandingPage> GetAsync(
        GetLandingPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a landing page.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteLandingPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a landing page.
    /// </summary>
    WithRawResponseTask<LandingPage> UpdateAsync(
        UpdateLandingPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Publish a landing page that is in draft, unpublished, or has been previously published and edited.
    /// </summary>
    WithRawResponseTask CreateActionPublishAsync(
        CreateActionPublishLandingPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unpublish a landing page that is in draft or has been published.
    /// </summary>
    WithRawResponseTask CreateActionUnpublishAsync(
        CreateActionUnpublishLandingPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the the HTML for your landing page.
    /// </summary>
    WithRawResponseTask<ListContentLandingPagesResponse> ListContentAsync(
        ListContentLandingPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
