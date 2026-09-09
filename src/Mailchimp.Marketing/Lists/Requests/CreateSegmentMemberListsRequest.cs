using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateSegmentMemberListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

    /// <summary>
    /// The unique id for the segment.
    /// </summary>
    [JsonIgnore]
    public required string SegmentId { get; set; }

    /// <summary>
    /// Email address for a subscriber.
    /// </summary>
    [JsonPropertyName("email_address")]
    public required string EmailAddress { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
