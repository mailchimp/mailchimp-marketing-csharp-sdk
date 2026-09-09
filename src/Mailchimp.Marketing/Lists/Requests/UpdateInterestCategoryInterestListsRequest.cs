using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateInterestCategoryInterestListsRequest
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
    /// The specific interest or 'group name'.
    /// </summary>
    [JsonIgnore]
    public required string InterestId { get; set; }

    /// <summary>
    /// The display order for interests.
    /// </summary>
    [JsonPropertyName("display_order")]
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// The name of the interest. This can be shown publicly on a subscription form.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
