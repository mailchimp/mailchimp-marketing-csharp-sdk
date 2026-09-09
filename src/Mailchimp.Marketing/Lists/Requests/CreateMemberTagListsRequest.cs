using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateMemberTagListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

    /// <summary>
    /// The MD5 hash of the lowercase version of the list member's email address.
    /// </summary>
    [JsonIgnore]
    public required string SubscriberHash { get; set; }

    /// <summary>
    /// When is_syncing is true, automations based on the tags in the request will not fire
    /// </summary>
    [JsonPropertyName("is_syncing")]
    public bool? IsSyncing { get; set; }

    /// <summary>
    /// A list of tags assigned to the list member.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<CreateMemberTagListsRequestTagsItem> Tags { get; set; } =
        new global::System.Collections.Generic.List<CreateMemberTagListsRequestTagsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
