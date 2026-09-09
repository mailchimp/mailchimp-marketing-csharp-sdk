using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IFileManagerClient
{
    /// <summary>
    /// Get information about the file-manager endpoint's resources
    /// </summary>
    WithRawResponseTask<IEnumerable<ListFileManagerResponseItem>> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a list of available images and files stored in the File Manager for the account.
    /// </summary>
    Task<Pager<GalleryFile>> ListFilesAsync(
        ListFilesFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Upload a new image or file to the File Manager.
    /// </summary>
    WithRawResponseTask<GalleryFile> CreateFileAsync(
        CreateFileFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific file in the File Manager.
    /// </summary>
    WithRawResponseTask<GalleryFile> GetFileAsync(
        GetFileFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a specific file from the File Manager.
    /// </summary>
    WithRawResponseTask DeleteFileAsync(
        DeleteFileFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a file in the File Manager.
    /// </summary>
    WithRawResponseTask<GalleryFile> UpdateFileAsync(
        UpdateFileFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a list of all folders in the File Manager.
    /// </summary>
    Task<Pager<ListFoldersFileManagerResponseFoldersItem>> ListFoldersAsync(
        ListFoldersFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new folder in the File Manager.
    /// </summary>
    WithRawResponseTask<CreateFolderFileManagerResponse> CreateFolderAsync(
        CreateFolderFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific folder in the File Manager.
    /// </summary>
    WithRawResponseTask<GetFolderFileManagerResponse> GetFolderAsync(
        GetFolderFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific folder in the File Manager.
    /// </summary>
    WithRawResponseTask DeleteFolderAsync(
        DeleteFolderFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific File Manager folder.
    /// </summary>
    WithRawResponseTask<UpdateFolderFileManagerResponse> UpdateFolderAsync(
        UpdateFolderFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a list of available images and files stored in this folder.
    /// </summary>
    Task<Pager<GalleryFile>> ListFolderFilesAsync(
        ListFolderFilesFileManagerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
