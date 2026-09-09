using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ECommerceOrderPromosItemType.ECommerceOrderPromosItemTypeSerializer))]
[Serializable]
public readonly record struct ECommerceOrderPromosItemType : IStringEnum
{
    public static readonly ECommerceOrderPromosItemType Fixed = new(Values.Fixed);

    public static readonly ECommerceOrderPromosItemType Percentage = new(Values.Percentage);

    public ECommerceOrderPromosItemType(string value)
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
    public static ECommerceOrderPromosItemType FromCustom(string value)
    {
        return new ECommerceOrderPromosItemType(value);
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

    public static bool operator ==(ECommerceOrderPromosItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ECommerceOrderPromosItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ECommerceOrderPromosItemType value) => value.Value;

    public static explicit operator ECommerceOrderPromosItemType(string value) => new(value);

    internal class ECommerceOrderPromosItemTypeSerializer
        : JsonConverter<ECommerceOrderPromosItemType>
    {
        public override ECommerceOrderPromosItemType Read(
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
            return new ECommerceOrderPromosItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ECommerceOrderPromosItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ECommerceOrderPromosItemType ReadAsPropertyName(
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
            return new ECommerceOrderPromosItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ECommerceOrderPromosItemType value,
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
        public const string Fixed = "fixed";

        public const string Percentage = "percentage";
    }
}
