using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSearchCampaignsResponseLinksItemMethod.ListSearchCampaignsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListSearchCampaignsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListSearchCampaignsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListSearchCampaignsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListSearchCampaignsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListSearchCampaignsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListSearchCampaignsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListSearchCampaignsResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListSearchCampaignsResponseLinksItemMethod Head = new(Values.Head);

    public ListSearchCampaignsResponseLinksItemMethod(string value)
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
    public static ListSearchCampaignsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListSearchCampaignsResponseLinksItemMethod(value);
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
        ListSearchCampaignsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSearchCampaignsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListSearchCampaignsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListSearchCampaignsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListSearchCampaignsResponseLinksItemMethodSerializer
        : JsonConverter<ListSearchCampaignsResponseLinksItemMethod>
    {
        public override ListSearchCampaignsResponseLinksItemMethod Read(
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
            return new ListSearchCampaignsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSearchCampaignsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSearchCampaignsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListSearchCampaignsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSearchCampaignsResponseLinksItemMethod value,
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
