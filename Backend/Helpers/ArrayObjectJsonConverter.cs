using System.Text.Json;
using System.Text.Json.Serialization;

namespace backend.Helpers;

public class ArrayObjectJsonConverter<T> : JsonConverter<IEnumerable<T>>
{
    public override IEnumerable<T>? Read(ref Utf8JsonReader reader,
        Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.StartArray:
                return JsonSerializer.Deserialize<List<T>>(ref reader, options);
            case JsonTokenType.StartObject:
            {
                var singleItem = JsonSerializer.Deserialize<T>(ref reader, options);
                if (singleItem != null) return new List<T> { singleItem };
                break;
            }
        }

        return reader.TokenType == JsonTokenType.Null
            ? null
            : throw new JsonException($"Unexpected token {reader.TokenType} when expecting an Enumerable.");
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<T>? value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
            return;
        }

        var list = value.ToList();

        if (list.Count == 1)
        {
            JsonSerializer.Serialize(writer, list[0], options);
        }
        else
        {
            JsonSerializer.Serialize(writer, list, options);
        }
    }
}