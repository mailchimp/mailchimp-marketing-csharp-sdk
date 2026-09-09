using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateSignupFormListsRequestHeaderImageBorderStyle.CreateSignupFormListsRequestHeaderImageBorderStyleSerializer)
)]
[Serializable]
public readonly record struct CreateSignupFormListsRequestHeaderImageBorderStyle : IStringEnum
{
    public static readonly CreateSignupFormListsRequestHeaderImageBorderStyle None = new(
        Values.None
    );

    public static readonly CreateSignupFormListsRequestHeaderImageBorderStyle Solid = new(
        Values.Solid
    );

    public static readonly CreateSignupFormListsRequestHeaderImageBorderStyle Dotted = new(
        Values.Dotted
    );

    public static readonly CreateSignupFormListsRequestHeaderImageBorderStyle Dashed = new(
        Values.Dashed
    );

    public static readonly CreateSignupFormListsRequestHeaderImageBorderStyle Double = new(
        Values.Double
    );

    public static readonly CreateSignupFormListsRequestHeaderImageBorderStyle Groove = new(
        Values.Groove
    );

    public static readonly CreateSignupFormListsRequestHeaderImageBorderStyle Outset = new(
        Values.Outset
    );

    public static readonly CreateSignupFormListsRequestHeaderImageBorderStyle Inset = new(
        Values.Inset
    );

    public static readonly CreateSignupFormListsRequestHeaderImageBorderStyle Ridge = new(
        Values.Ridge
    );

    public CreateSignupFormListsRequestHeaderImageBorderStyle(string value)
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
    public static CreateSignupFormListsRequestHeaderImageBorderStyle FromCustom(string value)
    {
        return new CreateSignupFormListsRequestHeaderImageBorderStyle(value);
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
        CreateSignupFormListsRequestHeaderImageBorderStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateSignupFormListsRequestHeaderImageBorderStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateSignupFormListsRequestHeaderImageBorderStyle value
    ) => value.Value;

    public static explicit operator CreateSignupFormListsRequestHeaderImageBorderStyle(
        string value
    ) => new(value);

    internal class CreateSignupFormListsRequestHeaderImageBorderStyleSerializer
        : JsonConverter<CreateSignupFormListsRequestHeaderImageBorderStyle>
    {
        public override CreateSignupFormListsRequestHeaderImageBorderStyle Read(
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
            return new CreateSignupFormListsRequestHeaderImageBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateSignupFormListsRequestHeaderImageBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateSignupFormListsRequestHeaderImageBorderStyle ReadAsPropertyName(
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
            return new CreateSignupFormListsRequestHeaderImageBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateSignupFormListsRequestHeaderImageBorderStyle value,
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
        public const string None = "none";

        public const string Solid = "solid";

        public const string Dotted = "dotted";

        public const string Dashed = "dashed";

        public const string Double = "double";

        public const string Groove = "groove";

        public const string Outset = "outset";

        public const string Inset = "inset";

        public const string Ridge = "ridge";
    }
}
