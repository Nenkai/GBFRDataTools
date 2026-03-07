using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;
using System.IO;

using GBFRDataTools.Entities.Base;
using System.Numerics;

namespace GBFRDataTools.Entities.Converters;

#pragma warning disable IDE1006 // Naming Styles
public class cVec4Converter : JsonConverter<Vector4>
{
    public override Vector4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        int idx = 0;
        Vector4 vec = new();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                if (idx != 4)
                    throw new JsonException();

                break;
            }

            if (reader.TokenType != JsonTokenType.Number && reader.TokenType != JsonTokenType.String)
                throw new JsonException();

            bool parseAsString = reader.TokenType == JsonTokenType.String && options.NumberHandling == JsonNumberHandling.AllowReadingFromString; 
            if (idx == 0)
                vec.X = parseAsString ? float.Parse(reader.GetString()) : reader.GetSingle();
            else if (idx == 1)
                vec.Y = parseAsString ? float.Parse(reader.GetString()) : reader.GetSingle();
            else if (idx == 2)
                vec.Z = parseAsString ? float.Parse(reader.GetString()) : reader.GetSingle();
            else if (idx == 3)
                vec.W = parseAsString ? float.Parse(reader.GetString()) : reader.GetSingle();
            idx++;
        }

        return vec;
    }

    public override void Write(Utf8JsonWriter writer, Vector4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.X);
        writer.WriteNumberValue(value.Y);
        writer.WriteNumberValue(value.Z);
        writer.WriteNumberValue(value.W);
        writer.WriteEndArray();
    }
}
