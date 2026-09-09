using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// This object represents a link from the resource where it is found to another resource or action that may be performed.
/// </summary>
[Serializable]
public record ListEmailActivityReportsResponseLinksItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This property contains a fully-qualified URL that can be called to retrieve the linked resource or perform the linked action.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("href")]
    public string? Href { get; set; }

    /// <summary>
    /// The HTTP method that should be used when accessing the URL defined in 'href'.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("method")]
    public ListEmailActivityReportsResponseLinksItemMethod? Method { get; set; }

    /// <summary>
    /// As with an HTML 'rel' attribute, this describes the type of link.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("rel")]
    public string? Rel { get; set; }

    /// <summary>
    /// For HTTP methods that can receive bodies (POST and PUT), this is a URL representing the schema that the body should conform to.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// For GETs, this is a URL representing the schema that the response should conform to.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("targetSchema")]
    public string? TargetSchema { get; set; }

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
