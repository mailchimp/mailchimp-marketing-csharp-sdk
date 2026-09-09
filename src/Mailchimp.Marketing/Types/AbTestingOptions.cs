using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// [A/B Testing](https://mailchimp.com/help/about-ab-tests/) options for a campaign.
/// </summary>
[Serializable]
public record AbTestingOptions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// For campaigns split on 'From Name', the name for Group A.
    /// </summary>
    [JsonPropertyName("from_name_a")]
    public string? FromNameA { get; set; }

    /// <summary>
    /// For campaigns split on 'From Name', the name for Group B.
    /// </summary>
    [JsonPropertyName("from_name_b")]
    public string? FromNameB { get; set; }

    /// <summary>
    /// How we should evaluate a winner. Based on 'opens', 'clicks', or 'manual'.
    /// </summary>
    [JsonPropertyName("pick_winner")]
    public AbTestingOptionsPickWinner? PickWinner { get; set; }

    /// <summary>
    /// For campaigns split on 'From Name', the reply-to address for Group A.
    /// </summary>
    [JsonPropertyName("reply_email_a")]
    public string? ReplyEmailA { get; set; }

    /// <summary>
    /// For campaigns split on 'From Name', the reply-to address for Group B.
    /// </summary>
    [JsonPropertyName("reply_email_b")]
    public string? ReplyEmailB { get; set; }

    /// <summary>
    /// The send time for Group A.
    /// </summary>
    [JsonPropertyName("send_time_a")]
    public DateTime? SendTimeA { get; set; }

    /// <summary>
    /// The send time for Group B.
    /// </summary>
    [JsonPropertyName("send_time_b")]
    public DateTime? SendTimeB { get; set; }

    /// <summary>
    /// The send time for the winning version.
    /// </summary>
    [JsonPropertyName("send_time_winner")]
    public string? SendTimeWinner { get; set; }

    /// <summary>
    /// The size of the split groups. Campaigns split based on 'schedule' are forced to have a 50/50 split. Valid split integers are between 1-50.
    /// </summary>
    [JsonPropertyName("split_size")]
    public int? SplitSize { get; set; }

    /// <summary>
    /// The type of AB split to run.
    /// </summary>
    [JsonPropertyName("split_test")]
    public AbTestingOptionsSplitTest? SplitTest { get; set; }

    /// <summary>
    /// For campaigns split on 'Subject Line', the subject line for Group A.
    /// </summary>
    [JsonPropertyName("subject_a")]
    public string? SubjectA { get; set; }

    /// <summary>
    /// For campaigns split on 'Subject Line', the subject line for Group B.
    /// </summary>
    [JsonPropertyName("subject_b")]
    public string? SubjectB { get; set; }

    /// <summary>
    /// The amount of time to wait before picking a winner. This cannot be changed after a campaign is sent.
    /// </summary>
    [JsonPropertyName("wait_time")]
    public int? WaitTime { get; set; }

    /// <summary>
    /// How unit of time for measuring the winner ('hours' or 'days'). This cannot be changed after a campaign is sent.
    /// </summary>
    [JsonPropertyName("wait_units")]
    public AbTestingOptionsWaitUnits? WaitUnits { get; set; }

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
