using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SignupFormStylesItemSelector.SignupFormStylesItemSelectorSerializer))]
[Serializable]
public readonly record struct SignupFormStylesItemSelector : IStringEnum
{
    public static readonly SignupFormStylesItemSelector PageBackground = new(Values.PageBackground);

    public static readonly SignupFormStylesItemSelector PageHeader = new(Values.PageHeader);

    public static readonly SignupFormStylesItemSelector PageOuterWrapper = new(
        Values.PageOuterWrapper
    );

    public static readonly SignupFormStylesItemSelector BodyBackground = new(Values.BodyBackground);

    public static readonly SignupFormStylesItemSelector BodyLinkStyle = new(Values.BodyLinkStyle);

    public static readonly SignupFormStylesItemSelector FormsButtons = new(Values.FormsButtons);

    public static readonly SignupFormStylesItemSelector FormsButtonsHovered = new(
        Values.FormsButtonsHovered
    );

    public static readonly SignupFormStylesItemSelector FormsFieldLabel = new(
        Values.FormsFieldLabel
    );

    public static readonly SignupFormStylesItemSelector FormsFieldText = new(Values.FormsFieldText);

    public static readonly SignupFormStylesItemSelector FormsRequired = new(Values.FormsRequired);

    public static readonly SignupFormStylesItemSelector FormsRequiredLegend = new(
        Values.FormsRequiredLegend
    );

    public static readonly SignupFormStylesItemSelector FormsHelpText = new(Values.FormsHelpText);

    public static readonly SignupFormStylesItemSelector FormsErrors = new(Values.FormsErrors);

    public static readonly SignupFormStylesItemSelector MonkeyRewardsBadge = new(
        Values.MonkeyRewardsBadge
    );

    public SignupFormStylesItemSelector(string value)
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
    public static SignupFormStylesItemSelector FromCustom(string value)
    {
        return new SignupFormStylesItemSelector(value);
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

    public static bool operator ==(SignupFormStylesItemSelector value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SignupFormStylesItemSelector value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SignupFormStylesItemSelector value) => value.Value;

    public static explicit operator SignupFormStylesItemSelector(string value) => new(value);

    internal class SignupFormStylesItemSelectorSerializer
        : JsonConverter<SignupFormStylesItemSelector>
    {
        public override SignupFormStylesItemSelector Read(
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
            return new SignupFormStylesItemSelector(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SignupFormStylesItemSelector value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SignupFormStylesItemSelector ReadAsPropertyName(
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
            return new SignupFormStylesItemSelector(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SignupFormStylesItemSelector value,
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
