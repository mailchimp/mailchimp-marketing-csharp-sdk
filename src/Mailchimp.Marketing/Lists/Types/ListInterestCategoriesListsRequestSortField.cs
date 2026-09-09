using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListInterestCategoriesListsRequestSortField.ListInterestCategoriesListsRequestSortFieldSerializer)
)]
[Serializable]
public readonly record struct ListInterestCategoriesListsRequestSortField : IStringEnum
{
    public static readonly ListInterestCategoriesListsRequestSortField Name = new(Values.Name);

    public static readonly ListInterestCategoriesListsRequestSortField DisplayOrder = new(
        Values.DisplayOrder
    );

    public ListInterestCategoriesListsRequestSortField(string value)
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
    public static ListInterestCategoriesListsRequestSortField FromCustom(string value)
    {
        return new ListInterestCategoriesListsRequestSortField(value);
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
        ListInterestCategoriesListsRequestSortField value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListInterestCategoriesListsRequestSortField value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListInterestCategoriesListsRequestSortField value) =>
        value.Value;

    public static explicit operator ListInterestCategoriesListsRequestSortField(string value) =>
        new(value);

    internal class ListInterestCategoriesListsRequestSortFieldSerializer
        : JsonConverter<ListInterestCategoriesListsRequestSortField>
    {
        public override ListInterestCategoriesListsRequestSortField Read(
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
            return new ListInterestCategoriesListsRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListInterestCategoriesListsRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListInterestCategoriesListsRequestSortField ReadAsPropertyName(
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
            return new ListInterestCategoriesListsRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListInterestCategoriesListsRequestSortField value,
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
        public const string Name = "name";

        public const string DisplayOrder = "display_order";
    }
}
