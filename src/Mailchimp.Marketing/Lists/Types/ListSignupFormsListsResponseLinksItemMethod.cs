using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSignupFormsListsResponseLinksItemMethod.ListSignupFormsListsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListSignupFormsListsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListSignupFormsListsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListSignupFormsListsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListSignupFormsListsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListSignupFormsListsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListSignupFormsListsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListSignupFormsListsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListSignupFormsListsResponseLinksItemMethod Head = new(Values.Head);

    public ListSignupFormsListsResponseLinksItemMethod(string value)
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
    public static ListSignupFormsListsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListSignupFormsListsResponseLinksItemMethod(value);
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
        ListSignupFormsListsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSignupFormsListsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListSignupFormsListsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListSignupFormsListsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListSignupFormsListsResponseLinksItemMethodSerializer
        : JsonConverter<ListSignupFormsListsResponseLinksItemMethod>
    {
        public override ListSignupFormsListsResponseLinksItemMethod Read(
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
            return new ListSignupFormsListsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSignupFormsListsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSignupFormsListsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListSignupFormsListsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSignupFormsListsResponseLinksItemMethod value,
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
