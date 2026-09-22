namespace Mailchimp.Marketing;

public partial interface IAudiencesClient
{
    /// <summary>
    /// Get a list of omni-channel contacts for a given audience.
    /// </summary>
    WithRawResponseTask<GetAudienceContactListResponse> GetAudienceContactListAsync(
        GetAudienceContactListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new omni-channel contact for an audience.
    /// </summary>
    WithRawResponseTask<AudiencesContact> CreateAudienceContactAsync(
        CreateAudienceContactRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a specific omni-channel contact in an audience.
    /// </summary>
    WithRawResponseTask<AudiencesContact> GetAudienceContactAsync(
        GetAudienceContactRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing omni-channel contact.
    /// </summary>
    WithRawResponseTask<AudiencesContact> PatchAudienceContactAsync(
        PatchAudienceContactRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archives a Contact.
    /// </summary>
    WithRawResponseTask PostAudiencesContactsActionsArchiveAsync(
        PostAudiencesContactsActionsArchiveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Forgets a Contact.
    /// </summary>
    WithRawResponseTask PostAudiencesContactsActionsForgetAsync(
        PostAudiencesContactsActionsForgetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
