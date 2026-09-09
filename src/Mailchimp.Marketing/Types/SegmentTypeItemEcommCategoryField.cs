using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemEcommCategoryField.SegmentTypeItemEcommCategoryFieldSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemEcommCategoryField : IStringEnum
{
    public static readonly SegmentTypeItemEcommCategoryField EcommCat = new(Values.EcommCat);

    public static readonly SegmentTypeItemEcommCategoryField EcommProd = new(Values.EcommProd);

    public SegmentTypeItemEcommCategoryField(string value)
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
    public static SegmentTypeItemEcommCategoryField FromCustom(string value)
    {
        return new SegmentTypeItemEcommCategoryField(value);
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

    public static bool operator ==(SegmentTypeItemEcommCategoryField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEcommCategoryField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEcommCategoryField value) => value.Value;

    public static explicit operator SegmentTypeItemEcommCategoryField(string value) => new(value);

    internal class SegmentTypeItemEcommCategoryFieldSerializer
        : JsonConverter<SegmentTypeItemEcommCategoryField>
    {
        public override SegmentTypeItemEcommCategoryField Read(
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
            return new SegmentTypeItemEcommCategoryField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommCategoryField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEcommCategoryField ReadAsPropertyName(
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
            return new SegmentTypeItemEcommCategoryField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommCategoryField value,
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
        public const string EcommCat = "ecomm_cat";

        public const string EcommProd = "ecomm_prod";
    }
}
