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
using System.Numerics;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Converters;

public class ManipulatableMatrixConverter : JsonConverter<Matrix4x4>
{
    public override Matrix4x4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        int idx = 0;
        Matrix4x4 matrix = new();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                if (idx != 16)
                    throw new JsonException();

                break;
            }

            if (reader.TokenType != JsonTokenType.Number && reader.TokenType != JsonTokenType.String)
                throw new JsonException();

            bool parseAsString = reader.TokenType == JsonTokenType.String && options.NumberHandling == JsonNumberHandling.AllowReadingFromString; 
            float val = parseAsString ? float.Parse(reader.GetString()) : reader.GetSingle();
            matrix[idx / 4, idx % 4] = val;
            idx++;
        }

        return matrix;
    }

    public override void Write(Utf8JsonWriter writer, Matrix4x4 value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
