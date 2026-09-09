using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AutomationWorkflowEmailTriggerSettingsWorkflowType.AutomationWorkflowEmailTriggerSettingsWorkflowTypeSerializer)
)]
[Serializable]
public readonly record struct AutomationWorkflowEmailTriggerSettingsWorkflowType : IStringEnum
{
    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType AbandonedBrowse = new(
        Values.AbandonedBrowse
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType AbandonedCart = new(
        Values.AbandonedCart
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType Api = new(Values.Api);

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType BestCustomers = new(
        Values.BestCustomers
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType CategoryFollowup =
        new(Values.CategoryFollowup);

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType DateAdded = new(
        Values.DateAdded
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType EmailFollowup = new(
        Values.EmailFollowup
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType EmailSeries = new(
        Values.EmailSeries
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType GroupAdd = new(
        Values.GroupAdd
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType GroupRemove = new(
        Values.GroupRemove
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType Mandrill = new(
        Values.Mandrill
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType ProductFollowup = new(
        Values.ProductFollowup
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType PurchaseFollowup =
        new(Values.PurchaseFollowup);

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType RecurringEvent = new(
        Values.RecurringEvent
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType SpecialEvent = new(
        Values.SpecialEvent
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType VisitUrl = new(
        Values.VisitUrl
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsWorkflowType WelcomeSeries = new(
        Values.WelcomeSeries
    );

    public AutomationWorkflowEmailTriggerSettingsWorkflowType(string value)
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
    public static AutomationWorkflowEmailTriggerSettingsWorkflowType FromCustom(string value)
    {
        return new AutomationWorkflowEmailTriggerSettingsWorkflowType(value);
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
        AutomationWorkflowEmailTriggerSettingsWorkflowType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AutomationWorkflowEmailTriggerSettingsWorkflowType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AutomationWorkflowEmailTriggerSettingsWorkflowType value
    ) => value.Value;

    public static explicit operator AutomationWorkflowEmailTriggerSettingsWorkflowType(
        string value
    ) => new(value);

    internal class AutomationWorkflowEmailTriggerSettingsWorkflowTypeSerializer
        : JsonConverter<AutomationWorkflowEmailTriggerSettingsWorkflowType>
    {
        public override AutomationWorkflowEmailTriggerSettingsWorkflowType Read(
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
            return new AutomationWorkflowEmailTriggerSettingsWorkflowType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailTriggerSettingsWorkflowType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowEmailTriggerSettingsWorkflowType ReadAsPropertyName(
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
            return new AutomationWorkflowEmailTriggerSettingsWorkflowType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailTriggerSettingsWorkflowType value,
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
        public const string AbandonedBrowse = "abandonedBrowse";

        public const string AbandonedCart = "abandonedCart";

        public const string Api = "api";

        public const string BestCustomers = "bestCustomers";

        public const string CategoryFollowup = "categoryFollowup";

        public const string DateAdded = "dateAdded";

        public const string EmailFollowup = "emailFollowup";

        public const string EmailSeries = "emailSeries";

        public const string GroupAdd = "groupAdd";

        public const string GroupRemove = "groupRemove";

        public const string Mandrill = "mandrill";

        public const string ProductFollowup = "productFollowup";

        public const string PurchaseFollowup = "purchaseFollowup";

        public const string RecurringEvent = "recurringEvent";

        public const string SpecialEvent = "specialEvent";

        public const string VisitUrl = "visitUrl";

        public const string WelcomeSeries = "welcomeSeries";
    }
}
