using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateLandingPagesRequest
{
    /// <summary>
    /// The unique id for the page.
    /// </summary>
    [JsonIgnore]
    public required string PageId { get; set; }

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
    /// The title of this landing page seen in the browser's title bar.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The tracking settings applied to this landing page.
    /// </summary>
    [JsonPropertyName("tracking")]
    public UpdateLandingPagesRequestTracking? Tracking { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
