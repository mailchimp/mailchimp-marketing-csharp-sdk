using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Collection of Element style for List Signup Forms.
/// </summary>
[Serializable]
public record CreateSignupFormListsRequestStylesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A collection of options for a selector.
    /// </summary>
    [JsonPropertyName("options")]
    public IEnumerable<CreateSignupFormListsRequestStylesItemOptionsItem>? Options { get; set; }

    /// <summary>
    /// A string that identifies the element selector.
    /// </summary>
    [JsonPropertyName("selector")]
    public CreateSignupFormListsRequestStylesItemSelector? Selector { get; set; }

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
