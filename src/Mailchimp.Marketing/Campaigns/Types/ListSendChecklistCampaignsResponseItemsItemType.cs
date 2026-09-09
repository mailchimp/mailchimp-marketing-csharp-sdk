using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSendChecklistCampaignsResponseItemsItemType.ListSendChecklistCampaignsResponseItemsItemTypeSerializer)
)]
[Serializable]
public readonly record struct ListSendChecklistCampaignsResponseItemsItemType : IStringEnum
{
    public static readonly ListSendChecklistCampaignsResponseItemsItemType Success = new(
        Values.Success
    );

    public static readonly ListSendChecklistCampaignsResponseItemsItemType Warning = new(
        Values.Warning
    );

    public static readonly ListSendChecklistCampaignsResponseItemsItemType Error = new(
        Values.Error
    );

    public ListSendChecklistCampaignsResponseItemsItemType(string value)
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
    public static ListSendChecklistCampaignsResponseItemsItemType FromCustom(string value)
    {
        return new ListSendChecklistCampaignsResponseItemsItemType(value);
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
        ListSendChecklistCampaignsResponseItemsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSendChecklistCampaignsResponseItemsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListSendChecklistCampaignsResponseItemsItemType value) =>
        value.Value;

    public static explicit operator ListSendChecklistCampaignsResponseItemsItemType(string value) =>
        new(value);

    internal class ListSendChecklistCampaignsResponseItemsItemTypeSerializer
        : JsonConverter<ListSendChecklistCampaignsResponseItemsItemType>
    {
        public override ListSendChecklistCampaignsResponseItemsItemType Read(
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
            return new ListSendChecklistCampaignsResponseItemsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSendChecklistCampaignsResponseItemsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSendChecklistCampaignsResponseItemsItemType ReadAsPropertyName(
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
            return new ListSendChecklistCampaignsResponseItemsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSendChecklistCampaignsResponseItemsItemType value,
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
        public const string Success = "success";

        public const string Warning = "warning";

        public const string Error = "error";
    }
}
