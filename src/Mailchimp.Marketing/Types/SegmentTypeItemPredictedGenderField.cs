using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemPredictedGenderField.SegmentTypeItemPredictedGenderFieldSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemPredictedGenderField : IStringEnum
{
    public static readonly SegmentTypeItemPredictedGenderField PredictedGender = new(
        Values.PredictedGender
    );

    public SegmentTypeItemPredictedGenderField(string value)
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
    public static SegmentTypeItemPredictedGenderField FromCustom(string value)
    {
        return new SegmentTypeItemPredictedGenderField(value);
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

    public static bool operator ==(SegmentTypeItemPredictedGenderField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemPredictedGenderField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemPredictedGenderField value) =>
        value.Value;

    public static explicit operator SegmentTypeItemPredictedGenderField(string value) => new(value);

    internal class SegmentTypeItemPredictedGenderFieldSerializer
        : JsonConverter<SegmentTypeItemPredictedGenderField>
    {
        public override SegmentTypeItemPredictedGenderField Read(
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
            return new SegmentTypeItemPredictedGenderField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemPredictedGenderField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemPredictedGenderField ReadAsPropertyName(
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
            return new SegmentTypeItemPredictedGenderField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemPredictedGenderField value,
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
        public const string PredictedGender = "predicted_gender";
    }
}
