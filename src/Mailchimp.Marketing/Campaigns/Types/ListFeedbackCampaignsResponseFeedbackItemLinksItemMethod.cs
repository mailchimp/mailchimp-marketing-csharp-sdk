using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod.ListFeedbackCampaignsResponseFeedbackItemLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod : IStringEnum
{
    public static readonly ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod Get = new(
        Values.Get
    );

    public static readonly ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod Put = new(
        Values.Put
    );

    public static readonly ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod Head = new(
        Values.Head
    );

    public ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod(string value)
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
    public static ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod FromCustom(string value)
    {
        return new ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod(value);
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
        ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod(
        string value
    ) => new(value);

    internal class ListFeedbackCampaignsResponseFeedbackItemLinksItemMethodSerializer
        : JsonConverter<ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod>
    {
        public override ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod Read(
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
            return new ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod ReadAsPropertyName(
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
            return new ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFeedbackCampaignsResponseFeedbackItemLinksItemMethod value,
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
