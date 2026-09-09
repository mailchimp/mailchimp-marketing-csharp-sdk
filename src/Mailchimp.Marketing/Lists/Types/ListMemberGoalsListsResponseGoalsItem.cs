using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A single instance of a goal activity.
/// </summary>
[Serializable]
public record ListMemberGoalsListsResponseGoalsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Any extra data passed with the Goal event.
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// The name/type of Goal event triggered.
    /// </summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// The id for a Goal event.
    /// </summary>
    [JsonPropertyName("goal_id")]
    public int? GoalId { get; set; }

    /// <summary>
    /// The date and time the user last triggered the Goal event in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("last_visited_at")]
    public DateTime? LastVisitedAt { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
