using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Do particular authorization constraints around this collection limit creation of new instances?
/// </summary>
[Serializable]
public record ListListsResponseConstraints : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// How many total instances of this resource are already in use? This is independent of any filter conditions applied to the query. Value may be larger than max_instances. As a special case, -1 is returned when access is unlimited.
    /// </summary>
    [JsonPropertyName("current_total_instances")]
    public int? CurrentTotalInstances { get; set; }

    /// <summary>
    /// How many total instances of this resource are allowed? This is independent of any filter conditions applied to the query. As a special case, -1 indicates unlimited.
    /// </summary>
    [JsonPropertyName("max_instances")]
    public required int MaxInstances { get; set; }

    /// <summary>
    /// May the user create additional instances of this resource?
    /// </summary>
    [JsonPropertyName("may_create")]
    public required bool MayCreate { get; set; }

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
