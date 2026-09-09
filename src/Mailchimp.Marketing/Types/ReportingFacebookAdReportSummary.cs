using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Report summary of facebook ad
/// </summary>
[Serializable]
public record ReportingFacebookAdReportSummary : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("average_daily_budget")]
    public ReportingFacebookAdReportSummaryAverageDailyBudget? AverageDailyBudget { get; set; }

    [JsonPropertyName("average_order_amount")]
    public ReportingFacebookAdReportSummaryAverageOrderAmount? AverageOrderAmount { get; set; }

    [JsonPropertyName("click_rate")]
    public double? ClickRate { get; set; }

    [JsonPropertyName("clicks")]
    public int? Clicks { get; set; }

    [JsonPropertyName("comments")]
    public int? Comments { get; set; }

    [JsonPropertyName("cost_per_click")]
    public ReportingFacebookAdReportSummaryCostPerClick? CostPerClick { get; set; }

    [JsonPropertyName("ecommerce")]
    public ReportingFacebookAdReportSummaryEcommerce? Ecommerce { get; set; }

    [JsonPropertyName("extended_at")]
    public ReportingFacebookAdReportSummaryExtendedAt? ExtendedAt { get; set; }

    [JsonPropertyName("first_time_buyers")]
    public int? FirstTimeBuyers { get; set; }

    [JsonPropertyName("has_extended_ad_duration")]
    public bool? HasExtendedAdDuration { get; set; }

    [JsonPropertyName("impressions")]
    public int? Impressions { get; set; }

    [JsonPropertyName("likes")]
    public int? Likes { get; set; }

    [JsonPropertyName("reach")]
    public int? Reach { get; set; }

    [JsonPropertyName("return_on_investment")]
    public double? ReturnOnInvestment { get; set; }

    [JsonPropertyName("shares")]
    public int? Shares { get; set; }

    [JsonPropertyName("total_orders")]
    public int? TotalOrders { get; set; }

    [JsonPropertyName("total_products_sold")]
    public int? TotalProductsSold { get; set; }

    [JsonPropertyName("unique_clicks")]
    public int? UniqueClicks { get; set; }

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
