using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface ICampaignFoldersClient
{
    /// <summary>
    /// Get all folders used to organize campaigns.
    /// </summary>
    Task<Pager<CampaignFoldersFoldersItem>> ListAsync(
        ListCampaignFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new campaign folder.
    /// </summary>
    WithRawResponseTask<CampaignFolders> CreateAsync(
        CreateCampaignFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific folder used to organize campaigns.
    /// </summary>
    WithRawResponseTask<GetCampaignFoldersResponse> GetAsync(
        GetCampaignFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific campaign folder, and mark all the campaigns in the folder as 'unfiled'.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteCampaignFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific folder used to organize campaigns.
    /// </summary>
    WithRawResponseTask<UpdateCampaignFoldersResponse> UpdateAsync(
        UpdateCampaignFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
