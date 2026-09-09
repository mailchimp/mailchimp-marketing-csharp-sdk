using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ECommerceStoreAutomationsAbandonedBrowseStatus.ECommerceStoreAutomationsAbandonedBrowseStatusSerializer)
)]
[Serializable]
public readonly record struct ECommerceStoreAutomationsAbandonedBrowseStatus : IStringEnum
{
    public static readonly ECommerceStoreAutomationsAbandonedBrowseStatus Save = new(Values.Save);

    public static readonly ECommerceStoreAutomationsAbandonedBrowseStatus Sending = new(
        Values.Sending
    );

    public static readonly ECommerceStoreAutomationsAbandonedBrowseStatus Paused = new(
        Values.Paused
    );

    public ECommerceStoreAutomationsAbandonedBrowseStatus(string value)
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
    public static ECommerceStoreAutomationsAbandonedBrowseStatus FromCustom(string value)
    {
        return new ECommerceStoreAutomationsAbandonedBrowseStatus(value);
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
        ECommerceStoreAutomationsAbandonedBrowseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ECommerceStoreAutomationsAbandonedBrowseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ECommerceStoreAutomationsAbandonedBrowseStatus value) =>
        value.Value;

    public static explicit operator ECommerceStoreAutomationsAbandonedBrowseStatus(string value) =>
        new(value);

    internal class ECommerceStoreAutomationsAbandonedBrowseStatusSerializer
        : JsonConverter<ECommerceStoreAutomationsAbandonedBrowseStatus>
    {
        public override ECommerceStoreAutomationsAbandonedBrowseStatus Read(
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
            return new ECommerceStoreAutomationsAbandonedBrowseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ECommerceStoreAutomationsAbandonedBrowseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ECommerceStoreAutomationsAbandonedBrowseStatus ReadAsPropertyName(
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
            return new ECommerceStoreAutomationsAbandonedBrowseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ECommerceStoreAutomationsAbandonedBrowseStatus value,
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
        public const string Save = "save";

        public const string Sending = "sending";

        public const string Paused = "paused";
    }
}
