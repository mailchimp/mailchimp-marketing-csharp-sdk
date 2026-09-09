using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListRootResponseFirstPaymentOne.ListRootResponseFirstPaymentOneSerializer))]
[Serializable]
public readonly record struct ListRootResponseFirstPaymentOne : IStringEnum
{
    public static readonly ListRootResponseFirstPaymentOne Empty = new(Values.Empty);

    public ListRootResponseFirstPaymentOne(string value)
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
    public static ListRootResponseFirstPaymentOne FromCustom(string value)
    {
        return new ListRootResponseFirstPaymentOne(value);
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

    public static bool operator ==(ListRootResponseFirstPaymentOne value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListRootResponseFirstPaymentOne value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListRootResponseFirstPaymentOne value) => value.Value;

    public static explicit operator ListRootResponseFirstPaymentOne(string value) => new(value);

    internal class ListRootResponseFirstPaymentOneSerializer
        : JsonConverter<ListRootResponseFirstPaymentOne>
    {
        public override ListRootResponseFirstPaymentOne Read(
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
            return new ListRootResponseFirstPaymentOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListRootResponseFirstPaymentOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListRootResponseFirstPaymentOne ReadAsPropertyName(
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
            return new ListRootResponseFirstPaymentOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListRootResponseFirstPaymentOne value,
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
        public const string Empty = "";
    }
}
