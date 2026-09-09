using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListInterestCategoriesListsRequestSortDir.ListInterestCategoriesListsRequestSortDirSerializer)
)]
[Serializable]
public readonly record struct ListInterestCategoriesListsRequestSortDir : IStringEnum
{
    public static readonly ListInterestCategoriesListsRequestSortDir Asc = new(Values.Asc);

    public static readonly ListInterestCategoriesListsRequestSortDir Desc = new(Values.Desc);

    public ListInterestCategoriesListsRequestSortDir(string value)
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
    public static ListInterestCategoriesListsRequestSortDir FromCustom(string value)
    {
        return new ListInterestCategoriesListsRequestSortDir(value);
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

    public static bool operator ==(
        ListInterestCategoriesListsRequestSortDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListInterestCategoriesListsRequestSortDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListInterestCategoriesListsRequestSortDir value) =>
        value.Value;

    public static explicit operator ListInterestCategoriesListsRequestSortDir(string value) =>
        new(value);

    internal class ListInterestCategoriesListsRequestSortDirSerializer
        : JsonConverter<ListInterestCategoriesListsRequestSortDir>
    {
        public override ListInterestCategoriesListsRequestSortDir Read(
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
            return new ListInterestCategoriesListsRequestSortDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListInterestCategoriesListsRequestSortDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListInterestCategoriesListsRequestSortDir ReadAsPropertyName(
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
            return new ListInterestCategoriesListsRequestSortDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListInterestCategoriesListsRequestSortDir value,
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
