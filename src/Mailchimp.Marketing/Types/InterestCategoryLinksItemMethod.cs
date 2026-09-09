using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(InterestCategoryLinksItemMethod.InterestCategoryLinksItemMethodSerializer))]
[Serializable]
public readonly record struct InterestCategoryLinksItemMethod : IStringEnum
{
    public static readonly InterestCategoryLinksItemMethod Get = new(Values.Get);

    public static readonly InterestCategoryLinksItemMethod Post = new(Values.Post);

    public static readonly InterestCategoryLinksItemMethod Put = new(Values.Put);

    public static readonly InterestCategoryLinksItemMethod Patch = new(Values.Patch);

    public static readonly InterestCategoryLinksItemMethod Delete = new(Values.Delete);

    public static readonly InterestCategoryLinksItemMethod Options = new(Values.Options);

    public static readonly InterestCategoryLinksItemMethod Head = new(Values.Head);

    public InterestCategoryLinksItemMethod(string value)
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
    public static InterestCategoryLinksItemMethod FromCustom(string value)
    {
        return new InterestCategoryLinksItemMethod(value);
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

    public static bool operator ==(InterestCategoryLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InterestCategoryLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InterestCategoryLinksItemMethod value) => value.Value;

    public static explicit operator InterestCategoryLinksItemMethod(string value) => new(value);

    internal class InterestCategoryLinksItemMethodSerializer
        : JsonConverter<InterestCategoryLinksItemMethod>
    {
        public override InterestCategoryLinksItemMethod Read(
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
            return new InterestCategoryLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InterestCategoryLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InterestCategoryLinksItemMethod ReadAsPropertyName(
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
            return new InterestCategoryLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InterestCategoryLinksItemMethod value,
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
