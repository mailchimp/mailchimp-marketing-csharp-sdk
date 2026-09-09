using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateMemberTagListsRequestTagsItemStatus.CreateMemberTagListsRequestTagsItemStatusSerializer)
)]
[Serializable]
public readonly record struct CreateMemberTagListsRequestTagsItemStatus : IStringEnum
{
    public static readonly CreateMemberTagListsRequestTagsItemStatus Inactive = new(
        Values.Inactive
    );

    public static readonly CreateMemberTagListsRequestTagsItemStatus Active = new(Values.Active);

    public CreateMemberTagListsRequestTagsItemStatus(string value)
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
    public static CreateMemberTagListsRequestTagsItemStatus FromCustom(string value)
    {
        return new CreateMemberTagListsRequestTagsItemStatus(value);
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
        CreateMemberTagListsRequestTagsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateMemberTagListsRequestTagsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateMemberTagListsRequestTagsItemStatus value) =>
        value.Value;

    public static explicit operator CreateMemberTagListsRequestTagsItemStatus(string value) =>
        new(value);

    internal class CreateMemberTagListsRequestTagsItemStatusSerializer
        : JsonConverter<CreateMemberTagListsRequestTagsItemStatus>
    {
        public override CreateMemberTagListsRequestTagsItemStatus Read(
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
            return new CreateMemberTagListsRequestTagsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateMemberTagListsRequestTagsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateMemberTagListsRequestTagsItemStatus ReadAsPropertyName(
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
            return new CreateMemberTagListsRequestTagsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateMemberTagListsRequestTagsItemStatus value,
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
        public const string Inactive = "inactive";

        public const string Active = "active";
    }
}
