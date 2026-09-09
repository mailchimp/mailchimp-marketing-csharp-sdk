using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// The API root resource links to all other resources available in the API.
/// </summary>
[Serializable]
public record ListRootResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListRootResponseLinksItem>? Links { get; set; }

    /// <summary>
    /// The Mailchimp account ID.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; set; }

    /// <summary>
    /// The user-specified industry associated with the account.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("account_industry")]
    public string? AccountIndustry { get; set; }

    /// <summary>
    /// The name of the account.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("account_name")]
    public string? AccountName { get; set; }

    /// <summary>
    /// The timezone currently set for the account.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("account_timezone")]
    public string? AccountTimezone { get; set; }

    /// <summary>
    /// URL of the avatar for the user.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("avatar_url")]
    public string? AvatarUrl { get; set; }

    /// <summary>
    /// Information about the account contact.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("contact")]
    public ListRootResponseContact? Contact { get; set; }

    /// <summary>
    /// The account email address.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// The first name tied to the account.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// Date of first payment for monthly plans.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("first_payment")]
    public OneOf<DateTime, ListRootResponseFirstPaymentOne>? FirstPayment { get; set; }

    /// <summary>
    /// The [average campaign statistics](https://mailchimp.com/resources/research/email-marketing-benchmarks/?utm_source=mc-api&amp;utm_medium=docs&amp;utm_campaign=apidocs) for all campaigns in the account's specified industry.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("industry_stats")]
    public ListRootResponseIndustryStats? IndustryStats { get; set; }

    /// <summary>
    /// The date and time of the last login for this account in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_login")]
    public DateTime? LastLogin { get; set; }

    /// <summary>
    /// The last name tied to the account.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// The ID associated with the user who owns this API key. If you can login to multiple accounts, this ID will be the same for each account.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("login_id")]
    public string? LoginId { get; set; }

    /// <summary>
    /// The date and time that the account was created in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("member_since")]
    public DateTime? MemberSince { get; set; }

    /// <summary>
    /// The type of pricing plan the account is on.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("pricing_plan_type")]
    public ListRootResponsePricingPlanType? PricingPlanType { get; set; }

    /// <summary>
    /// Legacy - whether the account includes [Mailchimp Pro](https://mailchimp.com/help/about-legacy-pricing-plan/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("pro_enabled")]
    public bool? ProEnabled { get; set; }

    /// <summary>
    /// The [user role](https://mailchimp.com/help/manage-user-levels-in-your-account/) for the account.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// The total number of subscribers across all lists in the account.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_subscribers")]
    public int? TotalSubscribers { get; set; }

    /// <summary>
    /// The username tied to the account.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("username")]
    public string? Username { get; set; }

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
