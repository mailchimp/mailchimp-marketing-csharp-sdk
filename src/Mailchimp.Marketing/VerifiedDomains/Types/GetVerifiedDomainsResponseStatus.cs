using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(GetVerifiedDomainsResponseStatus.GetVerifiedDomainsResponseStatusSerializer))]
[Serializable]
public readonly record struct GetVerifiedDomainsResponseStatus : IStringEnum
{
    public static readonly GetVerifiedDomainsResponseStatus VerificationInProgress = new(
        Values.VerificationInProgress
    );

    public static readonly GetVerifiedDomainsResponseStatus Verified = new(Values.Verified);

    public static readonly GetVerifiedDomainsResponseStatus Expired = new(Values.Expired);

    public static readonly GetVerifiedDomainsResponseStatus Error = new(Values.Error);

    public static readonly GetVerifiedDomainsResponseStatus AuthenticationInProgress = new(
        Values.AuthenticationInProgress
    );

    public static readonly GetVerifiedDomainsResponseStatus AuthenticationError = new(
        Values.AuthenticationError
    );

    public static readonly GetVerifiedDomainsResponseStatus Authenticated = new(
        Values.Authenticated
    );

    public GetVerifiedDomainsResponseStatus(string value)
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
    public static GetVerifiedDomainsResponseStatus FromCustom(string value)
    {
        return new GetVerifiedDomainsResponseStatus(value);
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

    public static bool operator ==(GetVerifiedDomainsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetVerifiedDomainsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetVerifiedDomainsResponseStatus value) => value.Value;

    public static explicit operator GetVerifiedDomainsResponseStatus(string value) => new(value);

    internal class GetVerifiedDomainsResponseStatusSerializer
        : JsonConverter<GetVerifiedDomainsResponseStatus>
    {
        public override GetVerifiedDomainsResponseStatus Read(
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
            return new GetVerifiedDomainsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetVerifiedDomainsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetVerifiedDomainsResponseStatus ReadAsPropertyName(
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
            return new GetVerifiedDomainsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetVerifiedDomainsResponseStatus value,
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
