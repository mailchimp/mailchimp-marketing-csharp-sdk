using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(MergeFieldType.MergeFieldTypeSerializer))]
[Serializable]
public readonly record struct MergeFieldType : IStringEnum
{
    public static readonly MergeFieldType Text = new(Values.Text);

    public static readonly MergeFieldType Number = new(Values.Number);

    public static readonly MergeFieldType Address = new(Values.Address);

    public static readonly MergeFieldType Phone = new(Values.Phone);

    public static readonly MergeFieldType Date = new(Values.Date);

    public static readonly MergeFieldType Url = new(Values.Url);

    public static readonly MergeFieldType Imageurl = new(Values.Imageurl);

    public static readonly MergeFieldType Radio = new(Values.Radio);

    public static readonly MergeFieldType Dropdown = new(Values.Dropdown);

    public static readonly MergeFieldType Birthday = new(Values.Birthday);

    public static readonly MergeFieldType Zip = new(Values.Zip);

    public MergeFieldType(string value)
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
    public static MergeFieldType FromCustom(string value)
    {
        return new MergeFieldType(value);
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

    public static bool operator ==(MergeFieldType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MergeFieldType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MergeFieldType value) => value.Value;

    public static explicit operator MergeFieldType(string value) => new(value);

    internal class MergeFieldTypeSerializer : JsonConverter<MergeFieldType>
    {
        public override MergeFieldType Read(
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
            return new MergeFieldType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MergeFieldType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MergeFieldType ReadAsPropertyName(
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
            return new MergeFieldType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MergeFieldType value,
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
