using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemEmailAddressOp.SegmentTypeItemEmailAddressOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemEmailAddressOp : IStringEnum
{
    public static readonly SegmentTypeItemEmailAddressOp Is = new(Values.Is);

    public static readonly SegmentTypeItemEmailAddressOp Not = new(Values.Not);

    public static readonly SegmentTypeItemEmailAddressOp Contains = new(Values.Contains);

    public static readonly SegmentTypeItemEmailAddressOp Notcontain = new(Values.Notcontain);

    public static readonly SegmentTypeItemEmailAddressOp Starts = new(Values.Starts);

    public static readonly SegmentTypeItemEmailAddressOp Ends = new(Values.Ends);

    public static readonly SegmentTypeItemEmailAddressOp Greater = new(Values.Greater);

    public static readonly SegmentTypeItemEmailAddressOp Less = new(Values.Less);

    public SegmentTypeItemEmailAddressOp(string value)
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
    public static SegmentTypeItemEmailAddressOp FromCustom(string value)
    {
        return new SegmentTypeItemEmailAddressOp(value);
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

    public static bool operator ==(SegmentTypeItemEmailAddressOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEmailAddressOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEmailAddressOp value) => value.Value;

    public static explicit operator SegmentTypeItemEmailAddressOp(string value) => new(value);

    internal class SegmentTypeItemEmailAddressOpSerializer
        : JsonConverter<SegmentTypeItemEmailAddressOp>
    {
        public override SegmentTypeItemEmailAddressOp Read(
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
            return new SegmentTypeItemEmailAddressOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEmailAddressOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEmailAddressOp ReadAsPropertyName(
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
            return new SegmentTypeItemEmailAddressOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEmailAddressOp value,
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
        public const string Is = "is";

        public const string Not = "not";

        public const string Contains = "contains";

        public const string Notcontain = "notcontain";

        public const string Starts = "starts";

        public const string Ends = "ends";

        public const string Greater = "greater";

        public const string Less = "less";
    }
}
