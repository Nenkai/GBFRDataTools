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

public class GuiImportableCurveConverter : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsGenericType)
        {
            return false;
        }

        if (typeToConvert.GetGenericTypeDefinition() != typeof(GuiImportableCurve<>))
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

    private class ListConverterInner<TValue> : JsonConverter<GuiImportableCurve<TValue>>
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

        public override GuiImportableCurve<TValue> Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();
            reader.Read();

            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException();

            var curve = new GuiImportableCurve<TValue>();

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                string propName = reader.GetString();
                switch (propName)
                {
                    case "CurveFile":
                        reader.Read();

                        curve.CurveFile = reader.GetString();
                        reader.Read();
                        break;

                    case "Params":
                        reader.Read();
                        if (reader.TokenType != JsonTokenType.StartArray)
                            throw new JsonException();

                        while (reader.Read())
                        {
                            if (reader.TokenType == JsonTokenType.EndArray)
                            {
                                break;
                            }

                            TValue value = _valueConverter.Read(ref reader, _valueType, options)!;
                            curve.Add(value);
                        }
                        reader.Read();
                        break;
                }
            }

            return curve;
        }

        public override void Write(
            Utf8JsonWriter writer,
            GuiImportableCurve<TValue> elemArray,
            JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteStartObject();
            {
                writer.WritePropertyName("Params");
                writer.WriteStartArray();

                foreach (var element in elemArray.Params)
                    _valueConverter.Write(writer, element, options);
                writer.WriteEndObject();
            }

            writer.WriteString("CurveFile", elemArray.CurveFile);
        }
    }
}
