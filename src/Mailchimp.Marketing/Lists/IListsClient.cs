using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IListsClient
{
    /// <summary>
    /// Get information about all lists in the account.
    /// </summary>
    Task<Pager<SubscriberList>> ListAsync(
        ListListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new list in your Mailchimp account.
    /// </summary>
    WithRawResponseTask<SubscriberList> CreateAsync(
        CreateListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific list in your Mailchimp account. Results include list members who have signed up but haven't confirmed their subscription yet and unsubscribed or cleaned.
    /// </summary>
    WithRawResponseTask<SubscriberList> GetAsync(
        GetListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Batch subscribe or unsubscribe list members.
    /// </summary>
    WithRawResponseTask<BatchSubscribeOrUnsubscribeListsResponse> BatchSubscribeOrUnsubscribeAsync(
        BatchSubscribeOrUnsubscribeListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a list from your Mailchimp account. If you delete a list, you'll lose the list history—including subscriber activity, unsubscribes, complaints, and bounces. You’ll also lose subscribers’ email addresses, unless you exported and backed up your list.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update the settings for a specific list.
    /// </summary>
    WithRawResponseTask<SubscriberList> UpdateAsync(
        UpdateListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get all abuse reports for a specific list.
    /// </summary>
    Task<Pager<ListsAbuseReports>> ListAbuseReportsAsync(
        ListAbuseReportsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get details about a specific abuse report.
    /// </summary>
    WithRawResponseTask<ListsAbuseReports> GetAbuseReportAsync(
        GetAbuseReportListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get up to the previous 180 days of daily detailed aggregated activity stats for a list, not including Automation activity.
    /// </summary>
    Task<Pager<ListActivityListsResponseActivityItem>> ListActivityAsync(
        ListActivityListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a list of the top email clients based on user-agent strings.
    /// </summary>
    WithRawResponseTask<ListClientsListsResponse> ListClientsAsync(
        ListClientsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a month-by-month summary of a specific list's growth activity.
    /// </summary>
    Task<Pager<GrowthHistory>> ListGrowthHistoryAsync(
        ListGrowthHistoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a summary of a specific list's growth activity for a specific month and year.
    /// </summary>
    WithRawResponseTask<GrowthHistory> GetGrowthHistoryAsync(
        GetGrowthHistoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a list's interest categories.
    /// </summary>
    Task<Pager<InterestCategory>> ListInterestCategoriesAsync(
        ListInterestCategoriesListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new interest category.
    /// </summary>
    WithRawResponseTask<InterestCategory> CreateInterestCategoryAsync(
        CreateInterestCategoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific interest category.
    /// </summary>
    WithRawResponseTask<InterestCategory> GetInterestCategoryAsync(
        GetInterestCategoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific interest category.
    /// </summary>
    WithRawResponseTask DeleteInterestCategoryAsync(
        DeleteInterestCategoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific interest category.
    /// </summary>
    WithRawResponseTask<InterestCategory> UpdateInterestCategoryAsync(
        UpdateInterestCategoryListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a list of this category's interests.
    /// </summary>
    Task<Pager<Interest>> ListInterestCategoryInterestsAsync(
        ListInterestCategoryInterestsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new interest or 'group name' for a specific category.
    /// </summary>
    WithRawResponseTask<Interest> CreateInterestCategoryInterestAsync(
        CreateInterestCategoryInterestListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get interests or 'group names' for a specific category.
    /// </summary>
    WithRawResponseTask<Interest> GetInterestCategoryInterestAsync(
        GetInterestCategoryInterestListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete interests or group names in a specific category.
    /// </summary>
    WithRawResponseTask DeleteInterestCategoryInterestAsync(
        DeleteInterestCategoryInterestListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update interests or 'group names' for a specific category.
    /// </summary>
    WithRawResponseTask<Interest> UpdateInterestCategoryInterestAsync(
        UpdateInterestCategoryInterestListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the locations (countries) that the list's subscribers have been tagged to based on geocoding their IP address.
    /// </summary>
    WithRawResponseTask<ListLocationsListsResponse> ListLocationsAsync(
        ListLocationsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about members in a specific Mailchimp list.
    /// </summary>
    Task<Pager<ListMembers>> ListMembersAsync(
        ListMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new member to the list.
    /// </summary>
    WithRawResponseTask<ListMembers> CreateMemberAsync(
        CreateMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific list member, including a currently subscribed, unsubscribed, or bounced member.
    /// </summary>
    WithRawResponseTask<ListMembers> GetMemberAsync(
        GetMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add or update a list member.
    /// </summary>
    WithRawResponseTask<ListMembers> UpsertMemberAsync(
        UpsertMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archive a list member. To permanently delete, use the delete-permanent action.
    /// </summary>
    WithRawResponseTask DeleteMemberAsync(
        DeleteMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update information for a specific list member.
    /// </summary>
    WithRawResponseTask<ListMembers> UpdateMemberAsync(
        UpdateMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete all personally identifiable information related to a list member, and remove them from a list. This will make it impossible to re-import the list member.
    /// </summary>
    WithRawResponseTask CreateMemberActionDeletePermanentAsync(
        CreateMemberActionDeletePermanentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the last 50 events of a member's activity on a specific list, including opens, clicks, and unsubscribes.
    /// </summary>
    WithRawResponseTask<ListMemberActivityListsResponse> ListMemberActivityAsync(
        ListMemberActivityListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a member's activity on a specific list, including opens, clicks, and unsubscribes.
    /// </summary>
    Task<Pager<object>> ListMemberActivityFeedAsync(
        ListMemberActivityFeedListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get events for a contact.
    /// </summary>
    Task<Pager<ListMemberEventsListsResponseEventsItem>> ListMemberEventsAsync(
        ListMemberEventsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add an event for a list member.
    /// </summary>
    WithRawResponseTask CreateMemberEventAsync(
        CreateMemberEventListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the last 50 Goal events for a member on a specific list.
    /// </summary>
    WithRawResponseTask<ListMemberGoalsListsResponse> ListMemberGoalsAsync(
        ListMemberGoalsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get recent notes for a specific list member.
    /// </summary>
    Task<Pager<MemberNotes>> ListMemberNotesAsync(
        ListMemberNotesListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new note for a specific subscriber.
    /// </summary>
    WithRawResponseTask<MemberNotes> CreateMemberNoteAsync(
        CreateMemberNoteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a specific note for a specific list member.
    /// </summary>
    WithRawResponseTask<MemberNotes> GetMemberNoteAsync(
        GetMemberNoteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific note for a specific list member.
    /// </summary>
    WithRawResponseTask DeleteMemberNoteAsync(
        DeleteMemberNoteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific note for a specific list member.
    /// </summary>
    WithRawResponseTask<MemberNotes> UpdateMemberNoteAsync(
        UpdateMemberNoteListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the tags on a list member.
    /// </summary>
    Task<Pager<ListMemberTagsListsResponseTagsItem>> ListMemberTagsAsync(
        ListMemberTagsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add or remove tags from a list member. If a tag that does not exist is passed in and set as 'active', a new tag will be created.
    /// </summary>
    WithRawResponseTask CreateMemberTagAsync(
        CreateMemberTagListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a list of all merge fields for an audience.
    /// </summary>
    Task<Pager<MergeField>> ListMergeFieldsAsync(
        ListMergeFieldsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new merge field for a specific audience.
    /// </summary>
    WithRawResponseTask<MergeField> CreateMergeFieldAsync(
        CreateMergeFieldListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific merge field.
    /// </summary>
    WithRawResponseTask<MergeField> GetMergeFieldAsync(
        GetMergeFieldListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific merge field.
    /// </summary>
    WithRawResponseTask DeleteMergeFieldAsync(
        DeleteMergeFieldListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific merge field.
    /// </summary>
    WithRawResponseTask<MergeField> UpdateMergeFieldAsync(
        UpdateMergeFieldListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about all available segments for a specific list.
    /// </summary>
    Task<Pager<List>> ListSegmentsAsync(
        ListSegmentsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new segment in a specific list.
    /// </summary>
    WithRawResponseTask<List> CreateSegmentAsync(
        CreateSegmentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific segment.
    /// </summary>
    WithRawResponseTask<List> GetSegmentAsync(
        GetSegmentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Batch add/remove list members to static segment
    /// </summary>
    WithRawResponseTask<BatchAddOrRemoveMembersListsResponse> BatchAddOrRemoveMembersAsync(
        BatchAddOrRemoveMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific segment in a list.
    /// </summary>
    WithRawResponseTask DeleteSegmentAsync(
        DeleteSegmentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific segment in a list.
    /// </summary>
    WithRawResponseTask<List> UpdateSegmentAsync(
        UpdateSegmentListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about members in a saved segment.
    /// </summary>
    Task<Pager<ListsSegmentsMembers>> ListSegmentMembersAsync(
        ListSegmentMembersListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a member to a static segment.
    /// </summary>
    WithRawResponseTask<ListsSegmentsMembers> CreateSegmentMemberAsync(
        CreateSegmentMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a member from the specified static segment.
    /// </summary>
    WithRawResponseTask DeleteSegmentMemberAsync(
        DeleteSegmentMemberListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get signup forms for a specific list.
    /// </summary>
    WithRawResponseTask<ListSignupFormsListsResponse> ListSignupFormsAsync(
        ListSignupFormsListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Customize a list's default signup form.
    /// </summary>
    WithRawResponseTask<SignupForm> CreateSignupFormAsync(
        CreateSignupFormListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about all available surveys for a specific list.
    /// </summary>
    WithRawResponseTask<object> ListSurveysAsync(
        ListSurveysListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a draft survey for an audience.
    /// </summary>
    WithRawResponseTask<object> CreateSurveyAsync(
        CreateSurveyListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get details about a specific survey.
    /// </summary>
    WithRawResponseTask<object> GetSurveyAsync(
        GetSurveyListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a survey.
    /// </summary>
    WithRawResponseTask DeleteSurveyAsync(
        DeleteSurveyListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a survey. When sections is provided, send the complete section list in display order. Any existing section not included is deleted.
    /// </summary>
    WithRawResponseTask<object> UpdateSurveyAsync(
        UpdateSurveyListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replicate a survey.
    /// </summary>
    WithRawResponseTask<object> CreateListSurveyActionReplicateAsync(
        CreateListSurveyActionReplicateListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Search for tags on a list by name. If no name is provided, will return all tags on the list.
    /// </summary>
    WithRawResponseTask<ListTagSearchListsResponse> ListTagSearchAsync(
        ListTagSearchListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about all webhooks for a specific list.
    /// </summary>
    WithRawResponseTask<ListWebhooksListsResponse> ListWebhooksAsync(
        ListWebhooksListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new webhook for a specific list.
    /// </summary>
    WithRawResponseTask<CreateWebhookListsResponse> CreateWebhookAsync(
        CreateWebhookListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific webhook.
    /// </summary>
    WithRawResponseTask<ListWebhooks> GetWebhookAsync(
        GetWebhookListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific webhook in a list.
    /// </summary>
    WithRawResponseTask DeleteWebhookAsync(
        DeleteWebhookListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update the settings for an existing webhook.
    /// </summary>
    WithRawResponseTask<ListWebhooks> UpdateWebhookAsync(
        UpdateWebhookListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
