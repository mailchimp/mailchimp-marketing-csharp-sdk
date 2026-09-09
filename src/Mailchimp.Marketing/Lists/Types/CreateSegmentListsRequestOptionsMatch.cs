using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateSegmentListsRequestOptionsMatch.CreateSegmentListsRequestOptionsMatchSerializer)
)]
[Serializable]
public readonly record struct CreateSegmentListsRequestOptionsMatch : IStringEnum
{
    public static readonly CreateSegmentListsRequestOptionsMatch Any = new(Values.Any);

    public static readonly CreateSegmentListsRequestOptionsMatch All = new(Values.All);

    public CreateSegmentListsRequestOptionsMatch(string value)
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
    public static CreateSegmentListsRequestOptionsMatch FromCustom(string value)
    {
        return new CreateSegmentListsRequestOptionsMatch(value);
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

    public static bool operator ==(CreateSegmentListsRequestOptionsMatch value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateSegmentListsRequestOptionsMatch value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateSegmentListsRequestOptionsMatch value) =>
        value.Value;

    public static explicit operator CreateSegmentListsRequestOptionsMatch(string value) =>
        new(value);

    internal class CreateSegmentListsRequestOptionsMatchSerializer
        : JsonConverter<CreateSegmentListsRequestOptionsMatch>
    {
        public override CreateSegmentListsRequestOptionsMatch Read(
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
            return new CreateSegmentListsRequestOptionsMatch(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateSegmentListsRequestOptionsMatch value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateSegmentListsRequestOptionsMatch ReadAsPropertyName(
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
            return new CreateSegmentListsRequestOptionsMatch(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateSegmentListsRequestOptionsMatch value,
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
        public const string Any = "any";

        public const string All = "all";
    }
}
