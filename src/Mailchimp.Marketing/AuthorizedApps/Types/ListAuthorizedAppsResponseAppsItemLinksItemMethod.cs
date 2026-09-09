using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListAuthorizedAppsResponseAppsItemLinksItemMethod.ListAuthorizedAppsResponseAppsItemLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListAuthorizedAppsResponseAppsItemLinksItemMethod : IStringEnum
{
    public static readonly ListAuthorizedAppsResponseAppsItemLinksItemMethod Get = new(Values.Get);

    public static readonly ListAuthorizedAppsResponseAppsItemLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListAuthorizedAppsResponseAppsItemLinksItemMethod Put = new(Values.Put);

    public static readonly ListAuthorizedAppsResponseAppsItemLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListAuthorizedAppsResponseAppsItemLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListAuthorizedAppsResponseAppsItemLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListAuthorizedAppsResponseAppsItemLinksItemMethod Head = new(
        Values.Head
    );

    public ListAuthorizedAppsResponseAppsItemLinksItemMethod(string value)
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
    public static ListAuthorizedAppsResponseAppsItemLinksItemMethod FromCustom(string value)
    {
        return new ListAuthorizedAppsResponseAppsItemLinksItemMethod(value);
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
        ListAuthorizedAppsResponseAppsItemLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListAuthorizedAppsResponseAppsItemLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListAuthorizedAppsResponseAppsItemLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListAuthorizedAppsResponseAppsItemLinksItemMethod(
        string value
    ) => new(value);

    internal class ListAuthorizedAppsResponseAppsItemLinksItemMethodSerializer
        : JsonConverter<ListAuthorizedAppsResponseAppsItemLinksItemMethod>
    {
        public override ListAuthorizedAppsResponseAppsItemLinksItemMethod Read(
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
            return new ListAuthorizedAppsResponseAppsItemLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListAuthorizedAppsResponseAppsItemLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListAuthorizedAppsResponseAppsItemLinksItemMethod ReadAsPropertyName(
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
            return new ListAuthorizedAppsResponseAppsItemLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListAuthorizedAppsResponseAppsItemLinksItemMethod value,
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
