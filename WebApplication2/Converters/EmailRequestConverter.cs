using System.Text.Json;
using System.Text.Json.Serialization;
using WebApplication2.Requests;

namespace WebApplication2.Converters;

public class EmailRequestConverter : JsonConverter<EmailRequest>
{
    public override EmailRequest Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        var value = reader.GetString();
        
        if (value is null)
            throw new JsonException("Null est invalide !");
        
        return new(reader.GetString());
    }

    public override void Write(
        Utf8JsonWriter writer,
        EmailRequest value,
        JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}