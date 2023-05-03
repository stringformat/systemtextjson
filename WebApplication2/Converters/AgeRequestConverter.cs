using System.Text.Json;
using System.Text.Json.Serialization;
using WebApplication2.Requests;

namespace WebApplication2.Converters;

public class AgeRequestConverter : JsonConverter<AgeRequest>
{
    public override AgeRequest Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        return new(reader.GetInt32());
    }

    public override void Write(
        Utf8JsonWriter writer,
        AgeRequest value,
        JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}