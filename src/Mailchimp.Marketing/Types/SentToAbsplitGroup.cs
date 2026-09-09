using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SentToAbsplitGroup.SentToAbsplitGroupSerializer))]
[Serializable]
public readonly record struct SentToAbsplitGroup : IStringEnum
{
    public static readonly SentToAbsplitGroup A = new(Values.A);

    public static readonly SentToAbsplitGroup B = new(Values.B);

    public static readonly SentToAbsplitGroup Winner = new(Values.Winner);

    public SentToAbsplitGroup(string value)
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
    public static SentToAbsplitGroup FromCustom(string value)
    {
        return new SentToAbsplitGroup(value);
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

    public static bool operator ==(SentToAbsplitGroup value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SentToAbsplitGroup value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SentToAbsplitGroup value) => value.Value;

    public static explicit operator SentToAbsplitGroup(string value) => new(value);

    internal class SentToAbsplitGroupSerializer : JsonConverter<SentToAbsplitGroup>
    {
        public override SentToAbsplitGroup Read(
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
            return new SentToAbsplitGroup(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SentToAbsplitGroup value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SentToAbsplitGroup ReadAsPropertyName(
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
            return new SentToAbsplitGroup(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SentToAbsplitGroup value,
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
        public const string A = "a";

        public const string B = "b";

        public const string Winner = "winner";
    }
}
