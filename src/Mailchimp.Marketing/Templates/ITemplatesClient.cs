using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface ITemplatesClient
{
    /// <summary>
    /// Get a list of an account's available templates.
    /// </summary>
    Task<Pager<TemplateInstance>> ListAsync(
        ListTemplatesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new template for the account. Only Classic templates are supported.
    /// </summary>
    WithRawResponseTask<TemplateInstance> CreateAsync(
        CreateTemplatesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific template.
    /// </summary>
    WithRawResponseTask<TemplateInstance> GetAsync(
        GetTemplatesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific template.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteTemplatesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update the name, HTML, or `folder_id` of an existing template.
    /// </summary>
    WithRawResponseTask<TemplateInstance> UpdateAsync(
        UpdateTemplatesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the sections that you can edit in a template, including each section's default content.
    /// </summary>
    WithRawResponseTask<ListDefaultContentTemplatesResponse> ListDefaultContentAsync(
        ListDefaultContentTemplatesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
