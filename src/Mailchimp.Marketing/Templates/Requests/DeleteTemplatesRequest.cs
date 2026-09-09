using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteTemplatesRequest
{
    /// <summary>
    /// The unique id for the template.
    /// </summary>
    [JsonIgnore]
    public required string TemplateId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
