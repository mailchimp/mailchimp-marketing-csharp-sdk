using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateFileFileManagerRequest
{
    /// <summary>
    /// The base64-encoded contents of the file.
    /// </summary>
    [JsonPropertyName("file_data")]
    public required string FileData { get; set; }

    /// <summary>
    /// The id of the folder.
    /// </summary>
    [JsonPropertyName("folder_id")]
    public int? FolderId { get; set; }

    /// <summary>
    /// The name of the file.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
