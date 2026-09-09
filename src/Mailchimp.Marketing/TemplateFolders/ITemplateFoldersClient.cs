using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface ITemplateFoldersClient
{
    /// <summary>
    /// Get all folders used to organize templates.
    /// </summary>
    Task<Pager<ListTemplateFoldersResponseFoldersItem>> ListAsync(
        ListTemplateFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new template folder.
    /// </summary>
    WithRawResponseTask<CreateTemplateFoldersResponse> CreateAsync(
        CreateTemplateFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific folder used to organize templates.
    /// </summary>
    WithRawResponseTask<GetTemplateFoldersResponse> GetAsync(
        GetTemplateFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific template folder, and mark all the templates in the folder as 'unfiled'.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteTemplateFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific folder used to organize templates.
    /// </summary>
    WithRawResponseTask<UpdateTemplateFoldersResponse> UpdateAsync(
        UpdateTemplateFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
