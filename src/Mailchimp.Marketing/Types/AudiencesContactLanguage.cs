using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(AudiencesContactLanguage.AudiencesContactLanguageSerializer))]
[Serializable]
public readonly record struct AudiencesContactLanguage : IStringEnum
{
    public static readonly AudiencesContactLanguage Empty = new(Values.Empty);

    public static readonly AudiencesContactLanguage En = new(Values.En);

    public static readonly AudiencesContactLanguage Ar = new(Values.Ar);

    public static readonly AudiencesContactLanguage Af = new(Values.Af);

    public static readonly AudiencesContactLanguage Be = new(Values.Be);

    public static readonly AudiencesContactLanguage Bg = new(Values.Bg);

    public static readonly AudiencesContactLanguage Ca = new(Values.Ca);

    public static readonly AudiencesContactLanguage Zh = new(Values.Zh);

    public static readonly AudiencesContactLanguage ZhCn = new(Values.ZhCn);

    public static readonly AudiencesContactLanguage Hr = new(Values.Hr);

    public static readonly AudiencesContactLanguage Cs = new(Values.Cs);

    public static readonly AudiencesContactLanguage Da = new(Values.Da);

    public static readonly AudiencesContactLanguage Nl = new(Values.Nl);

    public static readonly AudiencesContactLanguage Et = new(Values.Et);

    public static readonly AudiencesContactLanguage Fa = new(Values.Fa);

    public static readonly AudiencesContactLanguage Fi = new(Values.Fi);

    public static readonly AudiencesContactLanguage Fr = new(Values.Fr);

    public static readonly AudiencesContactLanguage FrCa = new(Values.FrCa);

    public static readonly AudiencesContactLanguage De = new(Values.De);

    public static readonly AudiencesContactLanguage El = new(Values.El);

    public static readonly AudiencesContactLanguage He = new(Values.He);

    public static readonly AudiencesContactLanguage Hi = new(Values.Hi);

    public static readonly AudiencesContactLanguage Hu = new(Values.Hu);

    public static readonly AudiencesContactLanguage Is = new(Values.Is);

    public static readonly AudiencesContactLanguage Id = new(Values.Id);

    public static readonly AudiencesContactLanguage Ga = new(Values.Ga);

    public static readonly AudiencesContactLanguage It = new(Values.It);

    public static readonly AudiencesContactLanguage Ja = new(Values.Ja);

    public static readonly AudiencesContactLanguage Km = new(Values.Km);

    public static readonly AudiencesContactLanguage Ko = new(Values.Ko);

    public static readonly AudiencesContactLanguage Lv = new(Values.Lv);

    public static readonly AudiencesContactLanguage Lt = new(Values.Lt);

    public static readonly AudiencesContactLanguage Mt = new(Values.Mt);

    public static readonly AudiencesContactLanguage Ms = new(Values.Ms);

    public static readonly AudiencesContactLanguage Mk = new(Values.Mk);

    public static readonly AudiencesContactLanguage No = new(Values.No);

    public static readonly AudiencesContactLanguage Pl = new(Values.Pl);

    public static readonly AudiencesContactLanguage Pt = new(Values.Pt);

    public static readonly AudiencesContactLanguage PtPt = new(Values.PtPt);

    public static readonly AudiencesContactLanguage Ro = new(Values.Ro);

    public static readonly AudiencesContactLanguage Ru = new(Values.Ru);

    public static readonly AudiencesContactLanguage Sr = new(Values.Sr);

    public static readonly AudiencesContactLanguage Sk = new(Values.Sk);

    public static readonly AudiencesContactLanguage Sl = new(Values.Sl);

    public static readonly AudiencesContactLanguage Es = new(Values.Es);

    public static readonly AudiencesContactLanguage EsEs = new(Values.EsEs);

    public static readonly AudiencesContactLanguage Sw = new(Values.Sw);

    public static readonly AudiencesContactLanguage Sv = new(Values.Sv);

    public static readonly AudiencesContactLanguage Ta = new(Values.Ta);

    public static readonly AudiencesContactLanguage Th = new(Values.Th);

    public static readonly AudiencesContactLanguage Tr = new(Values.Tr);

    public static readonly AudiencesContactLanguage Uk = new(Values.Uk);

    public static readonly AudiencesContactLanguage Vi = new(Values.Vi);

    public AudiencesContactLanguage(string value)
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
    public static AudiencesContactLanguage FromCustom(string value)
    {
        return new AudiencesContactLanguage(value);
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

    public static bool operator ==(AudiencesContactLanguage value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AudiencesContactLanguage value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AudiencesContactLanguage value) => value.Value;

    public static explicit operator AudiencesContactLanguage(string value) => new(value);

    internal class AudiencesContactLanguageSerializer : JsonConverter<AudiencesContactLanguage>
    {
        public override AudiencesContactLanguage Read(
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
            return new AudiencesContactLanguage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AudiencesContactLanguage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AudiencesContactLanguage ReadAsPropertyName(
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
            return new AudiencesContactLanguage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AudiencesContactLanguage value,
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
        public const string Empty = "";

        public const string En = "en";

        public const string Ar = "ar";

        public const string Af = "af";

        public const string Be = "be";

        public const string Bg = "bg";

        public const string Ca = "ca";

        public const string Zh = "zh";

        public const string ZhCn = "zh_CN";

        public const string Hr = "hr";

        public const string Cs = "cs";

        public const string Da = "da";

        public const string Nl = "nl";

        public const string Et = "et";

        public const string Fa = "fa";

        public const string Fi = "fi";

        public const string Fr = "fr";

        public const string FrCa = "fr_CA";

        public const string De = "de";

        public const string El = "el";

        public const string He = "he";

        public const string Hi = "hi";

        public const string Hu = "hu";

        public const string Is = "is";

        public const string Id = "id";

        public const string Ga = "ga";

        public const string It = "it";

        public const string Ja = "ja";

        public const string Km = "km";

        public const string Ko = "ko";

        public const string Lv = "lv";

        public const string Lt = "lt";

        public const string Mt = "mt";

        public const string Ms = "ms";

        public const string Mk = "mk";

        public const string No = "no";

        public const string Pl = "pl";

        public const string Pt = "pt";

        public const string PtPt = "pt_PT";

        public const string Ro = "ro";

        public const string Ru = "ru";

        public const string Sr = "sr";

        public const string Sk = "sk";

        public const string Sl = "sl";

        public const string Es = "es";

        public const string EsEs = "es_ES";

        public const string Sw = "sw";

        public const string Sv = "sv";

        public const string Ta = "ta";

        public const string Th = "th";

        public const string Tr = "tr";

        public const string Uk = "uk";

        public const string Vi = "vi";
    }
}
