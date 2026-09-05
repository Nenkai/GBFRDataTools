using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Converters;

public class UIntEnumConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsEnum)
        {
            return false;
        }

        return Enum.GetUnderlyingType(typeToConvert) == typeof(uint);
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        Type converterType = typeof(UIntEnumConverterInner<>).MakeGenericType(typeToConvert);
        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }

    private class UIntEnumConverterInner<TEnum> : JsonConverter<TEnum>
        where TEnum : struct, Enum
    {
        public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String && options.NumberHandling.HasFlag(JsonNumberHandling.AllowReadingFromString))
            {
                if (!long.TryParse(reader.GetString(), out long raw_))
                    throw new JsonException();

                return (TEnum)Enum.ToObject(typeToConvert, unchecked((uint)raw_));   
            }

            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException(
                    $"Expected a number token for enum '{typeToConvert.Name}', got '{reader.TokenType}'.");
            }

            // Make it work for positive and negative by making it uint
            if (!reader.TryGetInt64(out long raw))
            {
                throw new JsonException(
                    $"Could not read numeric value for enum '{typeToConvert.Name}'.");
            }

            uint bits = unchecked((uint)raw);
            return (TEnum)Enum.ToObject(typeToConvert, bits);
        }

        public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
        {
            uint bits = Convert.ToUInt32(value);
            writer.WriteNumberValue(bits);
        }
    }
}
