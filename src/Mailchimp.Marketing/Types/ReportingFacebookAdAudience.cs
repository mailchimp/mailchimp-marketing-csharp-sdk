using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Audience settings
/// </summary>
[Serializable]
public record ReportingFacebookAdAudience : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("email_source")]
    public ReportingFacebookAdAudienceEmailSource? EmailSource { get; set; }

    /// <summary>
    /// To include list contacts as part of audience
    /// </summary>
    [JsonPropertyName("include_source_in_target")]
    public bool? IncludeSourceInTarget { get; set; }

    /// <summary>
    /// To find similar audience in given country
    /// </summary>
    [JsonPropertyName("lookalike_country_code")]
    public string? LookalikeCountryCode { get; set; }

    /// <summary>
    /// List or Facebook based audience
    /// </summary>
    [JsonPropertyName("source_type")]
    public ReportingFacebookAdAudienceSourceType? SourceType { get; set; }

    [JsonPropertyName("targeting_specs")]
    public ReportingFacebookAdAudienceTargetingSpecs? TargetingSpecs { get; set; }

    /// <summary>
    /// Type of the audience
    /// </summary>
    [JsonPropertyName("type")]
    public ReportingFacebookAdAudienceType? Type { get; set; }

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
