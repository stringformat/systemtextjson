using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using WebApplication2.Converters;
using WebApplication2.Domain;

namespace WebApplication2.Requests;

[JsonConverter(typeof(EmailRequestConverter))]
public record EmailRequest
{
    private static readonly Regex _emailRegex = new(@"^[a-z]+\.[a-z]+@[a-z]+\.fr$",
        RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.Singleline);

    public EmailRequest(
        string value)
    {
        if (!_emailRegex.IsMatch(value))
            throw new JsonException("Mauvais format d'email");

        Value = value;
    }

    public string Value { get; }

    public Email ToDomain() => new(Value);
}