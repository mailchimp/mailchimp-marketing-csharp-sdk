using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The verified domains currently on the account.
/// </summary>
[Serializable]
public record CreateActionVerifyVerifiedDomainsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether domain authentication is enabled for this domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("authenticated")]
    public bool? Authenticated { get; set; }

    /// <summary>
    /// The name of this domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// Returns whether the domain used is a public / free email provider. See [Limitations of Free Email Addresses](https://mailchimp.com/help/limitations-of-free-email-addresses/) for more details.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("is_free_email_provider")]
    public bool? IsFreeEmailProvider { get; set; }

    /// <summary>
    /// The Domain's current status.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("status")]
    public CreateActionVerifyVerifiedDomainsResponseStatus? Status { get; set; }

    /// <summary>
    /// The e-mail address receiving the two-factor challenge for this domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("verification_email")]
    public string? VerificationEmail { get; set; }

    /// <summary>
    /// The date/time that the two-factor challenge was sent to the verification email.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("verification_sent")]
    public DateTime? VerificationSent { get; set; }

    /// <summary>
    /// Whether the domain has been verified for sending.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("verified")]
    public bool? Verified { get; set; }

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
