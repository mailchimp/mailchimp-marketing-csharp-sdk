using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemInterestsOp.SegmentTypeItemInterestsOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemInterestsOp : IStringEnum
{
    public static readonly SegmentTypeItemInterestsOp Interestcontains = new(
        Values.Interestcontains
    );

    public static readonly SegmentTypeItemInterestsOp Interestcontainsall = new(
        Values.Interestcontainsall
    );

    public static readonly SegmentTypeItemInterestsOp Interestnotcontains = new(
        Values.Interestnotcontains
    );

    public SegmentTypeItemInterestsOp(string value)
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
    public static SegmentTypeItemInterestsOp FromCustom(string value)
    {
        return new SegmentTypeItemInterestsOp(value);
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

    public static bool operator ==(SegmentTypeItemInterestsOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemInterestsOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemInterestsOp value) => value.Value;

    public static explicit operator SegmentTypeItemInterestsOp(string value) => new(value);

    internal class SegmentTypeItemInterestsOpSerializer : JsonConverter<SegmentTypeItemInterestsOp>
    {
        public override SegmentTypeItemInterestsOp Read(
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
            return new SegmentTypeItemInterestsOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemInterestsOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemInterestsOp ReadAsPropertyName(
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
            return new SegmentTypeItemInterestsOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemInterestsOp value,
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
        public const string Interestcontains = "interestcontains";

        public const string Interestcontainsall = "interestcontainsall";

        public const string Interestnotcontains = "interestnotcontains";
    }
}
