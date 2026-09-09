using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemEmailAddressField.SegmentTypeItemEmailAddressFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemEmailAddressField : IStringEnum
{
    public static readonly SegmentTypeItemEmailAddressField Merge0 = new(Values.Merge0);

    public static readonly SegmentTypeItemEmailAddressField Email = new(Values.Email);

    public SegmentTypeItemEmailAddressField(string value)
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
    public static SegmentTypeItemEmailAddressField FromCustom(string value)
    {
        return new SegmentTypeItemEmailAddressField(value);
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

    public static bool operator ==(SegmentTypeItemEmailAddressField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEmailAddressField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEmailAddressField value) => value.Value;

    public static explicit operator SegmentTypeItemEmailAddressField(string value) => new(value);

    internal class SegmentTypeItemEmailAddressFieldSerializer
        : JsonConverter<SegmentTypeItemEmailAddressField>
    {
        public override SegmentTypeItemEmailAddressField Read(
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
            return new SegmentTypeItemEmailAddressField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEmailAddressField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEmailAddressField ReadAsPropertyName(
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
            return new SegmentTypeItemEmailAddressField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEmailAddressField value,
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
        public const string Merge0 = "merge0";

        public const string Email = "EMAIL";
    }
}
