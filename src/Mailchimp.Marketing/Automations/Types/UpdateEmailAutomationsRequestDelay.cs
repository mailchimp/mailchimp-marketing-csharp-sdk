using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The delay settings for an automation email.
/// </summary>
[Serializable]
public record UpdateEmailAutomationsRequestDelay : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The action that triggers the delay of an automation emails.
    /// </summary>
    [JsonPropertyName("action")]
    public required UpdateEmailAutomationsRequestDelayAction Action { get; set; }

    /// <summary>
    /// The delay amount for an automation email.
    /// </summary>
    [JsonPropertyName("amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// Whether the delay settings describe before or after the delay action of an automation email.
    /// </summary>
    [JsonPropertyName("direction")]
    public UpdateEmailAutomationsRequestDelayDirection? Direction { get; set; }

    /// <summary>
    /// The type of delay for an automation email.
    /// </summary>
    [JsonPropertyName("type")]
    public UpdateEmailAutomationsRequestDelayType? Type { get; set; }

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
