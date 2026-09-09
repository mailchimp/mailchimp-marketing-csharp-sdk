using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateCampaignsRequestVariateSettingsWinnerCriteria.UpdateCampaignsRequestVariateSettingsWinnerCriteriaSerializer)
)]
[Serializable]
public readonly record struct UpdateCampaignsRequestVariateSettingsWinnerCriteria : IStringEnum
{
    public static readonly UpdateCampaignsRequestVariateSettingsWinnerCriteria Opens = new(
        Values.Opens
    );

    public static readonly UpdateCampaignsRequestVariateSettingsWinnerCriteria Clicks = new(
        Values.Clicks
    );

    public static readonly UpdateCampaignsRequestVariateSettingsWinnerCriteria Manual = new(
        Values.Manual
    );

    public static readonly UpdateCampaignsRequestVariateSettingsWinnerCriteria TotalRevenue = new(
        Values.TotalRevenue
    );

    public UpdateCampaignsRequestVariateSettingsWinnerCriteria(string value)
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
    public static UpdateCampaignsRequestVariateSettingsWinnerCriteria FromCustom(string value)
    {
        return new UpdateCampaignsRequestVariateSettingsWinnerCriteria(value);
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

    public static bool operator ==(
        UpdateCampaignsRequestVariateSettingsWinnerCriteria value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateCampaignsRequestVariateSettingsWinnerCriteria value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdateCampaignsRequestVariateSettingsWinnerCriteria value
    ) => value.Value;

    public static explicit operator UpdateCampaignsRequestVariateSettingsWinnerCriteria(
        string value
    ) => new(value);

    internal class UpdateCampaignsRequestVariateSettingsWinnerCriteriaSerializer
        : JsonConverter<UpdateCampaignsRequestVariateSettingsWinnerCriteria>
    {
        public override UpdateCampaignsRequestVariateSettingsWinnerCriteria Read(
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
            return new UpdateCampaignsRequestVariateSettingsWinnerCriteria(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateCampaignsRequestVariateSettingsWinnerCriteria value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateCampaignsRequestVariateSettingsWinnerCriteria ReadAsPropertyName(
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
            return new UpdateCampaignsRequestVariateSettingsWinnerCriteria(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateCampaignsRequestVariateSettingsWinnerCriteria value,
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
