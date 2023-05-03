using System.Text.Json;
using System.Text.Json.Serialization;
using WebApplication2.Converters;
using WebApplication2.Domain;

namespace WebApplication2.Requests;

[JsonConverter(typeof(AgeRequestConverter))]
public record AgeRequest
{
    public AgeRequest(
        int value)
    {
        if (value > 150)
            throw new JsonException("Age non valide");

        Value = value;
    }

    public int Value { get; }

    public Age ToDomain() => new(Value);
}