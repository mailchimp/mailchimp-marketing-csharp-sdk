using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateBatchesRequestOperationsItemMethod.CreateBatchesRequestOperationsItemMethodSerializer)
)]
[Serializable]
public readonly record struct CreateBatchesRequestOperationsItemMethod : IStringEnum
{
    public static readonly CreateBatchesRequestOperationsItemMethod Get = new(Values.Get);

    public static readonly CreateBatchesRequestOperationsItemMethod Post = new(Values.Post);

    public static readonly CreateBatchesRequestOperationsItemMethod Put = new(Values.Put);

    public static readonly CreateBatchesRequestOperationsItemMethod Patch = new(Values.Patch);

    public static readonly CreateBatchesRequestOperationsItemMethod Delete = new(Values.Delete);

    public CreateBatchesRequestOperationsItemMethod(string value)
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
    public static CreateBatchesRequestOperationsItemMethod FromCustom(string value)
    {
        return new CreateBatchesRequestOperationsItemMethod(value);
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
        CreateBatchesRequestOperationsItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateBatchesRequestOperationsItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateBatchesRequestOperationsItemMethod value) =>
        value.Value;

    public static explicit operator CreateBatchesRequestOperationsItemMethod(string value) =>
        new(value);

    internal class CreateBatchesRequestOperationsItemMethodSerializer
        : JsonConverter<CreateBatchesRequestOperationsItemMethod>
    {
        public override CreateBatchesRequestOperationsItemMethod Read(
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
            return new CreateBatchesRequestOperationsItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateBatchesRequestOperationsItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateBatchesRequestOperationsItemMethod ReadAsPropertyName(
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
            return new CreateBatchesRequestOperationsItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateBatchesRequestOperationsItemMethod value,
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
    }
}
