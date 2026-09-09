using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListLandingPagesRequestSortDir.ListLandingPagesRequestSortDirSerializer))]
[Serializable]
public readonly record struct ListLandingPagesRequestSortDir : IStringEnum
{
    public static readonly ListLandingPagesRequestSortDir Asc = new(Values.Asc);

    public static readonly ListLandingPagesRequestSortDir Desc = new(Values.Desc);

    public ListLandingPagesRequestSortDir(string value)
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
    public static ListLandingPagesRequestSortDir FromCustom(string value)
    {
        return new ListLandingPagesRequestSortDir(value);
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

    public static bool operator ==(ListLandingPagesRequestSortDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListLandingPagesRequestSortDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListLandingPagesRequestSortDir value) => value.Value;

    public static explicit operator ListLandingPagesRequestSortDir(string value) => new(value);

    internal class ListLandingPagesRequestSortDirSerializer
        : JsonConverter<ListLandingPagesRequestSortDir>
    {
        public override ListLandingPagesRequestSortDir Read(
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
            return new ListLandingPagesRequestSortDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListLandingPagesRequestSortDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListLandingPagesRequestSortDir ReadAsPropertyName(
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
            return new ListLandingPagesRequestSortDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListLandingPagesRequestSortDir value,
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
        public const string Asc = "ASC";

        public const string Desc = "DESC";
    }
}
