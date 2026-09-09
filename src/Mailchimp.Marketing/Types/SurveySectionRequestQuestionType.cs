using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SurveySectionRequestQuestionType.SurveySectionRequestQuestionTypeSerializer))]
[Serializable]
public readonly record struct SurveySectionRequestQuestionType : IStringEnum
{
    public static readonly SurveySectionRequestQuestionType PickOne = new(Values.PickOne);

    public static readonly SurveySectionRequestQuestionType PickMany = new(Values.PickMany);

    public static readonly SurveySectionRequestQuestionType Range = new(Values.Range);

    public static readonly SurveySectionRequestQuestionType Text = new(Values.Text);

    public static readonly SurveySectionRequestQuestionType Email = new(Values.Email);

    public static readonly SurveySectionRequestQuestionType ContactInformation = new(
        Values.ContactInformation
    );

    public static readonly SurveySectionRequestQuestionType Dropdown = new(Values.Dropdown);

    public SurveySectionRequestQuestionType(string value)
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
    public static SurveySectionRequestQuestionType FromCustom(string value)
    {
        return new SurveySectionRequestQuestionType(value);
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

    public static bool operator ==(SurveySectionRequestQuestionType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SurveySectionRequestQuestionType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SurveySectionRequestQuestionType value) => value.Value;

    public static explicit operator SurveySectionRequestQuestionType(string value) => new(value);

    internal class SurveySectionRequestQuestionTypeSerializer
        : JsonConverter<SurveySectionRequestQuestionType>
    {
        public override SurveySectionRequestQuestionType Read(
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
            return new SurveySectionRequestQuestionType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SurveySectionRequestQuestionType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SurveySectionRequestQuestionType ReadAsPropertyName(
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
            return new SurveySectionRequestQuestionType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SurveySectionRequestQuestionType value,
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
        public const string PickOne = "pickOne";

        public const string PickMany = "pickMany";

        public const string Range = "range";

        public const string Text = "text";

        public const string Email = "email";

        public const string ContactInformation = "contactInformation";

        public const string Dropdown = "dropdown";
    }
}
