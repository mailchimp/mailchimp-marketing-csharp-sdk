using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AutomationWorkflowEmailDelayAction.AutomationWorkflowEmailDelayActionSerializer)
)]
[Serializable]
public readonly record struct AutomationWorkflowEmailDelayAction : IStringEnum
{
    public static readonly AutomationWorkflowEmailDelayAction PreviousCampaignSent = new(
        Values.PreviousCampaignSent
    );

    public static readonly AutomationWorkflowEmailDelayAction PreviousCampaignOpened = new(
        Values.PreviousCampaignOpened
    );

    public static readonly AutomationWorkflowEmailDelayAction PreviousCampaignNotOpened = new(
        Values.PreviousCampaignNotOpened
    );

    public static readonly AutomationWorkflowEmailDelayAction PreviousCampaignClickedAny = new(
        Values.PreviousCampaignClickedAny
    );

    public static readonly AutomationWorkflowEmailDelayAction PreviousCampaignNotClickedAny = new(
        Values.PreviousCampaignNotClickedAny
    );

    public static readonly AutomationWorkflowEmailDelayAction PreviousCampaignSpecificClicked = new(
        Values.PreviousCampaignSpecificClicked
    );

    public static readonly AutomationWorkflowEmailDelayAction EcommBoughtAny = new(
        Values.EcommBoughtAny
    );

    public static readonly AutomationWorkflowEmailDelayAction EcommBoughtProduct = new(
        Values.EcommBoughtProduct
    );

    public static readonly AutomationWorkflowEmailDelayAction EcommBoughtCategory = new(
        Values.EcommBoughtCategory
    );

    public static readonly AutomationWorkflowEmailDelayAction EcommNotBoughtAny = new(
        Values.EcommNotBoughtAny
    );

    public static readonly AutomationWorkflowEmailDelayAction EcommAbandonedCart = new(
        Values.EcommAbandonedCart
    );

    public static readonly AutomationWorkflowEmailDelayAction CampaignSent = new(
        Values.CampaignSent
    );

    public static readonly AutomationWorkflowEmailDelayAction OpenedEmail = new(Values.OpenedEmail);

    public static readonly AutomationWorkflowEmailDelayAction NotOpenedEmail = new(
        Values.NotOpenedEmail
    );

    public static readonly AutomationWorkflowEmailDelayAction ClickedEmail = new(
        Values.ClickedEmail
    );

    public static readonly AutomationWorkflowEmailDelayAction NotClickedEmail = new(
        Values.NotClickedEmail
    );

    public static readonly AutomationWorkflowEmailDelayAction CampaignSpecificClicked = new(
        Values.CampaignSpecificClicked
    );

    public static readonly AutomationWorkflowEmailDelayAction Manual = new(Values.Manual);

    public static readonly AutomationWorkflowEmailDelayAction Signup = new(Values.Signup);

    public static readonly AutomationWorkflowEmailDelayAction MergeChanged = new(
        Values.MergeChanged
    );

    public static readonly AutomationWorkflowEmailDelayAction GroupAdd = new(Values.GroupAdd);

    public static readonly AutomationWorkflowEmailDelayAction GroupRemove = new(Values.GroupRemove);

    public static readonly AutomationWorkflowEmailDelayAction MandrillSent = new(
        Values.MandrillSent
    );

    public static readonly AutomationWorkflowEmailDelayAction MandrillOpened = new(
        Values.MandrillOpened
    );

    public static readonly AutomationWorkflowEmailDelayAction MandrillClicked = new(
        Values.MandrillClicked
    );

    public static readonly AutomationWorkflowEmailDelayAction MandrillAny = new(Values.MandrillAny);

    public static readonly AutomationWorkflowEmailDelayAction Api = new(Values.Api);

    public static readonly AutomationWorkflowEmailDelayAction Goal = new(Values.Goal);

    public static readonly AutomationWorkflowEmailDelayAction Annual = new(Values.Annual);

    public static readonly AutomationWorkflowEmailDelayAction Birthday = new(Values.Birthday);

    public static readonly AutomationWorkflowEmailDelayAction Date = new(Values.Date);

    public static readonly AutomationWorkflowEmailDelayAction DateAdded = new(Values.DateAdded);

    public static readonly AutomationWorkflowEmailDelayAction TagAdd = new(Values.TagAdd);

    public AutomationWorkflowEmailDelayAction(string value)
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
    public static AutomationWorkflowEmailDelayAction FromCustom(string value)
    {
        return new AutomationWorkflowEmailDelayAction(value);
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

    public static bool operator ==(AutomationWorkflowEmailDelayAction value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AutomationWorkflowEmailDelayAction value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AutomationWorkflowEmailDelayAction value) => value.Value;

    public static explicit operator AutomationWorkflowEmailDelayAction(string value) => new(value);

    internal class AutomationWorkflowEmailDelayActionSerializer
        : JsonConverter<AutomationWorkflowEmailDelayAction>
    {
        public override AutomationWorkflowEmailDelayAction Read(
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
            return new AutomationWorkflowEmailDelayAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailDelayAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowEmailDelayAction ReadAsPropertyName(
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
            return new AutomationWorkflowEmailDelayAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailDelayAction value,
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
        public const string PreviousCampaignSent = "previous_campaign_sent";

        public const string PreviousCampaignOpened = "previous_campaign_opened";

        public const string PreviousCampaignNotOpened = "previous_campaign_not_opened";

        public const string PreviousCampaignClickedAny = "previous_campaign_clicked_any";

        public const string PreviousCampaignNotClickedAny = "previous_campaign_not_clicked_any";

        public const string PreviousCampaignSpecificClicked = "previous_campaign_specific_clicked";

        public const string EcommBoughtAny = "ecomm_bought_any";

        public const string EcommBoughtProduct = "ecomm_bought_product";

        public const string EcommBoughtCategory = "ecomm_bought_category";

        public const string EcommNotBoughtAny = "ecomm_not_bought_any";

        public const string EcommAbandonedCart = "ecomm_abandoned_cart";

        public const string CampaignSent = "campaign_sent";

        public const string OpenedEmail = "opened_email";

        public const string NotOpenedEmail = "not_opened_email";

        public const string ClickedEmail = "clicked_email";

        public const string NotClickedEmail = "not_clicked_email";

        public const string CampaignSpecificClicked = "campaign_specific_clicked";

        public const string Manual = "manual";

        public const string Signup = "signup";

        public const string MergeChanged = "merge_changed";

        public const string GroupAdd = "group_add";

        public const string GroupRemove = "group_remove";

        public const string MandrillSent = "mandrill_sent";

        public const string MandrillOpened = "mandrill_opened";

        public const string MandrillClicked = "mandrill_clicked";

        public const string MandrillAny = "mandrill_any";

        public const string Api = "api";

        public const string Goal = "goal";

        public const string Annual = "annual";

        public const string Birthday = "birthday";

        public const string Date = "date";

        public const string DateAdded = "date_added";

        public const string TagAdd = "tag_add";
    }
}
