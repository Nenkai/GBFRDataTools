using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Converters;

using System.ComponentModel;

public class MapConverter : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsGenericType)
        {
            return false;
        }

        if (typeToConvert.GetGenericTypeDefinition() != typeof(Map<,>))
        {
            return false;
        }

        return true;
    }

    public override JsonConverter CreateConverter(
        Type type,
        JsonSerializerOptions options)
    {
        Type[] typeArguments = type.GetGenericArguments();
        Type keyType = typeArguments[0];
        Type valueType = typeArguments[1];
        JsonConverter converter = (JsonConverter)Activator.CreateInstance(
            typeof(MapConverterInner<,>).MakeGenericType([keyType, valueType]),
            BindingFlags.Instance | BindingFlags.Public,
            binder: null,
            args: [options],
            culture: null)!;

        return converter;
    }

    private class MapConverterInner<TKey, TValue> : JsonConverter<Map<TKey, TValue>>
    {
        private readonly JsonConverter<TKey> _keyConverter;
        private readonly Type _keyType;

        private readonly JsonConverter<TValue> _valueConverter;
        private readonly Type _valueType;

        public MapConverterInner(JsonSerializerOptions options)
        {
            // For performance, use the existing converter.
            _keyConverter = (JsonConverter<TKey>)options.GetConverter(typeof(TKey));
            _keyType = typeof(TKey);

            _valueConverter = (JsonConverter<TValue>)options.GetConverter(typeof(TValue));
            _valueType = typeof(TValue);
        }

        public override Map<TKey, TValue> Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();
            reader.Read();

            var map = new Map<TKey, TValue>();

            while (reader.TokenType != JsonTokenType.EndArray)
            {
                if (reader.TokenType != JsonTokenType.StartObject)
                    throw new JsonException();
                reader.Read();

                var elem = new MapElement<TKey, TValue>();

                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    string propName = reader.GetString();
                    switch (propName)
                    {
                        case "Key":
                            reader.Read();

                            elem.Key = _keyConverter.Read(ref reader, _keyType, options)!;
                            reader.Read();
                            break;

                        case "Value":
                            reader.Read();
                            elem.Value = _valueConverter.Read(ref reader, _valueType, options)!;
                            reader.Read();
                            break;
                    }
                }

                map.Elements.Add(elem);
                reader.Read();
            }

            return map;
        }

        public override void Write(
            Utf8JsonWriter writer,
            Map<TKey, TValue> elemArray,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            foreach (var element in elemArray.Elements)
            {
                writer.WriteStartObject();

                writer.WriteStartObject();
                writer.WritePropertyName("Key");
                _keyConverter.Write(writer, element.Key, options);
                writer.WriteEndObject();

                writer.WritePropertyName("Value");
                _valueConverter.Write(writer, element.Value, options);
                writer.WriteEndObject();

                writer.WriteEndObject();
            }
            writer.WriteEndArray();
        }
    }
}
