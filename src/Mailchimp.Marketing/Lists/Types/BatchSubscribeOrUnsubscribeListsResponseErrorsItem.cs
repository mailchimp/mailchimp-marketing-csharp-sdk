using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record BatchSubscribeOrUnsubscribeListsResponseErrorsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The email address that could not be added or updated.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// The error message indicating why the email address could not be added or updated.
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>
    /// A unique code that identifies this specifc error.
    /// </summary>
    [JsonPropertyName("error_code")]
    public BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode? ErrorCode { get; set; }

    /// <summary>
    /// If the error is field-related, information about which field is at issue.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>
    /// Message indicating how to resolve a field-related error.
    /// </summary>
    [JsonPropertyName("field_message")]
    public string? FieldMessage { get; set; }

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
