using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(PatchAudienceContactRequestTagsItemNameStatus.PatchAudienceContactRequestTagsItemNameStatusSerializer)
)]
[Serializable]
public readonly record struct PatchAudienceContactRequestTagsItemNameStatus : IStringEnum
{
    public static readonly PatchAudienceContactRequestTagsItemNameStatus Active = new(
        Values.Active
    );

    public static readonly PatchAudienceContactRequestTagsItemNameStatus Inactive = new(
        Values.Inactive
    );

    public PatchAudienceContactRequestTagsItemNameStatus(string value)
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
    public static PatchAudienceContactRequestTagsItemNameStatus FromCustom(string value)
    {
        return new PatchAudienceContactRequestTagsItemNameStatus(value);
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
        PatchAudienceContactRequestTagsItemNameStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PatchAudienceContactRequestTagsItemNameStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PatchAudienceContactRequestTagsItemNameStatus value) =>
        value.Value;

    public static explicit operator PatchAudienceContactRequestTagsItemNameStatus(string value) =>
        new(value);

    internal class PatchAudienceContactRequestTagsItemNameStatusSerializer
        : JsonConverter<PatchAudienceContactRequestTagsItemNameStatus>
    {
        public override PatchAudienceContactRequestTagsItemNameStatus Read(
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
            return new PatchAudienceContactRequestTagsItemNameStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestTagsItemNameStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PatchAudienceContactRequestTagsItemNameStatus ReadAsPropertyName(
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
            return new PatchAudienceContactRequestTagsItemNameStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestTagsItemNameStatus value,
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
        public const string Active = "active";

        public const string Inactive = "inactive";
    }
}
