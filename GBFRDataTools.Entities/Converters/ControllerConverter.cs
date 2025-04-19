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

public class ControllerConverter : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsGenericType)
        {
            return false;
        }

        if (typeToConvert.GetGenericTypeDefinition() != typeof(Controllers<>))
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
            typeof(ControllerConverterInner<>).MakeGenericType([keyType]),
            BindingFlags.Instance | BindingFlags.Public,
            binder: null,
            args: [options],
            culture: null)!;

        return converter;
    }

    private class ControllerConverterInner<TValue> : JsonConverter<Controllers<TValue>>
    {
        private readonly JsonConverter<TValue> _valueConverter;
        private readonly Type _valueType;

        public ControllerConverterInner(JsonSerializerOptions options)
        {
            // For performance, use the existing converter.
            _valueConverter = (JsonConverter<TValue>)options
                .GetConverter(typeof(TValue));
            _valueType = typeof(TValue);
        }

        public override Controllers<TValue> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();
            reader.Read();

            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException();

            string propName = reader.GetString();
            if (propName != "count")
                throw new JsonException();
            reader.Read();

            Controllers<TValue> controllers = new();

            int count = reader.GetInt32();
            reader.Read();

            for (int i = 0; i < count; i++)
            {
                if (reader.GetString() != $"detail{i + 1}")
                    throw new JsonException();

                reader.Read();

                if (reader.TokenType != JsonTokenType.StartObject)
                    throw new JsonException();

                TValue value = _valueConverter.Read(ref reader, _valueType, options)!;
                controllers.Elements.Add(value);

                if (reader.TokenType != JsonTokenType.EndObject)
                    throw new JsonException();
                reader.Read();
            }

            if (reader.TokenType != JsonTokenType.EndObject)
                throw new JsonException();

            return controllers;
        }

        public override void Write(Utf8JsonWriter writer, Controllers<TValue> controller, JsonSerializerOptions options)
        {
            throw new NotImplementedException("Controller json serialization is not yet supported");
        }
    }

}

