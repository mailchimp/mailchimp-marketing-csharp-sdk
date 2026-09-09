// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItem.JsonConverter))]
[Serializable]
public record SegmentTypeItem
{
    internal SegmentTypeItem(string type, object? value)
    {
        ConditionType = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.Aim"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.Aim value)
    {
        ConditionType = "Aim";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.Automation"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.Automation value)
    {
        ConditionType = "Automation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.CampaignPoll"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.CampaignPoll value)
    {
        ConditionType = "CampaignPoll";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.Conversation"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.Conversation value)
    {
        ConditionType = "Conversation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.Date"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.Date value)
    {
        ConditionType = "Date";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.EmailClient"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.EmailClient value)
    {
        ConditionType = "EmailClient";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.Language"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.Language value)
    {
        ConditionType = "Language";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.MemberRating"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.MemberRating value)
    {
        ConditionType = "MemberRating";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.SignupSource"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.SignupSource value)
    {
        ConditionType = "SignupSource";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.SurveyMonkey"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.SurveyMonkey value)
    {
        ConditionType = "SurveyMonkey";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.Vip"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.Vip value)
    {
        ConditionType = "VIP";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.Interests"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.Interests value)
    {
        ConditionType = "Interests";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.EcommCategory"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.EcommCategory value)
    {
        ConditionType = "EcommCategory";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.EcommNumber"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.EcommNumber value)
    {
        ConditionType = "EcommNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.EcommPurchased"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.EcommPurchased value)
    {
        ConditionType = "EcommPurchased";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.EcommSpent"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.EcommSpent value)
    {
        ConditionType = "EcommSpent";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.EcommStore"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.EcommStore value)
    {
        ConditionType = "EcommStore";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.GoalActivity"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.GoalActivity value)
    {
        ConditionType = "GoalActivity";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.GoalTimestamp"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.GoalTimestamp value)
    {
        ConditionType = "GoalTimestamp";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.FuzzySegment"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.FuzzySegment value)
    {
        ConditionType = "FuzzySegment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.StaticSegment"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.StaticSegment value)
    {
        ConditionType = "StaticSegment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.IpGeoCountryState"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.IpGeoCountryState value)
    {
        ConditionType = "IPGeoCountryState";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.IpGeoIn"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.IpGeoIn value)
    {
        ConditionType = "IPGeoIn";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.IpGeoInZip"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.IpGeoInZip value)
    {
        ConditionType = "IPGeoInZip";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.IpGeoUnknown"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.IpGeoUnknown value)
    {
        ConditionType = "IPGeoUnknown";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.IpGeoZip"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.IpGeoZip value)
    {
        ConditionType = "IPGeoZip";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.SocialAge"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.SocialAge value)
    {
        ConditionType = "SocialAge";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.SocialGender"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.SocialGender value)
    {
        ConditionType = "SocialGender";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.SocialInfluence"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.SocialInfluence value)
    {
        ConditionType = "SocialInfluence";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.SocialNetworkMember"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.SocialNetworkMember value)
    {
        ConditionType = "SocialNetworkMember";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.SocialNetworkFollow"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.SocialNetworkFollow value)
    {
        ConditionType = "SocialNetworkFollow";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.AddressMerge"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.AddressMerge value)
    {
        ConditionType = "AddressMerge";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.ZipMerge"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.ZipMerge value)
    {
        ConditionType = "ZipMerge";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.BirthdayMerge"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.BirthdayMerge value)
    {
        ConditionType = "BirthdayMerge";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.DateMerge"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.DateMerge value)
    {
        ConditionType = "DateMerge";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.SelectMerge"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.SelectMerge value)
    {
        ConditionType = "SelectMerge";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.TextMerge"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.TextMerge value)
    {
        ConditionType = "TextMerge";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.EmailAddress"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.EmailAddress value)
    {
        ConditionType = "EmailAddress";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.PredictedGender"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.PredictedGender value)
    {
        ConditionType = "PredictedGender";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.PredictedAge"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.PredictedAge value)
    {
        ConditionType = "PredictedAge";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SegmentTypeItem with <see cref="SegmentTypeItem.NewSubscribers"/>.
    /// </summary>
    public SegmentTypeItem(SegmentTypeItem.NewSubscribers value)
    {
        ConditionType = "NewSubscribers";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("condition_type")]
    public string ConditionType { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "Aim"
    /// </summary>
    public bool IsAim => ConditionType == "Aim";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "Automation"
    /// </summary>
    public bool IsAutomation => ConditionType == "Automation";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "CampaignPoll"
    /// </summary>
    public bool IsCampaignPoll => ConditionType == "CampaignPoll";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "Conversation"
    /// </summary>
    public bool IsConversation => ConditionType == "Conversation";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "Date"
    /// </summary>
    public bool IsDate => ConditionType == "Date";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "EmailClient"
    /// </summary>
    public bool IsEmailClient => ConditionType == "EmailClient";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "Language"
    /// </summary>
    public bool IsLanguage => ConditionType == "Language";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "MemberRating"
    /// </summary>
    public bool IsMemberRating => ConditionType == "MemberRating";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "SignupSource"
    /// </summary>
    public bool IsSignupSource => ConditionType == "SignupSource";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "SurveyMonkey"
    /// </summary>
    public bool IsSurveyMonkey => ConditionType == "SurveyMonkey";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "VIP"
    /// </summary>
    public bool IsVip => ConditionType == "VIP";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "Interests"
    /// </summary>
    public bool IsInterests => ConditionType == "Interests";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "EcommCategory"
    /// </summary>
    public bool IsEcommCategory => ConditionType == "EcommCategory";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "EcommNumber"
    /// </summary>
    public bool IsEcommNumber => ConditionType == "EcommNumber";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "EcommPurchased"
    /// </summary>
    public bool IsEcommPurchased => ConditionType == "EcommPurchased";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "EcommSpent"
    /// </summary>
    public bool IsEcommSpent => ConditionType == "EcommSpent";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "EcommStore"
    /// </summary>
    public bool IsEcommStore => ConditionType == "EcommStore";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "GoalActivity"
    /// </summary>
    public bool IsGoalActivity => ConditionType == "GoalActivity";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "GoalTimestamp"
    /// </summary>
    public bool IsGoalTimestamp => ConditionType == "GoalTimestamp";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "FuzzySegment"
    /// </summary>
    public bool IsFuzzySegment => ConditionType == "FuzzySegment";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "StaticSegment"
    /// </summary>
    public bool IsStaticSegment => ConditionType == "StaticSegment";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "IPGeoCountryState"
    /// </summary>
    public bool IsIpGeoCountryState => ConditionType == "IPGeoCountryState";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "IPGeoIn"
    /// </summary>
    public bool IsIpGeoIn => ConditionType == "IPGeoIn";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "IPGeoInZip"
    /// </summary>
    public bool IsIpGeoInZip => ConditionType == "IPGeoInZip";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "IPGeoUnknown"
    /// </summary>
    public bool IsIpGeoUnknown => ConditionType == "IPGeoUnknown";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "IPGeoZip"
    /// </summary>
    public bool IsIpGeoZip => ConditionType == "IPGeoZip";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "SocialAge"
    /// </summary>
    public bool IsSocialAge => ConditionType == "SocialAge";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "SocialGender"
    /// </summary>
    public bool IsSocialGender => ConditionType == "SocialGender";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "SocialInfluence"
    /// </summary>
    public bool IsSocialInfluence => ConditionType == "SocialInfluence";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "SocialNetworkMember"
    /// </summary>
    public bool IsSocialNetworkMember => ConditionType == "SocialNetworkMember";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "SocialNetworkFollow"
    /// </summary>
    public bool IsSocialNetworkFollow => ConditionType == "SocialNetworkFollow";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "AddressMerge"
    /// </summary>
    public bool IsAddressMerge => ConditionType == "AddressMerge";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "ZipMerge"
    /// </summary>
    public bool IsZipMerge => ConditionType == "ZipMerge";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "BirthdayMerge"
    /// </summary>
    public bool IsBirthdayMerge => ConditionType == "BirthdayMerge";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "DateMerge"
    /// </summary>
    public bool IsDateMerge => ConditionType == "DateMerge";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "SelectMerge"
    /// </summary>
    public bool IsSelectMerge => ConditionType == "SelectMerge";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "TextMerge"
    /// </summary>
    public bool IsTextMerge => ConditionType == "TextMerge";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "EmailAddress"
    /// </summary>
    public bool IsEmailAddress => ConditionType == "EmailAddress";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "PredictedGender"
    /// </summary>
    public bool IsPredictedGender => ConditionType == "PredictedGender";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "PredictedAge"
    /// </summary>
    public bool IsPredictedAge => ConditionType == "PredictedAge";

    /// <summary>
    /// Returns true if <see cref="ConditionType"/> is "NewSubscribers"
    /// </summary>
    public bool IsNewSubscribers => ConditionType == "NewSubscribers";

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemAim"/> if <see cref="ConditionType"/> is 'Aim', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'Aim'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemAim AsAim() =>
        IsAim
            ? (Mailchimp.Marketing.SegmentTypeItemAim)Value!
            : throw new global::System.Exception("SegmentTypeItem.ConditionType is not 'Aim'");

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemAutomation"/> if <see cref="ConditionType"/> is 'Automation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'Automation'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemAutomation AsAutomation() =>
        IsAutomation
            ? (Mailchimp.Marketing.SegmentTypeItemAutomation)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'Automation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemCampaignPoll"/> if <see cref="ConditionType"/> is 'CampaignPoll', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'CampaignPoll'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemCampaignPoll AsCampaignPoll() =>
        IsCampaignPoll
            ? (Mailchimp.Marketing.SegmentTypeItemCampaignPoll)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'CampaignPoll'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemConversation"/> if <see cref="ConditionType"/> is 'Conversation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'Conversation'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemConversation AsConversation() =>
        IsConversation
            ? (Mailchimp.Marketing.SegmentTypeItemConversation)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'Conversation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemDate"/> if <see cref="ConditionType"/> is 'Date', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'Date'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemDate AsDate() =>
        IsDate
            ? (Mailchimp.Marketing.SegmentTypeItemDate)Value!
            : throw new global::System.Exception("SegmentTypeItem.ConditionType is not 'Date'");

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemEmailClient"/> if <see cref="ConditionType"/> is 'EmailClient', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'EmailClient'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemEmailClient AsEmailClient() =>
        IsEmailClient
            ? (Mailchimp.Marketing.SegmentTypeItemEmailClient)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'EmailClient'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemLanguage"/> if <see cref="ConditionType"/> is 'Language', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'Language'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemLanguage AsLanguage() =>
        IsLanguage
            ? (Mailchimp.Marketing.SegmentTypeItemLanguage)Value!
            : throw new global::System.Exception("SegmentTypeItem.ConditionType is not 'Language'");

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemMemberRating"/> if <see cref="ConditionType"/> is 'MemberRating', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'MemberRating'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemMemberRating AsMemberRating() =>
        IsMemberRating
            ? (Mailchimp.Marketing.SegmentTypeItemMemberRating)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'MemberRating'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemSignupSource"/> if <see cref="ConditionType"/> is 'SignupSource', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'SignupSource'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemSignupSource AsSignupSource() =>
        IsSignupSource
            ? (Mailchimp.Marketing.SegmentTypeItemSignupSource)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'SignupSource'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemSurveyMonkey"/> if <see cref="ConditionType"/> is 'SurveyMonkey', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'SurveyMonkey'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemSurveyMonkey AsSurveyMonkey() =>
        IsSurveyMonkey
            ? (Mailchimp.Marketing.SegmentTypeItemSurveyMonkey)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'SurveyMonkey'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemVip"/> if <see cref="ConditionType"/> is 'VIP', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'VIP'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemVip AsVip() =>
        IsVip
            ? (Mailchimp.Marketing.SegmentTypeItemVip)Value!
            : throw new global::System.Exception("SegmentTypeItem.ConditionType is not 'VIP'");

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemInterests"/> if <see cref="ConditionType"/> is 'Interests', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'Interests'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemInterests AsInterests() =>
        IsInterests
            ? (Mailchimp.Marketing.SegmentTypeItemInterests)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'Interests'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommCategory"/> if <see cref="ConditionType"/> is 'EcommCategory', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'EcommCategory'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemEcommCategory AsEcommCategory() =>
        IsEcommCategory
            ? (Mailchimp.Marketing.SegmentTypeItemEcommCategory)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'EcommCategory'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommNumber"/> if <see cref="ConditionType"/> is 'EcommNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'EcommNumber'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemEcommNumber AsEcommNumber() =>
        IsEcommNumber
            ? (Mailchimp.Marketing.SegmentTypeItemEcommNumber)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'EcommNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommPurchased"/> if <see cref="ConditionType"/> is 'EcommPurchased', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'EcommPurchased'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemEcommPurchased AsEcommPurchased() =>
        IsEcommPurchased
            ? (Mailchimp.Marketing.SegmentTypeItemEcommPurchased)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'EcommPurchased'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommSpent"/> if <see cref="ConditionType"/> is 'EcommSpent', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'EcommSpent'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemEcommSpent AsEcommSpent() =>
        IsEcommSpent
            ? (Mailchimp.Marketing.SegmentTypeItemEcommSpent)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'EcommSpent'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommStore"/> if <see cref="ConditionType"/> is 'EcommStore', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'EcommStore'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemEcommStore AsEcommStore() =>
        IsEcommStore
            ? (Mailchimp.Marketing.SegmentTypeItemEcommStore)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'EcommStore'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemGoalActivity"/> if <see cref="ConditionType"/> is 'GoalActivity', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'GoalActivity'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemGoalActivity AsGoalActivity() =>
        IsGoalActivity
            ? (Mailchimp.Marketing.SegmentTypeItemGoalActivity)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'GoalActivity'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemGoalTimestamp"/> if <see cref="ConditionType"/> is 'GoalTimestamp', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'GoalTimestamp'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemGoalTimestamp AsGoalTimestamp() =>
        IsGoalTimestamp
            ? (Mailchimp.Marketing.SegmentTypeItemGoalTimestamp)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'GoalTimestamp'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemFuzzySegment"/> if <see cref="ConditionType"/> is 'FuzzySegment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'FuzzySegment'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemFuzzySegment AsFuzzySegment() =>
        IsFuzzySegment
            ? (Mailchimp.Marketing.SegmentTypeItemFuzzySegment)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'FuzzySegment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemStaticSegment"/> if <see cref="ConditionType"/> is 'StaticSegment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'StaticSegment'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemStaticSegment AsStaticSegment() =>
        IsStaticSegment
            ? (Mailchimp.Marketing.SegmentTypeItemStaticSegment)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'StaticSegment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState"/> if <see cref="ConditionType"/> is 'IPGeoCountryState', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'IPGeoCountryState'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState AsIpGeoCountryState() =>
        IsIpGeoCountryState
            ? (Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'IPGeoCountryState'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoIn"/> if <see cref="ConditionType"/> is 'IPGeoIn', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'IPGeoIn'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemIpGeoIn AsIpGeoIn() =>
        IsIpGeoIn
            ? (Mailchimp.Marketing.SegmentTypeItemIpGeoIn)Value!
            : throw new global::System.Exception("SegmentTypeItem.ConditionType is not 'IPGeoIn'");

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoInZip"/> if <see cref="ConditionType"/> is 'IPGeoInZip', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'IPGeoInZip'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemIpGeoInZip AsIpGeoInZip() =>
        IsIpGeoInZip
            ? (Mailchimp.Marketing.SegmentTypeItemIpGeoInZip)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'IPGeoInZip'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown"/> if <see cref="ConditionType"/> is 'IPGeoUnknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'IPGeoUnknown'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown AsIpGeoUnknown() =>
        IsIpGeoUnknown
            ? (Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'IPGeoUnknown'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoZip"/> if <see cref="ConditionType"/> is 'IPGeoZip', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'IPGeoZip'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemIpGeoZip AsIpGeoZip() =>
        IsIpGeoZip
            ? (Mailchimp.Marketing.SegmentTypeItemIpGeoZip)Value!
            : throw new global::System.Exception("SegmentTypeItem.ConditionType is not 'IPGeoZip'");

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialAge"/> if <see cref="ConditionType"/> is 'SocialAge', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'SocialAge'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemSocialAge AsSocialAge() =>
        IsSocialAge
            ? (Mailchimp.Marketing.SegmentTypeItemSocialAge)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'SocialAge'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialGender"/> if <see cref="ConditionType"/> is 'SocialGender', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'SocialGender'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemSocialGender AsSocialGender() =>
        IsSocialGender
            ? (Mailchimp.Marketing.SegmentTypeItemSocialGender)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'SocialGender'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialInfluence"/> if <see cref="ConditionType"/> is 'SocialInfluence', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'SocialInfluence'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemSocialInfluence AsSocialInfluence() =>
        IsSocialInfluence
            ? (Mailchimp.Marketing.SegmentTypeItemSocialInfluence)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'SocialInfluence'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember"/> if <see cref="ConditionType"/> is 'SocialNetworkMember', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'SocialNetworkMember'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember AsSocialNetworkMember() =>
        IsSocialNetworkMember
            ? (Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'SocialNetworkMember'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow"/> if <see cref="ConditionType"/> is 'SocialNetworkFollow', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'SocialNetworkFollow'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow AsSocialNetworkFollow() =>
        IsSocialNetworkFollow
            ? (Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'SocialNetworkFollow'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemAddressMerge"/> if <see cref="ConditionType"/> is 'AddressMerge', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'AddressMerge'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemAddressMerge AsAddressMerge() =>
        IsAddressMerge
            ? (Mailchimp.Marketing.SegmentTypeItemAddressMerge)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'AddressMerge'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemZipMerge"/> if <see cref="ConditionType"/> is 'ZipMerge', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'ZipMerge'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemZipMerge AsZipMerge() =>
        IsZipMerge
            ? (Mailchimp.Marketing.SegmentTypeItemZipMerge)Value!
            : throw new global::System.Exception("SegmentTypeItem.ConditionType is not 'ZipMerge'");

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemBirthdayMerge"/> if <see cref="ConditionType"/> is 'BirthdayMerge', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'BirthdayMerge'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemBirthdayMerge AsBirthdayMerge() =>
        IsBirthdayMerge
            ? (Mailchimp.Marketing.SegmentTypeItemBirthdayMerge)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'BirthdayMerge'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemDateMerge"/> if <see cref="ConditionType"/> is 'DateMerge', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'DateMerge'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemDateMerge AsDateMerge() =>
        IsDateMerge
            ? (Mailchimp.Marketing.SegmentTypeItemDateMerge)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'DateMerge'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemSelectMerge"/> if <see cref="ConditionType"/> is 'SelectMerge', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'SelectMerge'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemSelectMerge AsSelectMerge() =>
        IsSelectMerge
            ? (Mailchimp.Marketing.SegmentTypeItemSelectMerge)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'SelectMerge'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemTextMerge"/> if <see cref="ConditionType"/> is 'TextMerge', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'TextMerge'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemTextMerge AsTextMerge() =>
        IsTextMerge
            ? (Mailchimp.Marketing.SegmentTypeItemTextMerge)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'TextMerge'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemEmailAddress"/> if <see cref="ConditionType"/> is 'EmailAddress', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'EmailAddress'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemEmailAddress AsEmailAddress() =>
        IsEmailAddress
            ? (Mailchimp.Marketing.SegmentTypeItemEmailAddress)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'EmailAddress'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemPredictedGender"/> if <see cref="ConditionType"/> is 'PredictedGender', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'PredictedGender'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemPredictedGender AsPredictedGender() =>
        IsPredictedGender
            ? (Mailchimp.Marketing.SegmentTypeItemPredictedGender)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'PredictedGender'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemPredictedAge"/> if <see cref="ConditionType"/> is 'PredictedAge', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'PredictedAge'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemPredictedAge AsPredictedAge() =>
        IsPredictedAge
            ? (Mailchimp.Marketing.SegmentTypeItemPredictedAge)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'PredictedAge'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Mailchimp.Marketing.SegmentTypeItemNewSubscribers"/> if <see cref="ConditionType"/> is 'NewSubscribers', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="ConditionType"/> is not 'NewSubscribers'.</exception>
    public Mailchimp.Marketing.SegmentTypeItemNewSubscribers AsNewSubscribers() =>
        IsNewSubscribers
            ? (Mailchimp.Marketing.SegmentTypeItemNewSubscribers)Value!
            : throw new global::System.Exception(
                "SegmentTypeItem.ConditionType is not 'NewSubscribers'"
            );

    public T Match<T>(
        Func<Mailchimp.Marketing.SegmentTypeItemAim, T> onAim,
        Func<Mailchimp.Marketing.SegmentTypeItemAutomation, T> onAutomation,
        Func<Mailchimp.Marketing.SegmentTypeItemCampaignPoll, T> onCampaignPoll,
        Func<Mailchimp.Marketing.SegmentTypeItemConversation, T> onConversation,
        Func<Mailchimp.Marketing.SegmentTypeItemDate, T> onDate,
        Func<Mailchimp.Marketing.SegmentTypeItemEmailClient, T> onEmailClient,
        Func<Mailchimp.Marketing.SegmentTypeItemLanguage, T> onLanguage,
        Func<Mailchimp.Marketing.SegmentTypeItemMemberRating, T> onMemberRating,
        Func<Mailchimp.Marketing.SegmentTypeItemSignupSource, T> onSignupSource,
        Func<Mailchimp.Marketing.SegmentTypeItemSurveyMonkey, T> onSurveyMonkey,
        Func<Mailchimp.Marketing.SegmentTypeItemVip, T> onVip,
        Func<Mailchimp.Marketing.SegmentTypeItemInterests, T> onInterests,
        Func<Mailchimp.Marketing.SegmentTypeItemEcommCategory, T> onEcommCategory,
        Func<Mailchimp.Marketing.SegmentTypeItemEcommNumber, T> onEcommNumber,
        Func<Mailchimp.Marketing.SegmentTypeItemEcommPurchased, T> onEcommPurchased,
        Func<Mailchimp.Marketing.SegmentTypeItemEcommSpent, T> onEcommSpent,
        Func<Mailchimp.Marketing.SegmentTypeItemEcommStore, T> onEcommStore,
        Func<Mailchimp.Marketing.SegmentTypeItemGoalActivity, T> onGoalActivity,
        Func<Mailchimp.Marketing.SegmentTypeItemGoalTimestamp, T> onGoalTimestamp,
        Func<Mailchimp.Marketing.SegmentTypeItemFuzzySegment, T> onFuzzySegment,
        Func<Mailchimp.Marketing.SegmentTypeItemStaticSegment, T> onStaticSegment,
        Func<Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState, T> onIpGeoCountryState,
        Func<Mailchimp.Marketing.SegmentTypeItemIpGeoIn, T> onIpGeoIn,
        Func<Mailchimp.Marketing.SegmentTypeItemIpGeoInZip, T> onIpGeoInZip,
        Func<Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown, T> onIpGeoUnknown,
        Func<Mailchimp.Marketing.SegmentTypeItemIpGeoZip, T> onIpGeoZip,
        Func<Mailchimp.Marketing.SegmentTypeItemSocialAge, T> onSocialAge,
        Func<Mailchimp.Marketing.SegmentTypeItemSocialGender, T> onSocialGender,
        Func<Mailchimp.Marketing.SegmentTypeItemSocialInfluence, T> onSocialInfluence,
        Func<Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember, T> onSocialNetworkMember,
        Func<Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow, T> onSocialNetworkFollow,
        Func<Mailchimp.Marketing.SegmentTypeItemAddressMerge, T> onAddressMerge,
        Func<Mailchimp.Marketing.SegmentTypeItemZipMerge, T> onZipMerge,
        Func<Mailchimp.Marketing.SegmentTypeItemBirthdayMerge, T> onBirthdayMerge,
        Func<Mailchimp.Marketing.SegmentTypeItemDateMerge, T> onDateMerge,
        Func<Mailchimp.Marketing.SegmentTypeItemSelectMerge, T> onSelectMerge,
        Func<Mailchimp.Marketing.SegmentTypeItemTextMerge, T> onTextMerge,
        Func<Mailchimp.Marketing.SegmentTypeItemEmailAddress, T> onEmailAddress,
        Func<Mailchimp.Marketing.SegmentTypeItemPredictedGender, T> onPredictedGender,
        Func<Mailchimp.Marketing.SegmentTypeItemPredictedAge, T> onPredictedAge,
        Func<Mailchimp.Marketing.SegmentTypeItemNewSubscribers, T> onNewSubscribers,
        Func<string, object?, T> onUnknown_
    )
    {
        return ConditionType switch
        {
            "Aim" => onAim(AsAim()),
            "Automation" => onAutomation(AsAutomation()),
            "CampaignPoll" => onCampaignPoll(AsCampaignPoll()),
            "Conversation" => onConversation(AsConversation()),
            "Date" => onDate(AsDate()),
            "EmailClient" => onEmailClient(AsEmailClient()),
            "Language" => onLanguage(AsLanguage()),
            "MemberRating" => onMemberRating(AsMemberRating()),
            "SignupSource" => onSignupSource(AsSignupSource()),
            "SurveyMonkey" => onSurveyMonkey(AsSurveyMonkey()),
            "VIP" => onVip(AsVip()),
            "Interests" => onInterests(AsInterests()),
            "EcommCategory" => onEcommCategory(AsEcommCategory()),
            "EcommNumber" => onEcommNumber(AsEcommNumber()),
            "EcommPurchased" => onEcommPurchased(AsEcommPurchased()),
            "EcommSpent" => onEcommSpent(AsEcommSpent()),
            "EcommStore" => onEcommStore(AsEcommStore()),
            "GoalActivity" => onGoalActivity(AsGoalActivity()),
            "GoalTimestamp" => onGoalTimestamp(AsGoalTimestamp()),
            "FuzzySegment" => onFuzzySegment(AsFuzzySegment()),
            "StaticSegment" => onStaticSegment(AsStaticSegment()),
            "IPGeoCountryState" => onIpGeoCountryState(AsIpGeoCountryState()),
            "IPGeoIn" => onIpGeoIn(AsIpGeoIn()),
            "IPGeoInZip" => onIpGeoInZip(AsIpGeoInZip()),
            "IPGeoUnknown" => onIpGeoUnknown(AsIpGeoUnknown()),
            "IPGeoZip" => onIpGeoZip(AsIpGeoZip()),
            "SocialAge" => onSocialAge(AsSocialAge()),
            "SocialGender" => onSocialGender(AsSocialGender()),
            "SocialInfluence" => onSocialInfluence(AsSocialInfluence()),
            "SocialNetworkMember" => onSocialNetworkMember(AsSocialNetworkMember()),
            "SocialNetworkFollow" => onSocialNetworkFollow(AsSocialNetworkFollow()),
            "AddressMerge" => onAddressMerge(AsAddressMerge()),
            "ZipMerge" => onZipMerge(AsZipMerge()),
            "BirthdayMerge" => onBirthdayMerge(AsBirthdayMerge()),
            "DateMerge" => onDateMerge(AsDateMerge()),
            "SelectMerge" => onSelectMerge(AsSelectMerge()),
            "TextMerge" => onTextMerge(AsTextMerge()),
            "EmailAddress" => onEmailAddress(AsEmailAddress()),
            "PredictedGender" => onPredictedGender(AsPredictedGender()),
            "PredictedAge" => onPredictedAge(AsPredictedAge()),
            "NewSubscribers" => onNewSubscribers(AsNewSubscribers()),
            _ => onUnknown_(ConditionType, Value),
        };
    }

    public void Visit(
        Action<Mailchimp.Marketing.SegmentTypeItemAim> onAim,
        Action<Mailchimp.Marketing.SegmentTypeItemAutomation> onAutomation,
        Action<Mailchimp.Marketing.SegmentTypeItemCampaignPoll> onCampaignPoll,
        Action<Mailchimp.Marketing.SegmentTypeItemConversation> onConversation,
        Action<Mailchimp.Marketing.SegmentTypeItemDate> onDate,
        Action<Mailchimp.Marketing.SegmentTypeItemEmailClient> onEmailClient,
        Action<Mailchimp.Marketing.SegmentTypeItemLanguage> onLanguage,
        Action<Mailchimp.Marketing.SegmentTypeItemMemberRating> onMemberRating,
        Action<Mailchimp.Marketing.SegmentTypeItemSignupSource> onSignupSource,
        Action<Mailchimp.Marketing.SegmentTypeItemSurveyMonkey> onSurveyMonkey,
        Action<Mailchimp.Marketing.SegmentTypeItemVip> onVip,
        Action<Mailchimp.Marketing.SegmentTypeItemInterests> onInterests,
        Action<Mailchimp.Marketing.SegmentTypeItemEcommCategory> onEcommCategory,
        Action<Mailchimp.Marketing.SegmentTypeItemEcommNumber> onEcommNumber,
        Action<Mailchimp.Marketing.SegmentTypeItemEcommPurchased> onEcommPurchased,
        Action<Mailchimp.Marketing.SegmentTypeItemEcommSpent> onEcommSpent,
        Action<Mailchimp.Marketing.SegmentTypeItemEcommStore> onEcommStore,
        Action<Mailchimp.Marketing.SegmentTypeItemGoalActivity> onGoalActivity,
        Action<Mailchimp.Marketing.SegmentTypeItemGoalTimestamp> onGoalTimestamp,
        Action<Mailchimp.Marketing.SegmentTypeItemFuzzySegment> onFuzzySegment,
        Action<Mailchimp.Marketing.SegmentTypeItemStaticSegment> onStaticSegment,
        Action<Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState> onIpGeoCountryState,
        Action<Mailchimp.Marketing.SegmentTypeItemIpGeoIn> onIpGeoIn,
        Action<Mailchimp.Marketing.SegmentTypeItemIpGeoInZip> onIpGeoInZip,
        Action<Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown> onIpGeoUnknown,
        Action<Mailchimp.Marketing.SegmentTypeItemIpGeoZip> onIpGeoZip,
        Action<Mailchimp.Marketing.SegmentTypeItemSocialAge> onSocialAge,
        Action<Mailchimp.Marketing.SegmentTypeItemSocialGender> onSocialGender,
        Action<Mailchimp.Marketing.SegmentTypeItemSocialInfluence> onSocialInfluence,
        Action<Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember> onSocialNetworkMember,
        Action<Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow> onSocialNetworkFollow,
        Action<Mailchimp.Marketing.SegmentTypeItemAddressMerge> onAddressMerge,
        Action<Mailchimp.Marketing.SegmentTypeItemZipMerge> onZipMerge,
        Action<Mailchimp.Marketing.SegmentTypeItemBirthdayMerge> onBirthdayMerge,
        Action<Mailchimp.Marketing.SegmentTypeItemDateMerge> onDateMerge,
        Action<Mailchimp.Marketing.SegmentTypeItemSelectMerge> onSelectMerge,
        Action<Mailchimp.Marketing.SegmentTypeItemTextMerge> onTextMerge,
        Action<Mailchimp.Marketing.SegmentTypeItemEmailAddress> onEmailAddress,
        Action<Mailchimp.Marketing.SegmentTypeItemPredictedGender> onPredictedGender,
        Action<Mailchimp.Marketing.SegmentTypeItemPredictedAge> onPredictedAge,
        Action<Mailchimp.Marketing.SegmentTypeItemNewSubscribers> onNewSubscribers,
        Action<string, object?> onUnknown_
    )
    {
        switch (ConditionType)
        {
            case "Aim":
                onAim(AsAim());
                break;
            case "Automation":
                onAutomation(AsAutomation());
                break;
            case "CampaignPoll":
                onCampaignPoll(AsCampaignPoll());
                break;
            case "Conversation":
                onConversation(AsConversation());
                break;
            case "Date":
                onDate(AsDate());
                break;
            case "EmailClient":
                onEmailClient(AsEmailClient());
                break;
            case "Language":
                onLanguage(AsLanguage());
                break;
            case "MemberRating":
                onMemberRating(AsMemberRating());
                break;
            case "SignupSource":
                onSignupSource(AsSignupSource());
                break;
            case "SurveyMonkey":
                onSurveyMonkey(AsSurveyMonkey());
                break;
            case "VIP":
                onVip(AsVip());
                break;
            case "Interests":
                onInterests(AsInterests());
                break;
            case "EcommCategory":
                onEcommCategory(AsEcommCategory());
                break;
            case "EcommNumber":
                onEcommNumber(AsEcommNumber());
                break;
            case "EcommPurchased":
                onEcommPurchased(AsEcommPurchased());
                break;
            case "EcommSpent":
                onEcommSpent(AsEcommSpent());
                break;
            case "EcommStore":
                onEcommStore(AsEcommStore());
                break;
            case "GoalActivity":
                onGoalActivity(AsGoalActivity());
                break;
            case "GoalTimestamp":
                onGoalTimestamp(AsGoalTimestamp());
                break;
            case "FuzzySegment":
                onFuzzySegment(AsFuzzySegment());
                break;
            case "StaticSegment":
                onStaticSegment(AsStaticSegment());
                break;
            case "IPGeoCountryState":
                onIpGeoCountryState(AsIpGeoCountryState());
                break;
            case "IPGeoIn":
                onIpGeoIn(AsIpGeoIn());
                break;
            case "IPGeoInZip":
                onIpGeoInZip(AsIpGeoInZip());
                break;
            case "IPGeoUnknown":
                onIpGeoUnknown(AsIpGeoUnknown());
                break;
            case "IPGeoZip":
                onIpGeoZip(AsIpGeoZip());
                break;
            case "SocialAge":
                onSocialAge(AsSocialAge());
                break;
            case "SocialGender":
                onSocialGender(AsSocialGender());
                break;
            case "SocialInfluence":
                onSocialInfluence(AsSocialInfluence());
                break;
            case "SocialNetworkMember":
                onSocialNetworkMember(AsSocialNetworkMember());
                break;
            case "SocialNetworkFollow":
                onSocialNetworkFollow(AsSocialNetworkFollow());
                break;
            case "AddressMerge":
                onAddressMerge(AsAddressMerge());
                break;
            case "ZipMerge":
                onZipMerge(AsZipMerge());
                break;
            case "BirthdayMerge":
                onBirthdayMerge(AsBirthdayMerge());
                break;
            case "DateMerge":
                onDateMerge(AsDateMerge());
                break;
            case "SelectMerge":
                onSelectMerge(AsSelectMerge());
                break;
            case "TextMerge":
                onTextMerge(AsTextMerge());
                break;
            case "EmailAddress":
                onEmailAddress(AsEmailAddress());
                break;
            case "PredictedGender":
                onPredictedGender(AsPredictedGender());
                break;
            case "PredictedAge":
                onPredictedAge(AsPredictedAge());
                break;
            case "NewSubscribers":
                onNewSubscribers(AsNewSubscribers());
                break;
            default:
                onUnknown_(ConditionType, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemAim"/> and returns true if successful.
    /// </summary>
    public bool TryAsAim(out Mailchimp.Marketing.SegmentTypeItemAim? value)
    {
        if (ConditionType == "Aim")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemAim)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemAutomation"/> and returns true if successful.
    /// </summary>
    public bool TryAsAutomation(out Mailchimp.Marketing.SegmentTypeItemAutomation? value)
    {
        if (ConditionType == "Automation")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemAutomation)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemCampaignPoll"/> and returns true if successful.
    /// </summary>
    public bool TryAsCampaignPoll(out Mailchimp.Marketing.SegmentTypeItemCampaignPoll? value)
    {
        if (ConditionType == "CampaignPoll")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemCampaignPoll)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemConversation"/> and returns true if successful.
    /// </summary>
    public bool TryAsConversation(out Mailchimp.Marketing.SegmentTypeItemConversation? value)
    {
        if (ConditionType == "Conversation")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemConversation)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemDate"/> and returns true if successful.
    /// </summary>
    public bool TryAsDate(out Mailchimp.Marketing.SegmentTypeItemDate? value)
    {
        if (ConditionType == "Date")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemDate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemEmailClient"/> and returns true if successful.
    /// </summary>
    public bool TryAsEmailClient(out Mailchimp.Marketing.SegmentTypeItemEmailClient? value)
    {
        if (ConditionType == "EmailClient")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemEmailClient)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemLanguage"/> and returns true if successful.
    /// </summary>
    public bool TryAsLanguage(out Mailchimp.Marketing.SegmentTypeItemLanguage? value)
    {
        if (ConditionType == "Language")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemLanguage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemMemberRating"/> and returns true if successful.
    /// </summary>
    public bool TryAsMemberRating(out Mailchimp.Marketing.SegmentTypeItemMemberRating? value)
    {
        if (ConditionType == "MemberRating")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemMemberRating)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemSignupSource"/> and returns true if successful.
    /// </summary>
    public bool TryAsSignupSource(out Mailchimp.Marketing.SegmentTypeItemSignupSource? value)
    {
        if (ConditionType == "SignupSource")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemSignupSource)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemSurveyMonkey"/> and returns true if successful.
    /// </summary>
    public bool TryAsSurveyMonkey(out Mailchimp.Marketing.SegmentTypeItemSurveyMonkey? value)
    {
        if (ConditionType == "SurveyMonkey")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemSurveyMonkey)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemVip"/> and returns true if successful.
    /// </summary>
    public bool TryAsVip(out Mailchimp.Marketing.SegmentTypeItemVip? value)
    {
        if (ConditionType == "VIP")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemVip)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemInterests"/> and returns true if successful.
    /// </summary>
    public bool TryAsInterests(out Mailchimp.Marketing.SegmentTypeItemInterests? value)
    {
        if (ConditionType == "Interests")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemInterests)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommCategory"/> and returns true if successful.
    /// </summary>
    public bool TryAsEcommCategory(out Mailchimp.Marketing.SegmentTypeItemEcommCategory? value)
    {
        if (ConditionType == "EcommCategory")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemEcommCategory)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsEcommNumber(out Mailchimp.Marketing.SegmentTypeItemEcommNumber? value)
    {
        if (ConditionType == "EcommNumber")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemEcommNumber)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommPurchased"/> and returns true if successful.
    /// </summary>
    public bool TryAsEcommPurchased(out Mailchimp.Marketing.SegmentTypeItemEcommPurchased? value)
    {
        if (ConditionType == "EcommPurchased")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemEcommPurchased)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommSpent"/> and returns true if successful.
    /// </summary>
    public bool TryAsEcommSpent(out Mailchimp.Marketing.SegmentTypeItemEcommSpent? value)
    {
        if (ConditionType == "EcommSpent")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemEcommSpent)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemEcommStore"/> and returns true if successful.
    /// </summary>
    public bool TryAsEcommStore(out Mailchimp.Marketing.SegmentTypeItemEcommStore? value)
    {
        if (ConditionType == "EcommStore")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemEcommStore)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemGoalActivity"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoalActivity(out Mailchimp.Marketing.SegmentTypeItemGoalActivity? value)
    {
        if (ConditionType == "GoalActivity")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemGoalActivity)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemGoalTimestamp"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoalTimestamp(out Mailchimp.Marketing.SegmentTypeItemGoalTimestamp? value)
    {
        if (ConditionType == "GoalTimestamp")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemGoalTimestamp)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemFuzzySegment"/> and returns true if successful.
    /// </summary>
    public bool TryAsFuzzySegment(out Mailchimp.Marketing.SegmentTypeItemFuzzySegment? value)
    {
        if (ConditionType == "FuzzySegment")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemFuzzySegment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemStaticSegment"/> and returns true if successful.
    /// </summary>
    public bool TryAsStaticSegment(out Mailchimp.Marketing.SegmentTypeItemStaticSegment? value)
    {
        if (ConditionType == "StaticSegment")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemStaticSegment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState"/> and returns true if successful.
    /// </summary>
    public bool TryAsIpGeoCountryState(
        out Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState? value
    )
    {
        if (ConditionType == "IPGeoCountryState")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoIn"/> and returns true if successful.
    /// </summary>
    public bool TryAsIpGeoIn(out Mailchimp.Marketing.SegmentTypeItemIpGeoIn? value)
    {
        if (ConditionType == "IPGeoIn")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemIpGeoIn)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoInZip"/> and returns true if successful.
    /// </summary>
    public bool TryAsIpGeoInZip(out Mailchimp.Marketing.SegmentTypeItemIpGeoInZip? value)
    {
        if (ConditionType == "IPGeoInZip")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemIpGeoInZip)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsIpGeoUnknown(out Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown? value)
    {
        if (ConditionType == "IPGeoUnknown")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemIpGeoZip"/> and returns true if successful.
    /// </summary>
    public bool TryAsIpGeoZip(out Mailchimp.Marketing.SegmentTypeItemIpGeoZip? value)
    {
        if (ConditionType == "IPGeoZip")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemIpGeoZip)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialAge"/> and returns true if successful.
    /// </summary>
    public bool TryAsSocialAge(out Mailchimp.Marketing.SegmentTypeItemSocialAge? value)
    {
        if (ConditionType == "SocialAge")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemSocialAge)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialGender"/> and returns true if successful.
    /// </summary>
    public bool TryAsSocialGender(out Mailchimp.Marketing.SegmentTypeItemSocialGender? value)
    {
        if (ConditionType == "SocialGender")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemSocialGender)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialInfluence"/> and returns true if successful.
    /// </summary>
    public bool TryAsSocialInfluence(out Mailchimp.Marketing.SegmentTypeItemSocialInfluence? value)
    {
        if (ConditionType == "SocialInfluence")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemSocialInfluence)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember"/> and returns true if successful.
    /// </summary>
    public bool TryAsSocialNetworkMember(
        out Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember? value
    )
    {
        if (ConditionType == "SocialNetworkMember")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow"/> and returns true if successful.
    /// </summary>
    public bool TryAsSocialNetworkFollow(
        out Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow? value
    )
    {
        if (ConditionType == "SocialNetworkFollow")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemAddressMerge"/> and returns true if successful.
    /// </summary>
    public bool TryAsAddressMerge(out Mailchimp.Marketing.SegmentTypeItemAddressMerge? value)
    {
        if (ConditionType == "AddressMerge")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemAddressMerge)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemZipMerge"/> and returns true if successful.
    /// </summary>
    public bool TryAsZipMerge(out Mailchimp.Marketing.SegmentTypeItemZipMerge? value)
    {
        if (ConditionType == "ZipMerge")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemZipMerge)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemBirthdayMerge"/> and returns true if successful.
    /// </summary>
    public bool TryAsBirthdayMerge(out Mailchimp.Marketing.SegmentTypeItemBirthdayMerge? value)
    {
        if (ConditionType == "BirthdayMerge")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemBirthdayMerge)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemDateMerge"/> and returns true if successful.
    /// </summary>
    public bool TryAsDateMerge(out Mailchimp.Marketing.SegmentTypeItemDateMerge? value)
    {
        if (ConditionType == "DateMerge")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemDateMerge)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemSelectMerge"/> and returns true if successful.
    /// </summary>
    public bool TryAsSelectMerge(out Mailchimp.Marketing.SegmentTypeItemSelectMerge? value)
    {
        if (ConditionType == "SelectMerge")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemSelectMerge)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemTextMerge"/> and returns true if successful.
    /// </summary>
    public bool TryAsTextMerge(out Mailchimp.Marketing.SegmentTypeItemTextMerge? value)
    {
        if (ConditionType == "TextMerge")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemTextMerge)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemEmailAddress"/> and returns true if successful.
    /// </summary>
    public bool TryAsEmailAddress(out Mailchimp.Marketing.SegmentTypeItemEmailAddress? value)
    {
        if (ConditionType == "EmailAddress")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemEmailAddress)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemPredictedGender"/> and returns true if successful.
    /// </summary>
    public bool TryAsPredictedGender(out Mailchimp.Marketing.SegmentTypeItemPredictedGender? value)
    {
        if (ConditionType == "PredictedGender")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemPredictedGender)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemPredictedAge"/> and returns true if successful.
    /// </summary>
    public bool TryAsPredictedAge(out Mailchimp.Marketing.SegmentTypeItemPredictedAge? value)
    {
        if (ConditionType == "PredictedAge")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemPredictedAge)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Mailchimp.Marketing.SegmentTypeItemNewSubscribers"/> and returns true if successful.
    /// </summary>
    public bool TryAsNewSubscribers(out Mailchimp.Marketing.SegmentTypeItemNewSubscribers? value)
    {
        if (ConditionType == "NewSubscribers")
        {
            value = (Mailchimp.Marketing.SegmentTypeItemNewSubscribers)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.Aim value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.Automation value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.CampaignPoll value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.Conversation value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.Date value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.EmailClient value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.Language value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.MemberRating value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.SignupSource value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.SurveyMonkey value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.Vip value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.Interests value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.EcommCategory value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.EcommNumber value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.EcommPurchased value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.EcommSpent value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.EcommStore value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.GoalActivity value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.GoalTimestamp value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.FuzzySegment value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.StaticSegment value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.IpGeoCountryState value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.IpGeoIn value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.IpGeoInZip value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.IpGeoUnknown value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.IpGeoZip value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.SocialAge value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.SocialGender value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.SocialInfluence value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.SocialNetworkMember value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.SocialNetworkFollow value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.AddressMerge value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.ZipMerge value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.BirthdayMerge value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.DateMerge value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.SelectMerge value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.TextMerge value) => new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.EmailAddress value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.PredictedGender value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.PredictedAge value) =>
        new(value);

    public static implicit operator SegmentTypeItem(SegmentTypeItem.NewSubscribers value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<SegmentTypeItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(SegmentTypeItem).IsAssignableFrom(typeToConvert);

        public override SegmentTypeItem Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("condition_type", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'condition_type'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'condition_type' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'condition_type' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'condition_type' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("condition_type");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "Aim" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemAim?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemAim"
                        ),
                "Automation" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemAutomation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemAutomation"
                        ),
                "CampaignPoll" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemCampaignPoll?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemCampaignPoll"
                        ),
                "Conversation" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemConversation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemConversation"
                        ),
                "Date" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemDate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemDate"
                        ),
                "EmailClient" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemEmailClient?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemEmailClient"
                        ),
                "Language" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemLanguage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemLanguage"
                        ),
                "MemberRating" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemMemberRating?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemMemberRating"
                        ),
                "SignupSource" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemSignupSource?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemSignupSource"
                        ),
                "SurveyMonkey" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemSurveyMonkey?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemSurveyMonkey"
                        ),
                "VIP" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemVip?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemVip"
                        ),
                "Interests" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemInterests?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemInterests"
                        ),
                "EcommCategory" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemEcommCategory?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemEcommCategory"
                        ),
                "EcommNumber" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemEcommNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemEcommNumber"
                        ),
                "EcommPurchased" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemEcommPurchased?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemEcommPurchased"
                        ),
                "EcommSpent" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemEcommSpent?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemEcommSpent"
                        ),
                "EcommStore" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemEcommStore?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemEcommStore"
                        ),
                "GoalActivity" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemGoalActivity?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemGoalActivity"
                        ),
                "GoalTimestamp" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemGoalTimestamp?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemGoalTimestamp"
                        ),
                "FuzzySegment" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemFuzzySegment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemFuzzySegment"
                        ),
                "StaticSegment" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemStaticSegment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemStaticSegment"
                        ),
                "IPGeoCountryState" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState"
                        ),
                "IPGeoIn" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemIpGeoIn?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemIpGeoIn"
                        ),
                "IPGeoInZip" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemIpGeoInZip?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemIpGeoInZip"
                        ),
                "IPGeoUnknown" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown"
                        ),
                "IPGeoZip" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemIpGeoZip?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemIpGeoZip"
                        ),
                "SocialAge" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemSocialAge?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemSocialAge"
                        ),
                "SocialGender" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemSocialGender?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemSocialGender"
                        ),
                "SocialInfluence" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemSocialInfluence?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemSocialInfluence"
                        ),
                "SocialNetworkMember" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember"
                        ),
                "SocialNetworkFollow" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow"
                        ),
                "AddressMerge" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemAddressMerge?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemAddressMerge"
                        ),
                "ZipMerge" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemZipMerge?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemZipMerge"
                        ),
                "BirthdayMerge" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemBirthdayMerge?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemBirthdayMerge"
                        ),
                "DateMerge" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemDateMerge?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemDateMerge"
                        ),
                "SelectMerge" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemSelectMerge?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemSelectMerge"
                        ),
                "TextMerge" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemTextMerge?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemTextMerge"
                        ),
                "EmailAddress" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemEmailAddress?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemEmailAddress"
                        ),
                "PredictedGender" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemPredictedGender?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemPredictedGender"
                        ),
                "PredictedAge" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemPredictedAge?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemPredictedAge"
                        ),
                "NewSubscribers" =>
                    jsonWithoutDiscriminator.Deserialize<Mailchimp.Marketing.SegmentTypeItemNewSubscribers?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Mailchimp.Marketing.SegmentTypeItemNewSubscribers"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new SegmentTypeItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItem value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.ConditionType switch
                {
                    "Aim" => JsonSerializer.SerializeToNode(value.Value, options),
                    "Automation" => JsonSerializer.SerializeToNode(value.Value, options),
                    "CampaignPoll" => JsonSerializer.SerializeToNode(value.Value, options),
                    "Conversation" => JsonSerializer.SerializeToNode(value.Value, options),
                    "Date" => JsonSerializer.SerializeToNode(value.Value, options),
                    "EmailClient" => JsonSerializer.SerializeToNode(value.Value, options),
                    "Language" => JsonSerializer.SerializeToNode(value.Value, options),
                    "MemberRating" => JsonSerializer.SerializeToNode(value.Value, options),
                    "SignupSource" => JsonSerializer.SerializeToNode(value.Value, options),
                    "SurveyMonkey" => JsonSerializer.SerializeToNode(value.Value, options),
                    "VIP" => JsonSerializer.SerializeToNode(value.Value, options),
                    "Interests" => JsonSerializer.SerializeToNode(value.Value, options),
                    "EcommCategory" => JsonSerializer.SerializeToNode(value.Value, options),
                    "EcommNumber" => JsonSerializer.SerializeToNode(value.Value, options),
                    "EcommPurchased" => JsonSerializer.SerializeToNode(value.Value, options),
                    "EcommSpent" => JsonSerializer.SerializeToNode(value.Value, options),
                    "EcommStore" => JsonSerializer.SerializeToNode(value.Value, options),
                    "GoalActivity" => JsonSerializer.SerializeToNode(value.Value, options),
                    "GoalTimestamp" => JsonSerializer.SerializeToNode(value.Value, options),
                    "FuzzySegment" => JsonSerializer.SerializeToNode(value.Value, options),
                    "StaticSegment" => JsonSerializer.SerializeToNode(value.Value, options),
                    "IPGeoCountryState" => JsonSerializer.SerializeToNode(value.Value, options),
                    "IPGeoIn" => JsonSerializer.SerializeToNode(value.Value, options),
                    "IPGeoInZip" => JsonSerializer.SerializeToNode(value.Value, options),
                    "IPGeoUnknown" => JsonSerializer.SerializeToNode(value.Value, options),
                    "IPGeoZip" => JsonSerializer.SerializeToNode(value.Value, options),
                    "SocialAge" => JsonSerializer.SerializeToNode(value.Value, options),
                    "SocialGender" => JsonSerializer.SerializeToNode(value.Value, options),
                    "SocialInfluence" => JsonSerializer.SerializeToNode(value.Value, options),
                    "SocialNetworkMember" => JsonSerializer.SerializeToNode(value.Value, options),
                    "SocialNetworkFollow" => JsonSerializer.SerializeToNode(value.Value, options),
                    "AddressMerge" => JsonSerializer.SerializeToNode(value.Value, options),
                    "ZipMerge" => JsonSerializer.SerializeToNode(value.Value, options),
                    "BirthdayMerge" => JsonSerializer.SerializeToNode(value.Value, options),
                    "DateMerge" => JsonSerializer.SerializeToNode(value.Value, options),
                    "SelectMerge" => JsonSerializer.SerializeToNode(value.Value, options),
                    "TextMerge" => JsonSerializer.SerializeToNode(value.Value, options),
                    "EmailAddress" => JsonSerializer.SerializeToNode(value.Value, options),
                    "PredictedGender" => JsonSerializer.SerializeToNode(value.Value, options),
                    "PredictedAge" => JsonSerializer.SerializeToNode(value.Value, options),
                    "NewSubscribers" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["condition_type"] = value.ConditionType;
            json.WriteTo(writer, options);
        }

        public override SegmentTypeItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new SegmentTypeItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItem value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.ConditionType);
        }
    }

    /// <summary>
    /// Discriminated union type for Aim
    /// </summary>
    [Serializable]
    public struct Aim
    {
        public Aim(Mailchimp.Marketing.SegmentTypeItemAim value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemAim Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.Aim(
            Mailchimp.Marketing.SegmentTypeItemAim value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for Automation
    /// </summary>
    [Serializable]
    public struct Automation
    {
        public Automation(Mailchimp.Marketing.SegmentTypeItemAutomation value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemAutomation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.Automation(
            Mailchimp.Marketing.SegmentTypeItemAutomation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for CampaignPoll
    /// </summary>
    [Serializable]
    public struct CampaignPoll
    {
        public CampaignPoll(Mailchimp.Marketing.SegmentTypeItemCampaignPoll value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemCampaignPoll Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.CampaignPoll(
            Mailchimp.Marketing.SegmentTypeItemCampaignPoll value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for Conversation
    /// </summary>
    [Serializable]
    public struct Conversation
    {
        public Conversation(Mailchimp.Marketing.SegmentTypeItemConversation value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemConversation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.Conversation(
            Mailchimp.Marketing.SegmentTypeItemConversation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for Date
    /// </summary>
    [Serializable]
    public struct Date
    {
        public Date(Mailchimp.Marketing.SegmentTypeItemDate value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemDate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.Date(
            Mailchimp.Marketing.SegmentTypeItemDate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for EmailClient
    /// </summary>
    [Serializable]
    public struct EmailClient
    {
        public EmailClient(Mailchimp.Marketing.SegmentTypeItemEmailClient value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemEmailClient Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.EmailClient(
            Mailchimp.Marketing.SegmentTypeItemEmailClient value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for Language
    /// </summary>
    [Serializable]
    public struct Language
    {
        public Language(Mailchimp.Marketing.SegmentTypeItemLanguage value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemLanguage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.Language(
            Mailchimp.Marketing.SegmentTypeItemLanguage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for MemberRating
    /// </summary>
    [Serializable]
    public struct MemberRating
    {
        public MemberRating(Mailchimp.Marketing.SegmentTypeItemMemberRating value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemMemberRating Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.MemberRating(
            Mailchimp.Marketing.SegmentTypeItemMemberRating value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for SignupSource
    /// </summary>
    [Serializable]
    public struct SignupSource
    {
        public SignupSource(Mailchimp.Marketing.SegmentTypeItemSignupSource value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemSignupSource Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.SignupSource(
            Mailchimp.Marketing.SegmentTypeItemSignupSource value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for SurveyMonkey
    /// </summary>
    [Serializable]
    public struct SurveyMonkey
    {
        public SurveyMonkey(Mailchimp.Marketing.SegmentTypeItemSurveyMonkey value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemSurveyMonkey Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.SurveyMonkey(
            Mailchimp.Marketing.SegmentTypeItemSurveyMonkey value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for VIP
    /// </summary>
    [Serializable]
    public struct Vip
    {
        public Vip(Mailchimp.Marketing.SegmentTypeItemVip value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemVip Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.Vip(
            Mailchimp.Marketing.SegmentTypeItemVip value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for Interests
    /// </summary>
    [Serializable]
    public struct Interests
    {
        public Interests(Mailchimp.Marketing.SegmentTypeItemInterests value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemInterests Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.Interests(
            Mailchimp.Marketing.SegmentTypeItemInterests value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for EcommCategory
    /// </summary>
    [Serializable]
    public struct EcommCategory
    {
        public EcommCategory(Mailchimp.Marketing.SegmentTypeItemEcommCategory value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemEcommCategory Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.EcommCategory(
            Mailchimp.Marketing.SegmentTypeItemEcommCategory value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for EcommNumber
    /// </summary>
    [Serializable]
    public struct EcommNumber
    {
        public EcommNumber(Mailchimp.Marketing.SegmentTypeItemEcommNumber value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemEcommNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.EcommNumber(
            Mailchimp.Marketing.SegmentTypeItemEcommNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for EcommPurchased
    /// </summary>
    [Serializable]
    public struct EcommPurchased
    {
        public EcommPurchased(Mailchimp.Marketing.SegmentTypeItemEcommPurchased value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemEcommPurchased Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.EcommPurchased(
            Mailchimp.Marketing.SegmentTypeItemEcommPurchased value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for EcommSpent
    /// </summary>
    [Serializable]
    public struct EcommSpent
    {
        public EcommSpent(Mailchimp.Marketing.SegmentTypeItemEcommSpent value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemEcommSpent Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.EcommSpent(
            Mailchimp.Marketing.SegmentTypeItemEcommSpent value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for EcommStore
    /// </summary>
    [Serializable]
    public struct EcommStore
    {
        public EcommStore(Mailchimp.Marketing.SegmentTypeItemEcommStore value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemEcommStore Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.EcommStore(
            Mailchimp.Marketing.SegmentTypeItemEcommStore value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for GoalActivity
    /// </summary>
    [Serializable]
    public struct GoalActivity
    {
        public GoalActivity(Mailchimp.Marketing.SegmentTypeItemGoalActivity value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemGoalActivity Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.GoalActivity(
            Mailchimp.Marketing.SegmentTypeItemGoalActivity value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for GoalTimestamp
    /// </summary>
    [Serializable]
    public struct GoalTimestamp
    {
        public GoalTimestamp(Mailchimp.Marketing.SegmentTypeItemGoalTimestamp value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemGoalTimestamp Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.GoalTimestamp(
            Mailchimp.Marketing.SegmentTypeItemGoalTimestamp value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for FuzzySegment
    /// </summary>
    [Serializable]
    public struct FuzzySegment
    {
        public FuzzySegment(Mailchimp.Marketing.SegmentTypeItemFuzzySegment value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemFuzzySegment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.FuzzySegment(
            Mailchimp.Marketing.SegmentTypeItemFuzzySegment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for StaticSegment
    /// </summary>
    [Serializable]
    public struct StaticSegment
    {
        public StaticSegment(Mailchimp.Marketing.SegmentTypeItemStaticSegment value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemStaticSegment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.StaticSegment(
            Mailchimp.Marketing.SegmentTypeItemStaticSegment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for IPGeoCountryState
    /// </summary>
    [Serializable]
    public struct IpGeoCountryState
    {
        public IpGeoCountryState(Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.IpGeoCountryState(
            Mailchimp.Marketing.SegmentTypeItemIpGeoCountryState value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for IPGeoIn
    /// </summary>
    [Serializable]
    public struct IpGeoIn
    {
        public IpGeoIn(Mailchimp.Marketing.SegmentTypeItemIpGeoIn value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemIpGeoIn Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.IpGeoIn(
            Mailchimp.Marketing.SegmentTypeItemIpGeoIn value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for IPGeoInZip
    /// </summary>
    [Serializable]
    public struct IpGeoInZip
    {
        public IpGeoInZip(Mailchimp.Marketing.SegmentTypeItemIpGeoInZip value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemIpGeoInZip Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.IpGeoInZip(
            Mailchimp.Marketing.SegmentTypeItemIpGeoInZip value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for IPGeoUnknown
    /// </summary>
    [Serializable]
    public struct IpGeoUnknown
    {
        public IpGeoUnknown(Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.IpGeoUnknown(
            Mailchimp.Marketing.SegmentTypeItemIpGeoUnknown value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for IPGeoZip
    /// </summary>
    [Serializable]
    public struct IpGeoZip
    {
        public IpGeoZip(Mailchimp.Marketing.SegmentTypeItemIpGeoZip value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemIpGeoZip Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.IpGeoZip(
            Mailchimp.Marketing.SegmentTypeItemIpGeoZip value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for SocialAge
    /// </summary>
    [Serializable]
    public struct SocialAge
    {
        public SocialAge(Mailchimp.Marketing.SegmentTypeItemSocialAge value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemSocialAge Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.SocialAge(
            Mailchimp.Marketing.SegmentTypeItemSocialAge value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for SocialGender
    /// </summary>
    [Serializable]
    public struct SocialGender
    {
        public SocialGender(Mailchimp.Marketing.SegmentTypeItemSocialGender value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemSocialGender Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.SocialGender(
            Mailchimp.Marketing.SegmentTypeItemSocialGender value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for SocialInfluence
    /// </summary>
    [Serializable]
    public struct SocialInfluence
    {
        public SocialInfluence(Mailchimp.Marketing.SegmentTypeItemSocialInfluence value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemSocialInfluence Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.SocialInfluence(
            Mailchimp.Marketing.SegmentTypeItemSocialInfluence value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for SocialNetworkMember
    /// </summary>
    [Serializable]
    public struct SocialNetworkMember
    {
        public SocialNetworkMember(Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.SocialNetworkMember(
            Mailchimp.Marketing.SegmentTypeItemSocialNetworkMember value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for SocialNetworkFollow
    /// </summary>
    [Serializable]
    public struct SocialNetworkFollow
    {
        public SocialNetworkFollow(Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.SocialNetworkFollow(
            Mailchimp.Marketing.SegmentTypeItemSocialNetworkFollow value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for AddressMerge
    /// </summary>
    [Serializable]
    public struct AddressMerge
    {
        public AddressMerge(Mailchimp.Marketing.SegmentTypeItemAddressMerge value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemAddressMerge Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.AddressMerge(
            Mailchimp.Marketing.SegmentTypeItemAddressMerge value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for ZipMerge
    /// </summary>
    [Serializable]
    public struct ZipMerge
    {
        public ZipMerge(Mailchimp.Marketing.SegmentTypeItemZipMerge value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemZipMerge Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.ZipMerge(
            Mailchimp.Marketing.SegmentTypeItemZipMerge value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for BirthdayMerge
    /// </summary>
    [Serializable]
    public struct BirthdayMerge
    {
        public BirthdayMerge(Mailchimp.Marketing.SegmentTypeItemBirthdayMerge value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemBirthdayMerge Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.BirthdayMerge(
            Mailchimp.Marketing.SegmentTypeItemBirthdayMerge value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for DateMerge
    /// </summary>
    [Serializable]
    public struct DateMerge
    {
        public DateMerge(Mailchimp.Marketing.SegmentTypeItemDateMerge value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemDateMerge Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.DateMerge(
            Mailchimp.Marketing.SegmentTypeItemDateMerge value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for SelectMerge
    /// </summary>
    [Serializable]
    public struct SelectMerge
    {
        public SelectMerge(Mailchimp.Marketing.SegmentTypeItemSelectMerge value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemSelectMerge Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.SelectMerge(
            Mailchimp.Marketing.SegmentTypeItemSelectMerge value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for TextMerge
    /// </summary>
    [Serializable]
    public struct TextMerge
    {
        public TextMerge(Mailchimp.Marketing.SegmentTypeItemTextMerge value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemTextMerge Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.TextMerge(
            Mailchimp.Marketing.SegmentTypeItemTextMerge value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for EmailAddress
    /// </summary>
    [Serializable]
    public struct EmailAddress
    {
        public EmailAddress(Mailchimp.Marketing.SegmentTypeItemEmailAddress value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemEmailAddress Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.EmailAddress(
            Mailchimp.Marketing.SegmentTypeItemEmailAddress value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for PredictedGender
    /// </summary>
    [Serializable]
    public struct PredictedGender
    {
        public PredictedGender(Mailchimp.Marketing.SegmentTypeItemPredictedGender value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemPredictedGender Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.PredictedGender(
            Mailchimp.Marketing.SegmentTypeItemPredictedGender value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for PredictedAge
    /// </summary>
    [Serializable]
    public struct PredictedAge
    {
        public PredictedAge(Mailchimp.Marketing.SegmentTypeItemPredictedAge value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemPredictedAge Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.PredictedAge(
            Mailchimp.Marketing.SegmentTypeItemPredictedAge value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for NewSubscribers
    /// </summary>
    [Serializable]
    public struct NewSubscribers
    {
        public NewSubscribers(Mailchimp.Marketing.SegmentTypeItemNewSubscribers value)
        {
            Value = value;
        }

        internal Mailchimp.Marketing.SegmentTypeItemNewSubscribers Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator SegmentTypeItem.NewSubscribers(
            Mailchimp.Marketing.SegmentTypeItemNewSubscribers value
        ) => new(value);
    }
}
