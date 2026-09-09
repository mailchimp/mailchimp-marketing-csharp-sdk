using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateAccountExportsRequest
{
    /// <summary>
    /// The stages of an account export to include.
    /// </summary>
    [JsonPropertyName("include_stages")]
    public IEnumerable<CreateAccountExportsRequestIncludeStagesItem> IncludeStages { get; set; } =
        new global::System.Collections.Generic.List<CreateAccountExportsRequestIncludeStagesItem>();

    /// <summary>
    /// An ISO 8601 date that will limit the export to only records created after a given time. For instance, the reports stage will contain any campaign sent after the given timestamp. Audiences, however, are excluded from this limit.
    /// </summary>
    [JsonPropertyName("since_timestamp")]
    public DateTime? SinceTimestamp { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
