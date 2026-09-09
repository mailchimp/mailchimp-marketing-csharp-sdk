using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListRootResponsePricingPlanType.ListRootResponsePricingPlanTypeSerializer))]
[Serializable]
public readonly record struct ListRootResponsePricingPlanType : IStringEnum
{
    public static readonly ListRootResponsePricingPlanType Monthly = new(Values.Monthly);

    public static readonly ListRootResponsePricingPlanType PayAsYouGo = new(Values.PayAsYouGo);

    public static readonly ListRootResponsePricingPlanType ForeverFree = new(Values.ForeverFree);

    public ListRootResponsePricingPlanType(string value)
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
    public static ListRootResponsePricingPlanType FromCustom(string value)
    {
        return new ListRootResponsePricingPlanType(value);
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

    public static bool operator ==(ListRootResponsePricingPlanType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListRootResponsePricingPlanType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListRootResponsePricingPlanType value) => value.Value;

    public static explicit operator ListRootResponsePricingPlanType(string value) => new(value);

    internal class ListRootResponsePricingPlanTypeSerializer
        : JsonConverter<ListRootResponsePricingPlanType>
    {
        public override ListRootResponsePricingPlanType Read(
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
            return new ListRootResponsePricingPlanType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListRootResponsePricingPlanType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListRootResponsePricingPlanType ReadAsPropertyName(
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
            return new ListRootResponsePricingPlanType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListRootResponsePricingPlanType value,
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
        public const string Monthly = "monthly";

        public const string PayAsYouGo = "pay_as_you_go";

        public const string ForeverFree = "forever_free";
    }
}
