using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemEcommPurchasedField.SegmentTypeItemEcommPurchasedFieldSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemEcommPurchasedField : IStringEnum
{
    public static readonly SegmentTypeItemEcommPurchasedField EcommPurchased = new(
        Values.EcommPurchased
    );

    public SegmentTypeItemEcommPurchasedField(string value)
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
    public static SegmentTypeItemEcommPurchasedField FromCustom(string value)
    {
        return new SegmentTypeItemEcommPurchasedField(value);
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

    public static bool operator ==(SegmentTypeItemEcommPurchasedField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEcommPurchasedField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEcommPurchasedField value) => value.Value;

    public static explicit operator SegmentTypeItemEcommPurchasedField(string value) => new(value);

    internal class SegmentTypeItemEcommPurchasedFieldSerializer
        : JsonConverter<SegmentTypeItemEcommPurchasedField>
    {
        public override SegmentTypeItemEcommPurchasedField Read(
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
            return new SegmentTypeItemEcommPurchasedField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommPurchasedField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEcommPurchasedField ReadAsPropertyName(
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
            return new SegmentTypeItemEcommPurchasedField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommPurchasedField value,
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
        public const string EcommPurchased = "ecomm_purchased";
    }
}
