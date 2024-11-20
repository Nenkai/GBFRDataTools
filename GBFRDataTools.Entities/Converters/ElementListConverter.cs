using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections;
namespace GBFRDataTools.Entities.Converters;
using System.ComponentModel;

public class ElementListConverter : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsGenericType)
        {
            return false;
        }

        if (typeToConvert.GetGenericTypeDefinition() != typeof(BindingList<>))
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

        JsonConverter converter = (JsonConverter)Activator.CreateInstance(
            typeof(ListConverterInner<>).MakeGenericType([keyType]),
            BindingFlags.Instance | BindingFlags.Public,
            binder: null,
            args: [options],
            culture: null)!;

        return converter;
    }

    private class ListConverterInner<TValue> : JsonConverter<BindingList<TValue>>
    {
        private readonly JsonConverter<TValue> _valueConverter;
        private readonly Type _valueType;

        public ListConverterInner(JsonSerializerOptions options)
        {
            // For performance, use the existing converter.
            _valueConverter = (JsonConverter<TValue>)options
                .GetConverter(typeof(TValue));
            _valueType = typeof(TValue);
        }

        public override BindingList<TValue> Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            var elementList = new BindingList<TValue>();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                {
                    return elementList;
                }

                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    reader.Read();
                    if (reader.TokenType == JsonTokenType.PropertyName)
                    {
                        string propName = reader.GetString();
                        if (propName != "Element")
                            throw new JsonException($"Expected 'Element' for ElementList, got '{propName}'");

                        reader.Read();
                        TValue value = _valueConverter.Read(ref reader, _valueType, options)!;
                        elementList.Add(value);

                        reader.Read();
                    }
                    else
                        throw new JsonException();
                }
                else
                    throw new JsonException();
            }

            throw new JsonException();
        }

        public override void Write(
            Utf8JsonWriter writer,
            BindingList<TValue> elemArray,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            foreach (var element in elemArray)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("Element");
                _valueConverter.Write(writer, element, options);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();
        }
    }
}
