using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateCampaignsRequestRecipientsSegmentOptsMatch.UpdateCampaignsRequestRecipientsSegmentOptsMatchSerializer)
)]
[Serializable]
public readonly record struct UpdateCampaignsRequestRecipientsSegmentOptsMatch : IStringEnum
{
    public static readonly UpdateCampaignsRequestRecipientsSegmentOptsMatch Any = new(Values.Any);

    public static readonly UpdateCampaignsRequestRecipientsSegmentOptsMatch All = new(Values.All);

    public UpdateCampaignsRequestRecipientsSegmentOptsMatch(string value)
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
    public static UpdateCampaignsRequestRecipientsSegmentOptsMatch FromCustom(string value)
    {
        return new UpdateCampaignsRequestRecipientsSegmentOptsMatch(value);
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
        UpdateCampaignsRequestRecipientsSegmentOptsMatch value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateCampaignsRequestRecipientsSegmentOptsMatch value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdateCampaignsRequestRecipientsSegmentOptsMatch value
    ) => value.Value;

    public static explicit operator UpdateCampaignsRequestRecipientsSegmentOptsMatch(
        string value
    ) => new(value);

    internal class UpdateCampaignsRequestRecipientsSegmentOptsMatchSerializer
        : JsonConverter<UpdateCampaignsRequestRecipientsSegmentOptsMatch>
    {
        public override UpdateCampaignsRequestRecipientsSegmentOptsMatch Read(
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
            return new UpdateCampaignsRequestRecipientsSegmentOptsMatch(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateCampaignsRequestRecipientsSegmentOptsMatch value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateCampaignsRequestRecipientsSegmentOptsMatch ReadAsPropertyName(
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
            return new UpdateCampaignsRequestRecipientsSegmentOptsMatch(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateCampaignsRequestRecipientsSegmentOptsMatch value,
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
        public const string Any = "any";

        public const string All = "all";
    }
}
