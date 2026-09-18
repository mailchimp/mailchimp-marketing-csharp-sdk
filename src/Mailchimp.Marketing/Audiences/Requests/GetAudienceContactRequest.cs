using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record GetAudienceContactRequest
{
    /// <summary>
    /// The unique ID for the audience.
    /// </summary>
    [JsonIgnore]
    public required string AudienceId { get; set; }

    /// <summary>
    /// A unique identifier for the contact, which can be a Mailchimp contact ID or a channel hash. A channel hash must follow the format email:[md5_hash] (where the hash is the MD5 of the lowercased email address) or sms:[sha256_hash] (where the hash is the SHA256 of the E.164-formatted phone number).
    /// </summary>
    [JsonIgnore]
    public required string ContactId { get; set; }

    /// <summary>
    /// A comma-separated list of fields to return. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Fields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <summary>
    /// A comma-separated list of fields to exclude. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ExcludeFields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
