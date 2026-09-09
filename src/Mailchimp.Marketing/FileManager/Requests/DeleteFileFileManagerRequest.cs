using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteFileFileManagerRequest
{
    /// <summary>
    /// The unique id for the File Manager file.
    /// </summary>
    [JsonIgnore]
    public required string FileId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
