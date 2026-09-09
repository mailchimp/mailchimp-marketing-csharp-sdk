using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(BatchStatus.BatchStatusSerializer))]
[Serializable]
public readonly record struct BatchStatus : IStringEnum
{
    public static readonly BatchStatus Pending = new(Values.Pending);

    public static readonly BatchStatus Preprocessing = new(Values.Preprocessing);

    public static readonly BatchStatus Started = new(Values.Started);

    public static readonly BatchStatus Finalizing = new(Values.Finalizing);

    public static readonly BatchStatus Finished = new(Values.Finished);

    public BatchStatus(string value)
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
    public static BatchStatus FromCustom(string value)
    {
        return new BatchStatus(value);
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

    public static bool operator ==(BatchStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BatchStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BatchStatus value) => value.Value;

    public static explicit operator BatchStatus(string value) => new(value);

    internal class BatchStatusSerializer : JsonConverter<BatchStatus>
    {
        public override BatchStatus Read(
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
            return new BatchStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BatchStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BatchStatus ReadAsPropertyName(
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
            return new BatchStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BatchStatus value,
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
        public const string Pending = "pending";

        public const string Preprocessing = "preprocessing";

        public const string Started = "started";

        public const string Finalizing = "finalizing";

        public const string Finished = "finished";
    }
}
