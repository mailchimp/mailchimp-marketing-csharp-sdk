using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateMemberNoteListsRequest
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
    /// The id for the note.
    /// </summary>
    [JsonIgnore]
    public required string NoteId { get; set; }

    /// <summary>
    /// The content of the note. Note length is limited to 1,000 characters.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
