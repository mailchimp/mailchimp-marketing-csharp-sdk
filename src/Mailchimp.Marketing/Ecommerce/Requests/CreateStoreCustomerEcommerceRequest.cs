using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateStoreCustomerEcommerceRequest
{
    /// <summary>
    /// The store id.
    /// </summary>
    [JsonIgnore]
    public required string StoreId { get; set; }

    /// <summary>
    /// The customer's address.
    /// </summary>
    [JsonPropertyName("address")]
    public CreateStoreCustomerEcommerceRequestAddress? Address { get; set; }

    /// <summary>
    /// The customer's company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// The customer's email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// The customer's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// A unique identifier for the customer. Limited to 50 characters.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The customer's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// The customer's opt-in status. This value will never overwrite the opt-in status of a pre-existing Mailchimp list member, but will apply to list members that are added through the e-commerce API endpoints. Customers who don't opt in to your Mailchimp list [will be added as `Transactional` members](https://mailchimp.com/developer/marketing/docs/e-commerce/#customers).
    /// </summary>
    [JsonPropertyName("opt_in_status")]
    public required bool OptInStatus { get; set; }

    /// <summary>
    /// A US phone number for SMS contact.
    /// </summary>
    [JsonPropertyName("sms_phone_number")]
    public string? SmsPhoneNumber { get; set; }

    [JsonPropertyName("total_spent")]
    public OneOf<double, string>? TotalSpent { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
