using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IConversationsClient
{
    /// <summary>
    /// Get a list of conversations for the account. Conversations has been deprecated in favor of Inbox and these endpoints don't include Inbox data. Past Conversations are still available via this endpoint, but new campaign replies and other Inbox messages aren’t available using this endpoint.
    /// </summary>
    Task<Pager<Conversation>> ListAsync(
        ListConversationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get details about an individual conversation. Conversations has been deprecated in favor of Inbox and these endpoints don't include Inbox data. Past Conversations are still available via this endpoint, but new campaign replies and other Inbox messages aren’t available using this endpoint.
    /// </summary>
    WithRawResponseTask<Conversation> GetAsync(
        GetConversationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get messages from a specific conversation. Conversations has been deprecated in favor of Inbox and these endpoints don't include Inbox data. Past Conversations are still available via this endpoint, but new campaign replies and other Inbox messages aren’t available using this endpoint.
    /// </summary>
    WithRawResponseTask<ListMessagesConversationsResponse> ListMessagesAsync(
        ListMessagesConversationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get an individual message in a conversation. Conversations has been deprecated in favor of Inbox and these endpoints don't include Inbox data. Past Conversations are still available via this endpoint, but new campaign replies and other Inbox messages aren’t available using this endpoint.
    /// </summary>
    WithRawResponseTask<ConversationMessage> GetMessageAsync(
        GetMessageConversationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
