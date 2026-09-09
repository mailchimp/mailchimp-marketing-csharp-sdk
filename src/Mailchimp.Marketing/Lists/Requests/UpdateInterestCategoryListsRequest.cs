using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateInterestCategoryListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

    /// <summary>
    /// The unique ID for the interest category.
    /// </summary>
    [JsonIgnore]
    public required string InterestCategoryId { get; set; }

    /// <summary>
    /// The order that the categories are displayed in the list. Lower numbers display first.
    /// </summary>
    [JsonPropertyName("display_order")]
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// The text description of this category. This field appears on signup forms and is often phrased as a question.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Determines how this category’s interests appear on signup forms.
    /// </summary>
    [JsonPropertyName("type")]
    public UpdateInterestCategoryListsRequestType? Type { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
