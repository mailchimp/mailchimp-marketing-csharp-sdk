using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// List signup form.
/// </summary>
[Serializable]
public record SignupForm : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<SignupFormLinksItem>? Links { get; set; }

    /// <summary>
    /// The signup form body content.
    /// </summary>
    [JsonPropertyName("contents")]
    public IEnumerable<SignupFormContentsItem>? Contents { get; set; }

    /// <summary>
    /// Options for customizing your signup form header.
    /// </summary>
    [JsonPropertyName("header")]
    public SignupFormHeader? Header { get; set; }

    /// <summary>
    /// The signup form's list id.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// Signup form URL.
    /// </summary>
    [JsonPropertyName("signup_form_url")]
    public string? SignupFormUrl { get; set; }

    /// <summary>
    /// An array of objects, each representing an element style for the signup form.
    /// </summary>
    [JsonPropertyName("styles")]
    public IEnumerable<SignupFormStylesItem>? Styles { get; set; }

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
