using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(GetCampaignFoldersResponseLinksItemMethod.GetCampaignFoldersResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct GetCampaignFoldersResponseLinksItemMethod : IStringEnum
{
    public static readonly GetCampaignFoldersResponseLinksItemMethod Get = new(Values.Get);

    public static readonly GetCampaignFoldersResponseLinksItemMethod Post = new(Values.Post);

    public static readonly GetCampaignFoldersResponseLinksItemMethod Put = new(Values.Put);

    public static readonly GetCampaignFoldersResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly GetCampaignFoldersResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly GetCampaignFoldersResponseLinksItemMethod Options = new(Values.Options);

    public static readonly GetCampaignFoldersResponseLinksItemMethod Head = new(Values.Head);

    public GetCampaignFoldersResponseLinksItemMethod(string value)
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
    public static GetCampaignFoldersResponseLinksItemMethod FromCustom(string value)
    {
        return new GetCampaignFoldersResponseLinksItemMethod(value);
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
        GetCampaignFoldersResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetCampaignFoldersResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetCampaignFoldersResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator GetCampaignFoldersResponseLinksItemMethod(string value) =>
        new(value);

    internal class GetCampaignFoldersResponseLinksItemMethodSerializer
        : JsonConverter<GetCampaignFoldersResponseLinksItemMethod>
    {
        public override GetCampaignFoldersResponseLinksItemMethod Read(
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
            return new GetCampaignFoldersResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetCampaignFoldersResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetCampaignFoldersResponseLinksItemMethod ReadAsPropertyName(
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
            return new GetCampaignFoldersResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetCampaignFoldersResponseLinksItemMethod value,
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
