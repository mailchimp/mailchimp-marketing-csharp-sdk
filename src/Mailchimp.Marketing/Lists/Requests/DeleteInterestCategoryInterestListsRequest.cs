using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteInterestCategoryInterestListsRequest
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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
