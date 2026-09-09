using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListFeedbackCampaignsResponseFeedbackItemSource.ListFeedbackCampaignsResponseFeedbackItemSourceSerializer)
)]
[Serializable]
public readonly record struct ListFeedbackCampaignsResponseFeedbackItemSource : IStringEnum
{
    public static readonly ListFeedbackCampaignsResponseFeedbackItemSource Api = new(Values.Api);

    public static readonly ListFeedbackCampaignsResponseFeedbackItemSource Email = new(
        Values.Email
    );

    public static readonly ListFeedbackCampaignsResponseFeedbackItemSource Sms = new(Values.Sms);

    public static readonly ListFeedbackCampaignsResponseFeedbackItemSource Web = new(Values.Web);

    public static readonly ListFeedbackCampaignsResponseFeedbackItemSource Ios = new(Values.Ios);

    public static readonly ListFeedbackCampaignsResponseFeedbackItemSource Android = new(
        Values.Android
    );

    public ListFeedbackCampaignsResponseFeedbackItemSource(string value)
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
    public static ListFeedbackCampaignsResponseFeedbackItemSource FromCustom(string value)
    {
        return new ListFeedbackCampaignsResponseFeedbackItemSource(value);
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
        ListFeedbackCampaignsResponseFeedbackItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListFeedbackCampaignsResponseFeedbackItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListFeedbackCampaignsResponseFeedbackItemSource value) =>
        value.Value;

    public static explicit operator ListFeedbackCampaignsResponseFeedbackItemSource(string value) =>
        new(value);

    internal class ListFeedbackCampaignsResponseFeedbackItemSourceSerializer
        : JsonConverter<ListFeedbackCampaignsResponseFeedbackItemSource>
    {
        public override ListFeedbackCampaignsResponseFeedbackItemSource Read(
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
            return new ListFeedbackCampaignsResponseFeedbackItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFeedbackCampaignsResponseFeedbackItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFeedbackCampaignsResponseFeedbackItemSource ReadAsPropertyName(
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
            return new ListFeedbackCampaignsResponseFeedbackItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFeedbackCampaignsResponseFeedbackItemSource value,
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
        public const string Api = "api";

        public const string Email = "email";

        public const string Sms = "sms";

        public const string Web = "web";

        public const string Ios = "ios";

        public const string Android = "android";
    }
}
