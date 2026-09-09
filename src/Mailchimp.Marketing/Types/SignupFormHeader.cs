using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Options for customizing your signup form header.
/// </summary>
[Serializable]
public record SignupFormHeader : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Image alignment.
    /// </summary>
    [JsonPropertyName("image_align")]
    public SignupFormHeaderImageAlign? ImageAlign { get; set; }

    /// <summary>
    /// Alt text for the image.
    /// </summary>
    [JsonPropertyName("image_alt")]
    public string? ImageAlt { get; set; }

    /// <summary>
    /// Image border color.
    /// </summary>
    [JsonPropertyName("image_border_color")]
    public string? ImageBorderColor { get; set; }

    /// <summary>
    /// Image border style.
    /// </summary>
    [JsonPropertyName("image_border_style")]
    public SignupFormHeaderImageBorderStyle? ImageBorderStyle { get; set; }

    /// <summary>
    /// Image border width.
    /// </summary>
    [JsonPropertyName("image_border_width")]
    public string? ImageBorderWidth { get; set; }

    /// <summary>
    /// Image height, in pixels.
    /// </summary>
    [JsonPropertyName("image_height")]
    public string? ImageHeight { get; set; }

    /// <summary>
    /// The URL that the header image will link to.
    /// </summary>
    [JsonPropertyName("image_link")]
    public string? ImageLink { get; set; }

    /// <summary>
    /// Image link target.
    /// </summary>
    [JsonPropertyName("image_target")]
    public SignupFormHeaderImageTarget? ImageTarget { get; set; }

    /// <summary>
    /// Header image URL.
    /// </summary>
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    /// <summary>
    /// Image width, in pixels.
    /// </summary>
    [JsonPropertyName("image_width")]
    public string? ImageWidth { get; set; }

    /// <summary>
    /// Header text.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

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
