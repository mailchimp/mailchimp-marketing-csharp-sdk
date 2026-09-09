using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CreateMergeFieldListsRequestType.CreateMergeFieldListsRequestTypeSerializer))]
[Serializable]
public readonly record struct CreateMergeFieldListsRequestType : IStringEnum
{
    public static readonly CreateMergeFieldListsRequestType Text = new(Values.Text);

    public static readonly CreateMergeFieldListsRequestType Number = new(Values.Number);

    public static readonly CreateMergeFieldListsRequestType Address = new(Values.Address);

    public static readonly CreateMergeFieldListsRequestType Phone = new(Values.Phone);

    public static readonly CreateMergeFieldListsRequestType Date = new(Values.Date);

    public static readonly CreateMergeFieldListsRequestType Url = new(Values.Url);

    public static readonly CreateMergeFieldListsRequestType Imageurl = new(Values.Imageurl);

    public static readonly CreateMergeFieldListsRequestType Radio = new(Values.Radio);

    public static readonly CreateMergeFieldListsRequestType Dropdown = new(Values.Dropdown);

    public static readonly CreateMergeFieldListsRequestType Birthday = new(Values.Birthday);

    public static readonly CreateMergeFieldListsRequestType Zip = new(Values.Zip);

    public CreateMergeFieldListsRequestType(string value)
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
    public static CreateMergeFieldListsRequestType FromCustom(string value)
    {
        return new CreateMergeFieldListsRequestType(value);
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

    public static bool operator ==(CreateMergeFieldListsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateMergeFieldListsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateMergeFieldListsRequestType value) => value.Value;

    public static explicit operator CreateMergeFieldListsRequestType(string value) => new(value);

    internal class CreateMergeFieldListsRequestTypeSerializer
        : JsonConverter<CreateMergeFieldListsRequestType>
    {
        public override CreateMergeFieldListsRequestType Read(
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
            return new CreateMergeFieldListsRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateMergeFieldListsRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateMergeFieldListsRequestType ReadAsPropertyName(
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
            return new CreateMergeFieldListsRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateMergeFieldListsRequestType value,
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
        public const string Text = "text";

        public const string Number = "number";

        public const string Address = "address";

        public const string Phone = "phone";

        public const string Date = "date";

        public const string Url = "url";

        public const string Imageurl = "imageurl";

        public const string Radio = "radio";

        public const string Dropdown = "dropdown";

        public const string Birthday = "birthday";

        public const string Zip = "zip";
    }
}
