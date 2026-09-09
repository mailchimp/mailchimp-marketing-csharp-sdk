using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A summary of an individual landing page's settings and content.
/// </summary>
[Serializable]
public record LandingPageReport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<LandingPageReportLinksItem>? Links { get; set; }

    /// <summary>
    /// The number of clicks to this landing pages.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("clicks")]
    public int? Clicks { get; set; }

    /// <summary>
    /// The percentage of people who visited your landing page and were added to your list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("conversion_rate")]
    public double? ConversionRate { get; set; }

    [JsonPropertyName("ecommerce")]
    public LandingPageReportEcommerce? Ecommerce { get; set; }

    /// <summary>
    /// A string that uniquely identifies this landing page.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The list id connected to this landing page.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// List Name
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_name")]
    public string? ListName { get; set; }

    /// <summary>
    /// The name of this landing page the user will see.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The time this landing page was published.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("published_at")]
    public DateTime? PublishedAt { get; set; }

    /// <summary>
    /// A list of tags associated to the landing page.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("signup_tags")]
    public IEnumerable<LandingPageReportSignupTagsItem>? SignupTags { get; set; }

    /// <summary>
    /// The status of the landing page.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The number of subscribes to this landing pages.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("subscribes")]
    public int? Subscribes { get; set; }

    [JsonPropertyName("timeseries")]
    public LandingPageReportTimeseries? Timeseries { get; set; }

    /// <summary>
    /// The name of the landing page the user's customers will see.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The number of unique visits to this landing pages.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_visits")]
    public int? UniqueVisits { get; set; }

    /// <summary>
    /// The time this landing page was unpublished.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unpublished_at")]
    public DateTime? UnpublishedAt { get; set; }

    /// <summary>
    /// The landing page url.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The number of visits to this landing pages.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("visits")]
    public int? Visits { get; set; }

    /// <summary>
    /// The ID used in the Mailchimp web application.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("web_id")]
    public int? WebId { get; set; }

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
