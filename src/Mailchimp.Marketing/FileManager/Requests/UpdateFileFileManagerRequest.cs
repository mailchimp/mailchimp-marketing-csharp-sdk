using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateFileFileManagerRequest
{
    /// <summary>
    /// The unique id for the File Manager file.
    /// </summary>
    [JsonIgnore]
    public required string FileId { get; set; }

    /// <summary>
    /// The id of the folder. Setting `folder_id` to `0` will remove a file from its current folder.
    /// </summary>
    [JsonPropertyName("folder_id")]
    public int? FolderId { get; set; }

    /// <summary>
    /// The name of the file.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
