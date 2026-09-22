using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(AudiencesContactStatus.AudiencesContactStatusSerializer))]
[Serializable]
public readonly record struct AudiencesContactStatus : IStringEnum
{
    public static readonly AudiencesContactStatus Active = new(Values.Active);

    public static readonly AudiencesContactStatus Archived = new(Values.Archived);

    public AudiencesContactStatus(string value)
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
    public static AudiencesContactStatus FromCustom(string value)
    {
        return new AudiencesContactStatus(value);
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

    public static bool operator ==(AudiencesContactStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AudiencesContactStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AudiencesContactStatus value) => value.Value;

    public static explicit operator AudiencesContactStatus(string value) => new(value);

    internal class AudiencesContactStatusSerializer : JsonConverter<AudiencesContactStatus>
    {
        public override AudiencesContactStatus Read(
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
            return new AudiencesContactStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AudiencesContactStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AudiencesContactStatus ReadAsPropertyName(
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
            return new AudiencesContactStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AudiencesContactStatus value,
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
        public const string Active = "active";

        public const string Archived = "archived";
    }
}
