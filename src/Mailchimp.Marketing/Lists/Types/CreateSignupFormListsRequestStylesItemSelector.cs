using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateSignupFormListsRequestStylesItemSelector.CreateSignupFormListsRequestStylesItemSelectorSerializer)
)]
[Serializable]
public readonly record struct CreateSignupFormListsRequestStylesItemSelector : IStringEnum
{
    public static readonly CreateSignupFormListsRequestStylesItemSelector PageBackground = new(
        Values.PageBackground
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector PageHeader = new(
        Values.PageHeader
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector PageOuterWrapper = new(
        Values.PageOuterWrapper
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector BodyBackground = new(
        Values.BodyBackground
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector BodyLinkStyle = new(
        Values.BodyLinkStyle
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector FormsButtons = new(
        Values.FormsButtons
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector FormsButtonsHovered = new(
        Values.FormsButtonsHovered
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector FormsFieldLabel = new(
        Values.FormsFieldLabel
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector FormsFieldText = new(
        Values.FormsFieldText
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector FormsRequired = new(
        Values.FormsRequired
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector FormsRequiredLegend = new(
        Values.FormsRequiredLegend
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector FormsHelpText = new(
        Values.FormsHelpText
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector FormsErrors = new(
        Values.FormsErrors
    );

    public static readonly CreateSignupFormListsRequestStylesItemSelector MonkeyRewardsBadge = new(
        Values.MonkeyRewardsBadge
    );

    public CreateSignupFormListsRequestStylesItemSelector(string value)
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
    public static CreateSignupFormListsRequestStylesItemSelector FromCustom(string value)
    {
        return new CreateSignupFormListsRequestStylesItemSelector(value);
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
        CreateSignupFormListsRequestStylesItemSelector value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateSignupFormListsRequestStylesItemSelector value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateSignupFormListsRequestStylesItemSelector value) =>
        value.Value;

    public static explicit operator CreateSignupFormListsRequestStylesItemSelector(string value) =>
        new(value);

    internal class CreateSignupFormListsRequestStylesItemSelectorSerializer
        : JsonConverter<CreateSignupFormListsRequestStylesItemSelector>
    {
        public override CreateSignupFormListsRequestStylesItemSelector Read(
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
            return new CreateSignupFormListsRequestStylesItemSelector(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateSignupFormListsRequestStylesItemSelector value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateSignupFormListsRequestStylesItemSelector ReadAsPropertyName(
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
            return new CreateSignupFormListsRequestStylesItemSelector(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateSignupFormListsRequestStylesItemSelector value,
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
        public const string PageBackground = "page_background";

        public const string PageHeader = "page_header";

        public const string PageOuterWrapper = "page_outer_wrapper";

        public const string BodyBackground = "body_background";

        public const string BodyLinkStyle = "body_link_style";

        public const string FormsButtons = "forms_buttons";

        public const string FormsButtonsHovered = "forms_buttons_hovered";

        public const string FormsFieldLabel = "forms_field_label";

        public const string FormsFieldText = "forms_field_text";

        public const string FormsRequired = "forms_required";

        public const string FormsRequiredLegend = "forms_required_legend";

        public const string FormsHelpText = "forms_help_text";

        public const string FormsErrors = "forms_errors";

        public const string MonkeyRewardsBadge = "monkey_rewards_badge";
    }
}
