using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CampaignsResendShortcutUsageOriginalCampaignShortcutType.CampaignsResendShortcutUsageOriginalCampaignShortcutTypeSerializer)
)]
[Serializable]
public readonly record struct CampaignsResendShortcutUsageOriginalCampaignShortcutType : IStringEnum
{
    public static readonly CampaignsResendShortcutUsageOriginalCampaignShortcutType NonOpeners =
        new(Values.NonOpeners);

    public static readonly CampaignsResendShortcutUsageOriginalCampaignShortcutType NewSubscribers =
        new(Values.NewSubscribers);

    public static readonly CampaignsResendShortcutUsageOriginalCampaignShortcutType NonClickers =
        new(Values.NonClickers);

    public static readonly CampaignsResendShortcutUsageOriginalCampaignShortcutType NonPurchasers =
        new(Values.NonPurchasers);

    public CampaignsResendShortcutUsageOriginalCampaignShortcutType(string value)
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
    public static CampaignsResendShortcutUsageOriginalCampaignShortcutType FromCustom(string value)
    {
        return new CampaignsResendShortcutUsageOriginalCampaignShortcutType(value);
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
        CampaignsResendShortcutUsageOriginalCampaignShortcutType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignsResendShortcutUsageOriginalCampaignShortcutType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignsResendShortcutUsageOriginalCampaignShortcutType value
    ) => value.Value;

    public static explicit operator CampaignsResendShortcutUsageOriginalCampaignShortcutType(
        string value
    ) => new(value);

    internal class CampaignsResendShortcutUsageOriginalCampaignShortcutTypeSerializer
        : JsonConverter<CampaignsResendShortcutUsageOriginalCampaignShortcutType>
    {
        public override CampaignsResendShortcutUsageOriginalCampaignShortcutType Read(
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
            return new CampaignsResendShortcutUsageOriginalCampaignShortcutType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignsResendShortcutUsageOriginalCampaignShortcutType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignsResendShortcutUsageOriginalCampaignShortcutType ReadAsPropertyName(
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
            return new CampaignsResendShortcutUsageOriginalCampaignShortcutType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignsResendShortcutUsageOriginalCampaignShortcutType value,
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
