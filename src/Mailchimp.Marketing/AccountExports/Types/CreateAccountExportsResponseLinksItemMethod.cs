using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateAccountExportsResponseLinksItemMethod.CreateAccountExportsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct CreateAccountExportsResponseLinksItemMethod : IStringEnum
{
    public static readonly CreateAccountExportsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly CreateAccountExportsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly CreateAccountExportsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly CreateAccountExportsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly CreateAccountExportsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly CreateAccountExportsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly CreateAccountExportsResponseLinksItemMethod Head = new(Values.Head);

    public CreateAccountExportsResponseLinksItemMethod(string value)
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
    public static CreateAccountExportsResponseLinksItemMethod FromCustom(string value)
    {
        return new CreateAccountExportsResponseLinksItemMethod(value);
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
        CreateAccountExportsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateAccountExportsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateAccountExportsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator CreateAccountExportsResponseLinksItemMethod(string value) =>
        new(value);

    internal class CreateAccountExportsResponseLinksItemMethodSerializer
        : JsonConverter<CreateAccountExportsResponseLinksItemMethod>
    {
        public override CreateAccountExportsResponseLinksItemMethod Read(
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
            return new CreateAccountExportsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateAccountExportsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateAccountExportsResponseLinksItemMethod ReadAsPropertyName(
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
            return new CreateAccountExportsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateAccountExportsResponseLinksItemMethod value,
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
