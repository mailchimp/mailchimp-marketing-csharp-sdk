using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(AbTestingOptionsSplitTest.AbTestingOptionsSplitTestSerializer))]
[Serializable]
public readonly record struct AbTestingOptionsSplitTest : IStringEnum
{
    public static readonly AbTestingOptionsSplitTest Subject = new(Values.Subject);

    public static readonly AbTestingOptionsSplitTest FromName = new(Values.FromName);

    public static readonly AbTestingOptionsSplitTest Schedule = new(Values.Schedule);

    public AbTestingOptionsSplitTest(string value)
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
    public static AbTestingOptionsSplitTest FromCustom(string value)
    {
        return new AbTestingOptionsSplitTest(value);
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

    public static bool operator ==(AbTestingOptionsSplitTest value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AbTestingOptionsSplitTest value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AbTestingOptionsSplitTest value) => value.Value;

    public static explicit operator AbTestingOptionsSplitTest(string value) => new(value);

    internal class AbTestingOptionsSplitTestSerializer : JsonConverter<AbTestingOptionsSplitTest>
    {
        public override AbTestingOptionsSplitTest Read(
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
            return new AbTestingOptionsSplitTest(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AbTestingOptionsSplitTest value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AbTestingOptionsSplitTest ReadAsPropertyName(
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
            return new AbTestingOptionsSplitTest(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AbTestingOptionsSplitTest value,
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
        public const string Subject = "subject";

        public const string FromName = "from_name";

        public const string Schedule = "schedule";
    }
}
