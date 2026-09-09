using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateInterestCategoryListsRequestType.UpdateInterestCategoryListsRequestTypeSerializer)
)]
[Serializable]
public readonly record struct UpdateInterestCategoryListsRequestType : IStringEnum
{
    public static readonly UpdateInterestCategoryListsRequestType Checkboxes = new(
        Values.Checkboxes
    );

    public static readonly UpdateInterestCategoryListsRequestType Dropdown = new(Values.Dropdown);

    public static readonly UpdateInterestCategoryListsRequestType Radio = new(Values.Radio);

    public static readonly UpdateInterestCategoryListsRequestType Hidden = new(Values.Hidden);

    public UpdateInterestCategoryListsRequestType(string value)
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
    public static UpdateInterestCategoryListsRequestType FromCustom(string value)
    {
        return new UpdateInterestCategoryListsRequestType(value);
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

    public static bool operator ==(UpdateInterestCategoryListsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateInterestCategoryListsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateInterestCategoryListsRequestType value) =>
        value.Value;

    public static explicit operator UpdateInterestCategoryListsRequestType(string value) =>
        new(value);

    internal class UpdateInterestCategoryListsRequestTypeSerializer
        : JsonConverter<UpdateInterestCategoryListsRequestType>
    {
        public override UpdateInterestCategoryListsRequestType Read(
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
            return new UpdateInterestCategoryListsRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateInterestCategoryListsRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateInterestCategoryListsRequestType ReadAsPropertyName(
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
            return new UpdateInterestCategoryListsRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateInterestCategoryListsRequestType value,
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
