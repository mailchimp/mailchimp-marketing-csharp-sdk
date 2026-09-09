using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListCampaignsResponseLinksItemMethod.ListCampaignsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListCampaignsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListCampaignsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListCampaignsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListCampaignsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListCampaignsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListCampaignsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListCampaignsResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListCampaignsResponseLinksItemMethod Head = new(Values.Head);

    public ListCampaignsResponseLinksItemMethod(string value)
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
    public static ListCampaignsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListCampaignsResponseLinksItemMethod(value);
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

    public static bool operator ==(ListCampaignsResponseLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListCampaignsResponseLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListCampaignsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListCampaignsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListCampaignsResponseLinksItemMethodSerializer
        : JsonConverter<ListCampaignsResponseLinksItemMethod>
    {
        public override ListCampaignsResponseLinksItemMethod Read(
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
            return new ListCampaignsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListCampaignsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListCampaignsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListCampaignsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListCampaignsResponseLinksItemMethod value,
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
