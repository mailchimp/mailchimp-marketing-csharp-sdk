using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType.CampaignsResendShortcutUsageShortcutCampaignsItemShortcutTypeSerializer)
)]
[Serializable]
public readonly record struct CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType
    : IStringEnum
{
    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType NonOpeners =
        new(Values.NonOpeners);

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType NewSubscribers =
        new(Values.NewSubscribers);

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType NonClickers =
        new(Values.NonClickers);

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType NonPurchasers =
        new(Values.NonPurchasers);

    public CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType(string value)
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
    public static CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType FromCustom(
        string value
    )
    {
        return new CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType(value);
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
        CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType value
    ) => value.Value;

    public static explicit operator CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType(
        string value
    ) => new(value);

    internal class CampaignsResendShortcutUsageShortcutCampaignsItemShortcutTypeSerializer
        : JsonConverter<CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType>
    {
        public override CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType Read(
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
            return new CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType ReadAsPropertyName(
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
            return new CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignsResendShortcutUsageShortcutCampaignsItemShortcutType value,
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
        public const string NonOpeners = "non_openers";

        public const string NewSubscribers = "new_subscribers";

        public const string NonClickers = "non_clickers";

        public const string NonPurchasers = "non_purchasers";
    }
}
