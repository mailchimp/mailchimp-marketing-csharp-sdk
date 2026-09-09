using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListVerifiedDomainsResponseDomainsItemStatus.ListVerifiedDomainsResponseDomainsItemStatusSerializer)
)]
[Serializable]
public readonly record struct ListVerifiedDomainsResponseDomainsItemStatus : IStringEnum
{
    public static readonly ListVerifiedDomainsResponseDomainsItemStatus VerificationInProgress =
        new(Values.VerificationInProgress);

    public static readonly ListVerifiedDomainsResponseDomainsItemStatus Verified = new(
        Values.Verified
    );

    public static readonly ListVerifiedDomainsResponseDomainsItemStatus Expired = new(
        Values.Expired
    );

    public static readonly ListVerifiedDomainsResponseDomainsItemStatus Error = new(Values.Error);

    public static readonly ListVerifiedDomainsResponseDomainsItemStatus AuthenticationInProgress =
        new(Values.AuthenticationInProgress);

    public static readonly ListVerifiedDomainsResponseDomainsItemStatus AuthenticationError = new(
        Values.AuthenticationError
    );

    public static readonly ListVerifiedDomainsResponseDomainsItemStatus Authenticated = new(
        Values.Authenticated
    );

    public ListVerifiedDomainsResponseDomainsItemStatus(string value)
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
    public static ListVerifiedDomainsResponseDomainsItemStatus FromCustom(string value)
    {
        return new ListVerifiedDomainsResponseDomainsItemStatus(value);
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
        ListVerifiedDomainsResponseDomainsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListVerifiedDomainsResponseDomainsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListVerifiedDomainsResponseDomainsItemStatus value) =>
        value.Value;

    public static explicit operator ListVerifiedDomainsResponseDomainsItemStatus(string value) =>
        new(value);

    internal class ListVerifiedDomainsResponseDomainsItemStatusSerializer
        : JsonConverter<ListVerifiedDomainsResponseDomainsItemStatus>
    {
        public override ListVerifiedDomainsResponseDomainsItemStatus Read(
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
            return new ListVerifiedDomainsResponseDomainsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListVerifiedDomainsResponseDomainsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListVerifiedDomainsResponseDomainsItemStatus ReadAsPropertyName(
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
            return new ListVerifiedDomainsResponseDomainsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListVerifiedDomainsResponseDomainsItemStatus value,
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
        public const string VerificationInProgress = "VERIFICATION_IN_PROGRESS";

        public const string Verified = "VERIFIED";

        public const string Expired = "EXPIRED";

        public const string Error = "ERROR";

        public const string AuthenticationInProgress = "AUTHENTICATION_IN_PROGRESS";

        public const string AuthenticationError = "AUTHENTICATION_ERROR";

        public const string Authenticated = "AUTHENTICATED";
    }
}
