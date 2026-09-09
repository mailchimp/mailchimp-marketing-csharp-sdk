using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemEcommSpentField.SegmentTypeItemEcommSpentFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemEcommSpentField : IStringEnum
{
    public static readonly SegmentTypeItemEcommSpentField EcommSpentOne = new(Values.EcommSpentOne);

    public static readonly SegmentTypeItemEcommSpentField EcommSpentAll = new(Values.EcommSpentAll);

    public SegmentTypeItemEcommSpentField(string value)
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
    public static SegmentTypeItemEcommSpentField FromCustom(string value)
    {
        return new SegmentTypeItemEcommSpentField(value);
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

    public static bool operator ==(SegmentTypeItemEcommSpentField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEcommSpentField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEcommSpentField value) => value.Value;

    public static explicit operator SegmentTypeItemEcommSpentField(string value) => new(value);

    internal class SegmentTypeItemEcommSpentFieldSerializer
        : JsonConverter<SegmentTypeItemEcommSpentField>
    {
        public override SegmentTypeItemEcommSpentField Read(
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
            return new SegmentTypeItemEcommSpentField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommSpentField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEcommSpentField ReadAsPropertyName(
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
            return new SegmentTypeItemEcommSpentField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommSpentField value,
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
        public const string EcommSpentOne = "ecomm_spent_one";

        public const string EcommSpentAll = "ecomm_spent_all";
    }
}
