using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CampaignVariateSettingsWinnerCriteria.CampaignVariateSettingsWinnerCriteriaSerializer)
)]
[Serializable]
public readonly record struct CampaignVariateSettingsWinnerCriteria : IStringEnum
{
    public static readonly CampaignVariateSettingsWinnerCriteria Opens = new(Values.Opens);

    public static readonly CampaignVariateSettingsWinnerCriteria Clicks = new(Values.Clicks);

    public static readonly CampaignVariateSettingsWinnerCriteria Manual = new(Values.Manual);

    public static readonly CampaignVariateSettingsWinnerCriteria TotalRevenue = new(
        Values.TotalRevenue
    );

    public CampaignVariateSettingsWinnerCriteria(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static CampaignVariateSettingsWinnerCriteria FromCustom(string value)
    {
        return new CampaignVariateSettingsWinnerCriteria(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(CampaignVariateSettingsWinnerCriteria value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignVariateSettingsWinnerCriteria value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignVariateSettingsWinnerCriteria value) =>
        value.Value;

    public static explicit operator CampaignVariateSettingsWinnerCriteria(string value) =>
        new(value);

    internal class CampaignVariateSettingsWinnerCriteriaSerializer
        : JsonConverter<CampaignVariateSettingsWinnerCriteria>
    {
        public override CampaignVariateSettingsWinnerCriteria Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new CampaignVariateSettingsWinnerCriteria(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignVariateSettingsWinnerCriteria value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignVariateSettingsWinnerCriteria ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new CampaignVariateSettingsWinnerCriteria(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignVariateSettingsWinnerCriteria value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Opens = "opens";

        public const string Clicks = "clicks";

        public const string Manual = "manual";

        public const string TotalRevenue = "total_revenue";
    }
}
