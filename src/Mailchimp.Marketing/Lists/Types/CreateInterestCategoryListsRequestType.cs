using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateInterestCategoryListsRequestType.CreateInterestCategoryListsRequestTypeSerializer)
)]
[Serializable]
public readonly record struct CreateInterestCategoryListsRequestType : IStringEnum
{
    public static readonly CreateInterestCategoryListsRequestType Checkboxes = new(
        Values.Checkboxes
    );

    public static readonly CreateInterestCategoryListsRequestType Dropdown = new(Values.Dropdown);

    public static readonly CreateInterestCategoryListsRequestType Radio = new(Values.Radio);

    public static readonly CreateInterestCategoryListsRequestType Hidden = new(Values.Hidden);

    public CreateInterestCategoryListsRequestType(string value)
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
    public static CreateInterestCategoryListsRequestType FromCustom(string value)
    {
        return new CreateInterestCategoryListsRequestType(value);
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

    public static bool operator ==(CreateInterestCategoryListsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateInterestCategoryListsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateInterestCategoryListsRequestType value) =>
        value.Value;

    public static explicit operator CreateInterestCategoryListsRequestType(string value) =>
        new(value);

    internal class CreateInterestCategoryListsRequestTypeSerializer
        : JsonConverter<CreateInterestCategoryListsRequestType>
    {
        public override CreateInterestCategoryListsRequestType Read(
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
            return new CreateInterestCategoryListsRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateInterestCategoryListsRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateInterestCategoryListsRequestType ReadAsPropertyName(
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
            return new CreateInterestCategoryListsRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateInterestCategoryListsRequestType value,
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
