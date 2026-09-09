using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateSignupFormListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

    /// <summary>
    /// The signup form body content.
    /// </summary>
    [JsonPropertyName("contents")]
    public IEnumerable<CreateSignupFormListsRequestContentsItem>? Contents { get; set; }

    /// <summary>
    /// Options for customizing your signup form header.
    /// </summary>
    [JsonPropertyName("header")]
    public CreateSignupFormListsRequestHeader? Header { get; set; }

    /// <summary>
    /// An array of objects, each representing an element style for the signup form.
    /// </summary>
    [JsonPropertyName("styles")]
    public IEnumerable<CreateSignupFormListsRequestStylesItem>? Styles { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
