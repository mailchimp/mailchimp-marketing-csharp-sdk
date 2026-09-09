using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateCampaignsRequestVariateSettingsWinnerCriteria.CreateCampaignsRequestVariateSettingsWinnerCriteriaSerializer)
)]
[Serializable]
public readonly record struct CreateCampaignsRequestVariateSettingsWinnerCriteria : IStringEnum
{
    public static readonly CreateCampaignsRequestVariateSettingsWinnerCriteria Opens = new(
        Values.Opens
    );

    public static readonly CreateCampaignsRequestVariateSettingsWinnerCriteria Clicks = new(
        Values.Clicks
    );

    public static readonly CreateCampaignsRequestVariateSettingsWinnerCriteria Manual = new(
        Values.Manual
    );

    public static readonly CreateCampaignsRequestVariateSettingsWinnerCriteria TotalRevenue = new(
        Values.TotalRevenue
    );

    public CreateCampaignsRequestVariateSettingsWinnerCriteria(string value)
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
    public static CreateCampaignsRequestVariateSettingsWinnerCriteria FromCustom(string value)
    {
        return new CreateCampaignsRequestVariateSettingsWinnerCriteria(value);
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
        CreateCampaignsRequestVariateSettingsWinnerCriteria value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateCampaignsRequestVariateSettingsWinnerCriteria value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateCampaignsRequestVariateSettingsWinnerCriteria value
    ) => value.Value;

    public static explicit operator CreateCampaignsRequestVariateSettingsWinnerCriteria(
        string value
    ) => new(value);

    internal class CreateCampaignsRequestVariateSettingsWinnerCriteriaSerializer
        : JsonConverter<CreateCampaignsRequestVariateSettingsWinnerCriteria>
    {
        public override CreateCampaignsRequestVariateSettingsWinnerCriteria Read(
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
            return new CreateCampaignsRequestVariateSettingsWinnerCriteria(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateCampaignsRequestVariateSettingsWinnerCriteria value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateCampaignsRequestVariateSettingsWinnerCriteria ReadAsPropertyName(
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
            return new CreateCampaignsRequestVariateSettingsWinnerCriteria(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateCampaignsRequestVariateSettingsWinnerCriteria value,
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
