using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CreateMemberListsRequestStatus.CreateMemberListsRequestStatusSerializer))]
[Serializable]
public readonly record struct CreateMemberListsRequestStatus : IStringEnum
{
    public static readonly CreateMemberListsRequestStatus Subscribed = new(Values.Subscribed);

    public static readonly CreateMemberListsRequestStatus Unsubscribed = new(Values.Unsubscribed);

    public static readonly CreateMemberListsRequestStatus Cleaned = new(Values.Cleaned);

    public static readonly CreateMemberListsRequestStatus Pending = new(Values.Pending);

    public static readonly CreateMemberListsRequestStatus Transactional = new(Values.Transactional);

    public CreateMemberListsRequestStatus(string value)
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
    public static CreateMemberListsRequestStatus FromCustom(string value)
    {
        return new CreateMemberListsRequestStatus(value);
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

    public static bool operator ==(CreateMemberListsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateMemberListsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateMemberListsRequestStatus value) => value.Value;

    public static explicit operator CreateMemberListsRequestStatus(string value) => new(value);

    internal class CreateMemberListsRequestStatusSerializer
        : JsonConverter<CreateMemberListsRequestStatus>
    {
        public override CreateMemberListsRequestStatus Read(
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
            return new CreateMemberListsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateMemberListsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateMemberListsRequestStatus ReadAsPropertyName(
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
            return new CreateMemberListsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateMemberListsRequestStatus value,
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
        public const string Subscribed = "subscribed";

        public const string Unsubscribed = "unsubscribed";

        public const string Cleaned = "cleaned";

        public const string Pending = "pending";

        public const string Transactional = "transactional";
    }
}
