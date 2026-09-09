using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record BatchSubscribeOrUnsubscribeListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

    /// <summary>
    /// If skip_merge_validation is true, member data will be accepted without merge field values, even if the merge field is usually required. This defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? SkipMergeValidation { get; set; }

    /// <summary>
    /// If skip_duplicate_check is true, we will ignore duplicates sent in the request when using the batch sub/unsub on the lists endpoint. The status of the first appearance in the request will be saved. This defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? SkipDuplicateCheck { get; set; }

    /// <summary>
    /// An array of objects, each representing an email address and the subscription status for a specific list. Up to 500 members may be added or updated with each API call.
    /// </summary>
    [JsonPropertyName("members")]
    public IEnumerable<OneOf<object>> Members { get; set; } =
        new global::System.Collections.Generic.List<OneOf<object>>();

    /// <summary>
    /// Whether this batch operation will replace all existing tags with tags in request.
    /// </summary>
    [JsonPropertyName("sync_tags")]
    public bool? SyncTags { get; set; }

    /// <summary>
    /// Whether this batch operation will change existing members' subscription status.
    /// </summary>
    [JsonPropertyName("update_existing")]
    public bool? UpdateExisting { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
