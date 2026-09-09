using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateAccountExportsRequestIncludeStagesItem.CreateAccountExportsRequestIncludeStagesItemSerializer)
)]
[Serializable]
public readonly record struct CreateAccountExportsRequestIncludeStagesItem : IStringEnum
{
    public static readonly CreateAccountExportsRequestIncludeStagesItem Audiences = new(
        Values.Audiences
    );

    public static readonly CreateAccountExportsRequestIncludeStagesItem Campaigns = new(
        Values.Campaigns
    );

    public static readonly CreateAccountExportsRequestIncludeStagesItem Events = new(Values.Events);

    public static readonly CreateAccountExportsRequestIncludeStagesItem GalleryFiles = new(
        Values.GalleryFiles
    );

    public static readonly CreateAccountExportsRequestIncludeStagesItem Reports = new(
        Values.Reports
    );

    public static readonly CreateAccountExportsRequestIncludeStagesItem Templates = new(
        Values.Templates
    );

    public CreateAccountExportsRequestIncludeStagesItem(string value)
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
    public static CreateAccountExportsRequestIncludeStagesItem FromCustom(string value)
    {
        return new CreateAccountExportsRequestIncludeStagesItem(value);
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
        CreateAccountExportsRequestIncludeStagesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateAccountExportsRequestIncludeStagesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateAccountExportsRequestIncludeStagesItem value) =>
        value.Value;

    public static explicit operator CreateAccountExportsRequestIncludeStagesItem(string value) =>
        new(value);

    internal class CreateAccountExportsRequestIncludeStagesItemSerializer
        : JsonConverter<CreateAccountExportsRequestIncludeStagesItem>
    {
        public override CreateAccountExportsRequestIncludeStagesItem Read(
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
            return new CreateAccountExportsRequestIncludeStagesItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateAccountExportsRequestIncludeStagesItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateAccountExportsRequestIncludeStagesItem ReadAsPropertyName(
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
            return new CreateAccountExportsRequestIncludeStagesItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateAccountExportsRequestIncludeStagesItem value,
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
        public const string Audiences = "audiences";

        public const string Campaigns = "campaigns";

        public const string Events = "events";

        public const string GalleryFiles = "gallery_files";

        public const string Reports = "reports";

        public const string Templates = "templates";
    }
}
