using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ListOrdersEcommerceRequest
{
    /// <summary>
    /// A comma-separated list of fields to return. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Fields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <summary>
    /// A comma-separated list of fields to exclude. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ExcludeFields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <summary>
    /// The number of records to return. Default value is 10. Maximum value is 1000
    /// </summary>
    [JsonIgnore]
    public int? Count { get; set; }

    /// <summary>
    /// Used for [pagination](https://mailchimp.com/developer/marketing/docs/methods-parameters/#pagination), this is the number of records from a collection to skip. Default value is 0.
    /// </summary>
    [JsonIgnore]
    public int? Offset { get; set; }

    /// <summary>
    /// Restrict results to orders with a specific `campaign_id` value.
    /// </summary>
    [JsonIgnore]
    public string? CampaignId { get; set; }

    /// <summary>
    /// Restrict results to orders with a specific `outreach_id` value.
    /// </summary>
    [JsonIgnore]
    public string? OutreachId { get; set; }

    /// <summary>
    /// Restrict results to orders made by a specific customer.
    /// </summary>
    [JsonIgnore]
    public string? CustomerId { get; set; }

    /// <summary>
    /// Restrict results to orders that have an outreach attached. For example, an email campaign or Facebook ad.
    /// </summary>
    [JsonIgnore]
    public bool? HasOutreach { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
