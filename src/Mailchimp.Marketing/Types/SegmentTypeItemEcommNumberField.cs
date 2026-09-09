using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemEcommNumberField.SegmentTypeItemEcommNumberFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemEcommNumberField : IStringEnum
{
    public static readonly SegmentTypeItemEcommNumberField EcommSpentAvg = new(
        Values.EcommSpentAvg
    );

    public static readonly SegmentTypeItemEcommNumberField EcommOrders = new(Values.EcommOrders);

    public static readonly SegmentTypeItemEcommNumberField EcommProdAll = new(Values.EcommProdAll);

    public static readonly SegmentTypeItemEcommNumberField EcommAvgOrd = new(Values.EcommAvgOrd);

    public SegmentTypeItemEcommNumberField(string value)
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
    public static SegmentTypeItemEcommNumberField FromCustom(string value)
    {
        return new SegmentTypeItemEcommNumberField(value);
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

    public static bool operator ==(SegmentTypeItemEcommNumberField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEcommNumberField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEcommNumberField value) => value.Value;

    public static explicit operator SegmentTypeItemEcommNumberField(string value) => new(value);

    internal class SegmentTypeItemEcommNumberFieldSerializer
        : JsonConverter<SegmentTypeItemEcommNumberField>
    {
        public override SegmentTypeItemEcommNumberField Read(
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
            return new SegmentTypeItemEcommNumberField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommNumberField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEcommNumberField ReadAsPropertyName(
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
            return new SegmentTypeItemEcommNumberField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommNumberField value,
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
        public const string EcommSpentAvg = "ecomm_spent_avg";

        public const string EcommOrders = "ecomm_orders";

        public const string EcommProdAll = "ecomm_prod_all";

        public const string EcommAvgOrd = "ecomm_avg_ord";
    }
}
