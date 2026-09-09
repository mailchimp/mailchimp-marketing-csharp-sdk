using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteStoreCartLineEcommerceRequest
{
    /// <summary>
    /// The store id.
    /// </summary>
    [JsonIgnore]
    public required string StoreId { get; set; }

    /// <summary>
    /// The id for the cart.
    /// </summary>
    [JsonIgnore]
    public required string CartId { get; set; }

    /// <summary>
    /// The id for the line item of a cart.
    /// </summary>
    [JsonIgnore]
    public required string LineId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
