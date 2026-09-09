using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateActionTestCampaignsRequestSendType.CreateActionTestCampaignsRequestSendTypeSerializer)
)]
[Serializable]
public readonly record struct CreateActionTestCampaignsRequestSendType : IStringEnum
{
    public static readonly CreateActionTestCampaignsRequestSendType Html = new(Values.Html);

    public static readonly CreateActionTestCampaignsRequestSendType Plaintext = new(
        Values.Plaintext
    );

    public CreateActionTestCampaignsRequestSendType(string value)
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
    public static CreateActionTestCampaignsRequestSendType FromCustom(string value)
    {
        return new CreateActionTestCampaignsRequestSendType(value);
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
        CreateActionTestCampaignsRequestSendType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateActionTestCampaignsRequestSendType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateActionTestCampaignsRequestSendType value) =>
        value.Value;

    public static explicit operator CreateActionTestCampaignsRequestSendType(string value) =>
        new(value);

    internal class CreateActionTestCampaignsRequestSendTypeSerializer
        : JsonConverter<CreateActionTestCampaignsRequestSendType>
    {
        public override CreateActionTestCampaignsRequestSendType Read(
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
            return new CreateActionTestCampaignsRequestSendType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateActionTestCampaignsRequestSendType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateActionTestCampaignsRequestSendType ReadAsPropertyName(
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
            return new CreateActionTestCampaignsRequestSendType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateActionTestCampaignsRequestSendType value,
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
        public const string Html = "html";

        public const string Plaintext = "plaintext";
    }
}
