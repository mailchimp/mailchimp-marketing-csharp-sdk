using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateLandingPagesRequest
{
    /// <summary>
    /// Will create the Landing Page using the account's Default List instead of requiring a list_id.
    /// </summary>
    [JsonIgnore]
    public bool? UseDefaultList { get; set; }

    /// <summary>
    /// The description of this landing page.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list's ID associated with this landing page.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// The name of this landing page.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the store associated with this landing page.
    /// </summary>
    [JsonPropertyName("store_id")]
    public string? StoreId { get; set; }

    /// <summary>
    /// The template_id of this landing page.
    /// </summary>
    [JsonPropertyName("template_id")]
    public int? TemplateId { get; set; }

    /// <summary>
    /// The title of this landing page seen in the browser's title bar.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The tracking settings applied to this landing page.
    /// </summary>
    [JsonPropertyName("tracking")]
    public CreateLandingPagesRequestTracking? Tracking { get; set; }

    /// <summary>
    /// The type of template the landing page has.
    /// </summary>
    [JsonPropertyName("type")]
    public CreateLandingPagesRequestType? Type { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
