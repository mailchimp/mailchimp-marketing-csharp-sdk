using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record GetStoreCustomerEcommerceRequest
{
    /// <summary>
    /// The store id.
    /// </summary>
    [JsonIgnore]
    public required string StoreId { get; set; }

    /// <summary>
    /// The id for the customer of a store.
    /// </summary>
    [JsonIgnore]
    public required string CustomerId { get; set; }

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
