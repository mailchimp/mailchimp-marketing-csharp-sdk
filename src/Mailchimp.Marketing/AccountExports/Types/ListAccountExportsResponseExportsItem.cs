using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// An account export.
/// </summary>
[Serializable]
public record ListAccountExportsResponseExportsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListAccountExportsResponseExportsItemLinksItem>? Links { get; set; }

    /// <summary>
    /// If the export is finished, the download URL for an export. URLs are only valid for 90 days after the export completes.
    /// </summary>
    [JsonPropertyName("download_url")]
    public string? DownloadUrl { get; set; }

    /// <summary>
    /// The ID for the export.
    /// </summary>
    [JsonPropertyName("export_id")]
    public int? ExportId { get; set; }

    /// <summary>
    /// If finished, the finish time for the export.
    /// </summary>
    [JsonPropertyName("finished")]
    public DateTime? Finished { get; set; }

    /// <summary>
    /// The size of the uncompressed export in bytes.
    /// </summary>
    [JsonPropertyName("size_in_bytes")]
    public int? SizeInBytes { get; set; }

    /// <summary>
    /// Start time for the export.
    /// </summary>
    [JsonPropertyName("started")]
    public DateTime? Started { get; set; }

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
