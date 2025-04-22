using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using GBFRDataTools.Entities.Scene;

namespace GBFRDataTools.Entities.Converters;

public class ObjectTypeListConverter : JsonConverterFactory
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

        private Dictionary<string, Type> ObjectNameToType { get; } = [];
        public ListConverterInner(JsonSerializerOptions options)
        {
            // For performance, use the existing converter.
            _valueConverter = (JsonConverter<TValue>)options
                .GetConverter(typeof(TValue));

            foreach (Type type in Assembly.GetAssembly(typeof(ObjectTypeListConverter)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(ISceneObject))))
            {
                ObjectNameToType.TryAdd(type.Name, type);
            }
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
                        string className = reader.GetString();

                        reader.Read();

                        if (!ObjectNameToType.TryGetValue(className, out Type type))
                            throw new JsonException($"Cannot deserialize struct '{className}', not supported/defined.");

                        TValue value = _valueConverter.Read(ref reader, type, options)!;
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

        // UNTESTED
        public override void Write(
            Utf8JsonWriter writer,
            BindingList<TValue> elemArray,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            foreach (var value in elemArray)
            {
                writer.WriteStartObject();
                writer.WritePropertyName(typeof(TValue).Name);
                _valueConverter.Write(writer, value, options);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();
        }
    }
}
