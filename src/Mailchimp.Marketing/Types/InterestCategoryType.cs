using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(InterestCategoryType.InterestCategoryTypeSerializer))]
[Serializable]
public readonly record struct InterestCategoryType : IStringEnum
{
    public static readonly InterestCategoryType Checkboxes = new(Values.Checkboxes);

    public static readonly InterestCategoryType Dropdown = new(Values.Dropdown);

    public static readonly InterestCategoryType Radio = new(Values.Radio);

    public static readonly InterestCategoryType Hidden = new(Values.Hidden);

    public InterestCategoryType(string value)
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
    public static InterestCategoryType FromCustom(string value)
    {
        return new InterestCategoryType(value);
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

    public static bool operator ==(InterestCategoryType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InterestCategoryType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InterestCategoryType value) => value.Value;

    public static explicit operator InterestCategoryType(string value) => new(value);

    internal class InterestCategoryTypeSerializer : JsonConverter<InterestCategoryType>
    {
        public override InterestCategoryType Read(
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
            return new InterestCategoryType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InterestCategoryType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InterestCategoryType ReadAsPropertyName(
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
            return new InterestCategoryType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InterestCategoryType value,
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
        public const string Checkboxes = "checkboxes";

        public const string Dropdown = "dropdown";

        public const string Radio = "radio";

        public const string Hidden = "hidden";
    }
}
