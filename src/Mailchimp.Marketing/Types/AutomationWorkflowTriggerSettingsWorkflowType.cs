using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AutomationWorkflowTriggerSettingsWorkflowType.AutomationWorkflowTriggerSettingsWorkflowTypeSerializer)
)]
[Serializable]
public readonly record struct AutomationWorkflowTriggerSettingsWorkflowType : IStringEnum
{
    public static readonly AutomationWorkflowTriggerSettingsWorkflowType AbandonedBrowse = new(
        Values.AbandonedBrowse
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType AbandonedCart = new(
        Values.AbandonedCart
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType Api = new(Values.Api);

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType BestCustomers = new(
        Values.BestCustomers
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType CategoryFollowup = new(
        Values.CategoryFollowup
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType DateAdded = new(
        Values.DateAdded
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType EmailFollowup = new(
        Values.EmailFollowup
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType EmailSeries = new(
        Values.EmailSeries
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType GroupAdd = new(
        Values.GroupAdd
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType GroupRemove = new(
        Values.GroupRemove
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType Mandrill = new(
        Values.Mandrill
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType ProductFollowup = new(
        Values.ProductFollowup
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType PurchaseFollowup = new(
        Values.PurchaseFollowup
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType RecurringEvent = new(
        Values.RecurringEvent
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType SpecialEvent = new(
        Values.SpecialEvent
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType VisitUrl = new(
        Values.VisitUrl
    );

    public static readonly AutomationWorkflowTriggerSettingsWorkflowType WelcomeSeries = new(
        Values.WelcomeSeries
    );

    public AutomationWorkflowTriggerSettingsWorkflowType(string value)
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
    public static AutomationWorkflowTriggerSettingsWorkflowType FromCustom(string value)
    {
        return new AutomationWorkflowTriggerSettingsWorkflowType(value);
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
        AutomationWorkflowTriggerSettingsWorkflowType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AutomationWorkflowTriggerSettingsWorkflowType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AutomationWorkflowTriggerSettingsWorkflowType value) =>
        value.Value;

    public static explicit operator AutomationWorkflowTriggerSettingsWorkflowType(string value) =>
        new(value);

    internal class AutomationWorkflowTriggerSettingsWorkflowTypeSerializer
        : JsonConverter<AutomationWorkflowTriggerSettingsWorkflowType>
    {
        public override AutomationWorkflowTriggerSettingsWorkflowType Read(
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
            return new AutomationWorkflowTriggerSettingsWorkflowType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowTriggerSettingsWorkflowType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowTriggerSettingsWorkflowType ReadAsPropertyName(
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
            return new AutomationWorkflowTriggerSettingsWorkflowType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowTriggerSettingsWorkflowType value,
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
