using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListAuthorizedAppsResponseLinksItemMethod.ListAuthorizedAppsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListAuthorizedAppsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListAuthorizedAppsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListAuthorizedAppsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListAuthorizedAppsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListAuthorizedAppsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListAuthorizedAppsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListAuthorizedAppsResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListAuthorizedAppsResponseLinksItemMethod Head = new(Values.Head);

    public ListAuthorizedAppsResponseLinksItemMethod(string value)
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
    public static ListAuthorizedAppsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListAuthorizedAppsResponseLinksItemMethod(value);
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
        ListAuthorizedAppsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListAuthorizedAppsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListAuthorizedAppsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListAuthorizedAppsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListAuthorizedAppsResponseLinksItemMethodSerializer
        : JsonConverter<ListAuthorizedAppsResponseLinksItemMethod>
    {
        public override ListAuthorizedAppsResponseLinksItemMethod Read(
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
            return new ListAuthorizedAppsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListAuthorizedAppsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListAuthorizedAppsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListAuthorizedAppsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListAuthorizedAppsResponseLinksItemMethod value,
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
        public const string Get = "GET";

        public const string Post = "POST";

        public const string Put = "PUT";

        public const string Patch = "PATCH";

        public const string Delete = "DELETE";

        public const string Options = "OPTIONS";

        public const string Head = "HEAD";
    }
}
