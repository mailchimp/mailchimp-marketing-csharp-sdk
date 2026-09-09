using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListTemplatesRequestSortField.ListTemplatesRequestSortFieldSerializer))]
[Serializable]
public readonly record struct ListTemplatesRequestSortField : IStringEnum
{
    public static readonly ListTemplatesRequestSortField DateCreated = new(Values.DateCreated);

    public static readonly ListTemplatesRequestSortField DateEdited = new(Values.DateEdited);

    public static readonly ListTemplatesRequestSortField Name = new(Values.Name);

    public ListTemplatesRequestSortField(string value)
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
    public static ListTemplatesRequestSortField FromCustom(string value)
    {
        return new ListTemplatesRequestSortField(value);
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

    public static bool operator ==(ListTemplatesRequestSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListTemplatesRequestSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListTemplatesRequestSortField value) => value.Value;

    public static explicit operator ListTemplatesRequestSortField(string value) => new(value);

    internal class ListTemplatesRequestSortFieldSerializer
        : JsonConverter<ListTemplatesRequestSortField>
    {
        public override ListTemplatesRequestSortField Read(
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
            return new ListTemplatesRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListTemplatesRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListTemplatesRequestSortField ReadAsPropertyName(
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
            return new ListTemplatesRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListTemplatesRequestSortField value,
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
        public const string DateCreated = "date_created";

        public const string DateEdited = "date_edited";

        public const string Name = "name";
    }
}
