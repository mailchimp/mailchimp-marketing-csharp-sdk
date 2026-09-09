using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemEcommPurchasedOp.SegmentTypeItemEcommPurchasedOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemEcommPurchasedOp : IStringEnum
{
    public static readonly SegmentTypeItemEcommPurchasedOp Member = new(Values.Member);

    public static readonly SegmentTypeItemEcommPurchasedOp Notmember = new(Values.Notmember);

    public SegmentTypeItemEcommPurchasedOp(string value)
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
    public static SegmentTypeItemEcommPurchasedOp FromCustom(string value)
    {
        return new SegmentTypeItemEcommPurchasedOp(value);
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

    public static bool operator ==(SegmentTypeItemEcommPurchasedOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEcommPurchasedOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEcommPurchasedOp value) => value.Value;

    public static explicit operator SegmentTypeItemEcommPurchasedOp(string value) => new(value);

    internal class SegmentTypeItemEcommPurchasedOpSerializer
        : JsonConverter<SegmentTypeItemEcommPurchasedOp>
    {
        public override SegmentTypeItemEcommPurchasedOp Read(
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
            return new SegmentTypeItemEcommPurchasedOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommPurchasedOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEcommPurchasedOp ReadAsPropertyName(
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
            return new SegmentTypeItemEcommPurchasedOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommPurchasedOp value,
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
        public const string Member = "member";

        public const string Notmember = "notmember";
    }
}
