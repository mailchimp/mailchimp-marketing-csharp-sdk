using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateBatchesRequestOperationsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A string containing the JSON body to use with the request.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// Any HTTP headers to include with the request.
    /// </summary>
    [JsonPropertyName("headers")]
    public CreateBatchesRequestOperationsItemHeaders? Headers { get; set; }

    /// <summary>
    /// The HTTP method to use for the operation.
    /// </summary>
    [JsonPropertyName("method")]
    public required CreateBatchesRequestOperationsItemMethod Method { get; set; }

    /// <summary>
    /// An optional client-supplied id returned with the operation results.
    /// </summary>
    [JsonPropertyName("operation_id")]
    public string? OperationId { get; set; }

    /// <summary>
    /// Any request query parameters. Example parameters: {"count":10, "offset":0}
    /// </summary>
    [JsonPropertyName("params")]
    public CreateBatchesRequestOperationsItemParams? Params { get; set; }

    /// <summary>
    /// The relative path to use for the operation.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

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
