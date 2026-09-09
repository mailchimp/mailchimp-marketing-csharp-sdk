using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Extra options for some merge field types.
/// </summary>
[Serializable]
public record UpdateMergeFieldListsRequestOptions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// In a radio or dropdown non-group field, the available options for members to pick from.
    /// </summary>
    [JsonPropertyName("choices")]
    public IEnumerable<string>? Choices { get; set; }

    /// <summary>
    /// In a date or birthday field, the format of the date.
    /// </summary>
    [JsonPropertyName("date_format")]
    public string? DateFormat { get; set; }

    /// <summary>
    /// In an address field, the default country code if none supplied.
    /// </summary>
    [JsonPropertyName("default_country")]
    public int? DefaultCountry { get; set; }

    /// <summary>
    /// In a phone field, the phone number type: US or International.
    /// </summary>
    [JsonPropertyName("phone_format")]
    public string? PhoneFormat { get; set; }

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
