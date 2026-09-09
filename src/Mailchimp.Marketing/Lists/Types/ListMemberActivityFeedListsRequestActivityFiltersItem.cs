using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListMemberActivityFeedListsRequestActivityFiltersItem.ListMemberActivityFeedListsRequestActivityFiltersItemSerializer)
)]
[Serializable]
public readonly record struct ListMemberActivityFeedListsRequestActivityFiltersItem : IStringEnum
{
    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Bounce = new(
        Values.Bounce
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Click = new(
        Values.Click
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Conversation = new(
        Values.Conversation
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem EcommerceSignup =
        new(Values.EcommerceSignup);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Event = new(
        Values.Event
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem WebEngagement =
        new(Values.WebEngagement);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem GenericSignup =
        new(Values.GenericSignup);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem LandingPageSignup =
        new(Values.LandingPageSignup);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem MarketingPermission =
        new(Values.MarketingPermission);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Note = new(
        Values.Note
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Open = new(
        Values.Open
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Order = new(
        Values.Order
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem PostcardSent = new(
        Values.PostcardSent
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Sent = new(
        Values.Sent
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Signup = new(
        Values.Signup
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem SquatterSignup =
        new(Values.SquatterSignup);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem Unsub = new(
        Values.Unsub
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem WebsiteSignup =
        new(Values.WebsiteSignup);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem SurveyResponse =
        new(Values.SurveyResponse);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem SmsBulkSent = new(
        Values.SmsBulkSent
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem InboxThread = new(
        Values.InboxThread
    );

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem QboPaymentLink =
        new(Values.QboPaymentLink);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem VideoCallTranscripts =
        new(Values.VideoCallTranscripts);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem WhatsappBulkSent =
        new(Values.WhatsappBulkSent);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem WhatsappDelivered =
        new(Values.WhatsappDelivered);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem WhatsappLinkClick =
        new(Values.WhatsappLinkClick);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem WhatsappSubscribe =
        new(Values.WhatsappSubscribe);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem WhatsappSubscriptionPhoneUpdated =
        new(Values.WhatsappSubscriptionPhoneUpdated);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem WhatsappUnsubscribe =
        new(Values.WhatsappUnsubscribe);

    public static readonly ListMemberActivityFeedListsRequestActivityFiltersItem WhatsappUsedKeyword =
        new(Values.WhatsappUsedKeyword);

    public ListMemberActivityFeedListsRequestActivityFiltersItem(string value)
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
    public static ListMemberActivityFeedListsRequestActivityFiltersItem FromCustom(string value)
    {
        return new ListMemberActivityFeedListsRequestActivityFiltersItem(value);
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
        ListMemberActivityFeedListsRequestActivityFiltersItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListMemberActivityFeedListsRequestActivityFiltersItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListMemberActivityFeedListsRequestActivityFiltersItem value
    ) => value.Value;

    public static explicit operator ListMemberActivityFeedListsRequestActivityFiltersItem(
        string value
    ) => new(value);

    internal class ListMemberActivityFeedListsRequestActivityFiltersItemSerializer
        : JsonConverter<ListMemberActivityFeedListsRequestActivityFiltersItem>
    {
        public override ListMemberActivityFeedListsRequestActivityFiltersItem Read(
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
            return new ListMemberActivityFeedListsRequestActivityFiltersItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMemberActivityFeedListsRequestActivityFiltersItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMemberActivityFeedListsRequestActivityFiltersItem ReadAsPropertyName(
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
            return new ListMemberActivityFeedListsRequestActivityFiltersItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMemberActivityFeedListsRequestActivityFiltersItem value,
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
        public const string Bounce = "bounce";

        public const string Click = "click";

        public const string Conversation = "conversation";

        public const string EcommerceSignup = "ecommerce_signup";

        public const string Event = "event";

        public const string WebEngagement = "web_engagement";

        public const string GenericSignup = "generic_signup";

        public const string LandingPageSignup = "landing_page_signup";

        public const string MarketingPermission = "marketing_permission";

        public const string Note = "note";

        public const string Open = "open";

        public const string Order = "order";

        public const string PostcardSent = "postcard_sent";

        public const string Sent = "sent";

        public const string Signup = "signup";

        public const string SquatterSignup = "squatter_signup";

        public const string Unsub = "unsub";

        public const string WebsiteSignup = "website_signup";

        public const string SurveyResponse = "survey_response";

        public const string SmsBulkSent = "sms_bulk_sent";

        public const string InboxThread = "inbox_thread";

        public const string QboPaymentLink = "qbo_payment_link";

        public const string VideoCallTranscripts = "video_call_transcripts";

        public const string WhatsappBulkSent = "whatsapp_bulk_sent";

        public const string WhatsappDelivered = "whatsapp_delivered";

        public const string WhatsappLinkClick = "whatsapp_link_click";

        public const string WhatsappSubscribe = "whatsapp_subscribe";

        public const string WhatsappSubscriptionPhoneUpdated =
            "whatsapp_subscription_phone_updated";

        public const string WhatsappUnsubscribe = "whatsapp_unsubscribe";

        public const string WhatsappUsedKeyword = "whatsapp_used_keyword";
    }
}
