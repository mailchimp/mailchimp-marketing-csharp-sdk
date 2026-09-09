using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AutomationWorkflowLinksItemMethod.AutomationWorkflowLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct AutomationWorkflowLinksItemMethod : IStringEnum
{
    public static readonly AutomationWorkflowLinksItemMethod Get = new(Values.Get);

    public static readonly AutomationWorkflowLinksItemMethod Post = new(Values.Post);

    public static readonly AutomationWorkflowLinksItemMethod Put = new(Values.Put);

    public static readonly AutomationWorkflowLinksItemMethod Patch = new(Values.Patch);

    public static readonly AutomationWorkflowLinksItemMethod Delete = new(Values.Delete);

    public static readonly AutomationWorkflowLinksItemMethod Options = new(Values.Options);

    public static readonly AutomationWorkflowLinksItemMethod Head = new(Values.Head);

    public AutomationWorkflowLinksItemMethod(string value)
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
    public static AutomationWorkflowLinksItemMethod FromCustom(string value)
    {
        return new AutomationWorkflowLinksItemMethod(value);
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

    public static bool operator ==(AutomationWorkflowLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AutomationWorkflowLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AutomationWorkflowLinksItemMethod value) => value.Value;

    public static explicit operator AutomationWorkflowLinksItemMethod(string value) => new(value);

    internal class AutomationWorkflowLinksItemMethodSerializer
        : JsonConverter<AutomationWorkflowLinksItemMethod>
    {
        public override AutomationWorkflowLinksItemMethod Read(
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
            return new AutomationWorkflowLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowLinksItemMethod ReadAsPropertyName(
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
            return new AutomationWorkflowLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowLinksItemMethod value,
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

        public const string Options = "OPTIONS";

        public const string Head = "HEAD";
    }
}
