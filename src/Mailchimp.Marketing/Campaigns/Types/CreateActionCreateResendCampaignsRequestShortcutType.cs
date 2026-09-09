using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateActionCreateResendCampaignsRequestShortcutType.CreateActionCreateResendCampaignsRequestShortcutTypeSerializer)
)]
[Serializable]
public readonly record struct CreateActionCreateResendCampaignsRequestShortcutType : IStringEnum
{
    public static readonly CreateActionCreateResendCampaignsRequestShortcutType ToNonOpeners = new(
        Values.ToNonOpeners
    );

    public static readonly CreateActionCreateResendCampaignsRequestShortcutType ToNewSubscribers =
        new(Values.ToNewSubscribers);

    public static readonly CreateActionCreateResendCampaignsRequestShortcutType ToNonClickers = new(
        Values.ToNonClickers
    );

    public static readonly CreateActionCreateResendCampaignsRequestShortcutType ToNonPurchasers =
        new(Values.ToNonPurchasers);

    public CreateActionCreateResendCampaignsRequestShortcutType(string value)
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
    public static CreateActionCreateResendCampaignsRequestShortcutType FromCustom(string value)
    {
        return new CreateActionCreateResendCampaignsRequestShortcutType(value);
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
        CreateActionCreateResendCampaignsRequestShortcutType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateActionCreateResendCampaignsRequestShortcutType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateActionCreateResendCampaignsRequestShortcutType value
    ) => value.Value;

    public static explicit operator CreateActionCreateResendCampaignsRequestShortcutType(
        string value
    ) => new(value);

    internal class CreateActionCreateResendCampaignsRequestShortcutTypeSerializer
        : JsonConverter<CreateActionCreateResendCampaignsRequestShortcutType>
    {
        public override CreateActionCreateResendCampaignsRequestShortcutType Read(
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
            return new CreateActionCreateResendCampaignsRequestShortcutType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateActionCreateResendCampaignsRequestShortcutType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateActionCreateResendCampaignsRequestShortcutType ReadAsPropertyName(
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
            return new CreateActionCreateResendCampaignsRequestShortcutType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateActionCreateResendCampaignsRequestShortcutType value,
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
        public const string ToNonOpeners = "to_non_openers";

        public const string ToNewSubscribers = "to_new_subscribers";

        public const string ToNonClickers = "to_non_clickers";

        public const string ToNonPurchasers = "to_non_purchasers";
    }
}
