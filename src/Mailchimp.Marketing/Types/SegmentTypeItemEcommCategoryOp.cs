using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemEcommCategoryOp.SegmentTypeItemEcommCategoryOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemEcommCategoryOp : IStringEnum
{
    public static readonly SegmentTypeItemEcommCategoryOp Is = new(Values.Is);

    public static readonly SegmentTypeItemEcommCategoryOp Not = new(Values.Not);

    public static readonly SegmentTypeItemEcommCategoryOp Contains = new(Values.Contains);

    public static readonly SegmentTypeItemEcommCategoryOp Notcontain = new(Values.Notcontain);

    public static readonly SegmentTypeItemEcommCategoryOp Starts = new(Values.Starts);

    public static readonly SegmentTypeItemEcommCategoryOp Ends = new(Values.Ends);

    public SegmentTypeItemEcommCategoryOp(string value)
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
    public static SegmentTypeItemEcommCategoryOp FromCustom(string value)
    {
        return new SegmentTypeItemEcommCategoryOp(value);
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

    public static bool operator ==(SegmentTypeItemEcommCategoryOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEcommCategoryOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEcommCategoryOp value) => value.Value;

    public static explicit operator SegmentTypeItemEcommCategoryOp(string value) => new(value);

    internal class SegmentTypeItemEcommCategoryOpSerializer
        : JsonConverter<SegmentTypeItemEcommCategoryOp>
    {
        public override SegmentTypeItemEcommCategoryOp Read(
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
            return new SegmentTypeItemEcommCategoryOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommCategoryOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEcommCategoryOp ReadAsPropertyName(
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
            return new SegmentTypeItemEcommCategoryOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommCategoryOp value,
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
    }
}
