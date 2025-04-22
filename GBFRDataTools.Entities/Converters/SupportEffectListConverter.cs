using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace GBFRDataTools.Entities.Converters;

using GBFRDataTools.Entities.Player;

using System.ComponentModel;

public class SupportEffectListConverter : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsGenericType)
        {
            return false;
        }

        if (typeToConvert.GetGenericTypeDefinition() != typeof(BindingList<>) || 
            typeToConvert.GenericTypeArguments[0] != typeof(ActionInfo.SupportEffect))
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

    private class ListConverterInner<TValue> : JsonConverter<BindingList<ActionInfo.SupportEffect>>
    {
        public ListConverterInner(JsonSerializerOptions options)
        {

        }

        public override BindingList<ActionInfo.SupportEffect> Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            var elementList = new BindingList<ActionInfo.SupportEffect>();

            reader.Read();

            int numElements = reader.TokenType == JsonTokenType.String ? int.Parse(reader.GetString()) : reader.GetInt32();
            reader.Read();

            for (int elem = 0; elem < numElements; elem++)
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    break;

                var effect = new ActionInfo.SupportEffect();
                for (int i = 0; i < 7; i++)
                {
                    switch (i)
                    {
                        case 0:
                            effect.Hash = reader.TokenType == JsonTokenType.String ? uint.Parse(reader.GetString()) : reader.GetUInt32();
                            break;

                        case 1:
                            effect.Value1 = reader.TokenType == JsonTokenType.String ? float.Parse(reader.GetString()) : reader.GetSingle(); break;
                        case 2:
                            effect.Value2 = reader.TokenType == JsonTokenType.String ? float.Parse(reader.GetString()) : reader.GetSingle(); break;
                        case 3:
                            effect.Value3 = reader.TokenType == JsonTokenType.String ? float.Parse(reader.GetString()) : reader.GetSingle(); break;
                        case 4:
                            effect.Value4 = reader.TokenType == JsonTokenType.String ? float.Parse(reader.GetString()) : reader.GetSingle(); break;
                        case 5:
                            effect.Value5 = reader.TokenType == JsonTokenType.String ? float.Parse(reader.GetString()) : reader.GetSingle(); break;
                        case 6:
                            effect.Value6 = reader.TokenType == JsonTokenType.String ? float.Parse(reader.GetString()) : reader.GetSingle(); break;
                    }
                    reader.Read();
                }

                elementList.Add(effect);
                
            }

            if (reader.TokenType != JsonTokenType.EndArray)
                throw new JsonException();

            if (elementList.Count != numElements)
                throw new JsonException($"Inline array element count does not match number of elements present in array (num elements: {numElements}, in list: {elementList.Count})");

            return elementList;
        }

        public override void Write(
            Utf8JsonWriter writer,
            BindingList<ActionInfo.SupportEffect> elemArray,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteNumberValue(elemArray.Count);

            foreach (ActionInfo.SupportEffect effect in elemArray)
            {
                writer.WriteNumberValue(effect.Hash);
                writer.WriteNumberValue(effect.Value1);
                writer.WriteNumberValue(effect.Value2);
                writer.WriteNumberValue(effect.Value3);
                writer.WriteNumberValue(effect.Value4);
                writer.WriteNumberValue(effect.Value5);
                writer.WriteNumberValue(effect.Value6);
            }

            writer.WriteEndArray();
        }
    }
}
