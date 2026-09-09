using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ListAutomationsRequest
{
    /// <summary>
    /// The number of records to return. Default value is 10. Maximum value is 1000
    /// </summary>
    [JsonIgnore]
    public int? Count { get; set; }

    /// <summary>
    /// Used for [pagination](https://mailchimp.com/developer/marketing/docs/methods-parameters/#pagination), this is the number of records from a collection to skip. Default value is 0.
    /// </summary>
    [JsonIgnore]
    public int? Offset { get; set; }

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

    /// <summary>
    /// Restrict the response to automations created before this time. Uses the ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? BeforeCreateTime { get; set; }

    /// <summary>
    /// Restrict the response to automations created after this time. Uses the ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? SinceCreateTime { get; set; }

    /// <summary>
    /// Restrict the response to automations started before this time. Uses the ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? BeforeStartTime { get; set; }

    /// <summary>
    /// Restrict the response to automations started after this time. Uses the ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? SinceStartTime { get; set; }

    /// <summary>
    /// Restrict the results to automations with the specified status.
    /// </summary>
    [JsonIgnore]
    public ListAutomationsRequestStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
