using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateMemberEventListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

    /// <summary>
    /// The MD5 hash of the lowercase version of the list member's email address. This endpoint also accepts a list member's email address or contact_id.
    /// </summary>
    [JsonIgnore]
    public required string SubscriberHash { get; set; }

    /// <summary>
    /// Events created with the is_syncing value set to `true` will not trigger automations.
    /// </summary>
    [JsonPropertyName("is_syncing")]
    public bool? IsSyncing { get; set; }

    /// <summary>
    /// The name for this type of event ('purchased', 'visited', etc). Must be 2-30 characters in length
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The date and time the event occurred in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("occurred_at")]
    public DateTime? OccurredAt { get; set; }

    /// <summary>
    /// An optional list of properties
    /// </summary>
    [JsonPropertyName("properties")]
    public Dictionary<string, string>? Properties { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
