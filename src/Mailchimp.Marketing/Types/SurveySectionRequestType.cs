using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SurveySectionRequestType.SurveySectionRequestTypeSerializer))]
[Serializable]
public readonly record struct SurveySectionRequestType : IStringEnum
{
    public static readonly SurveySectionRequestType Introduction = new(Values.Introduction);

    public static readonly SurveySectionRequestType Context = new(Values.Context);

    public static readonly SurveySectionRequestType Question = new(Values.Question);

    public SurveySectionRequestType(string value)
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
    public static SurveySectionRequestType FromCustom(string value)
    {
        return new SurveySectionRequestType(value);
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

    public static bool operator ==(SurveySectionRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SurveySectionRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SurveySectionRequestType value) => value.Value;

    public static explicit operator SurveySectionRequestType(string value) => new(value);

    internal class SurveySectionRequestTypeSerializer : JsonConverter<SurveySectionRequestType>
    {
        public override SurveySectionRequestType Read(
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
            return new SurveySectionRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SurveySectionRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SurveySectionRequestType ReadAsPropertyName(
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
            return new SurveySectionRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SurveySectionRequestType value,
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
        public const string Introduction = "introduction";

        public const string Context = "context";

        public const string Question = "question";
    }
}
