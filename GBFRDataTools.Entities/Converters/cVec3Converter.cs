﻿using System;
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
public class cVec3Converter : JsonConverter<Vector3>
{
    public override Vector3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        int idx = 0;
        Vector3 vec = new();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                if (idx != 3)
                    throw new JsonException();

                break;
            }

            if (reader.TokenType != JsonTokenType.Number)
                throw new JsonException();

            if (idx == 0)
                vec.X = reader.GetSingle();
            else if (idx == 1)
                vec.Y = reader.GetSingle();
            else if (idx == 2)
                vec.Z = reader.GetSingle();
            idx++;
        }

        return vec;
    }

    public override void Write(Utf8JsonWriter writer, Vector3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.X);
        writer.WriteNumberValue(value.Y);
        writer.WriteNumberValue(value.Z);
        writer.WriteEndArray();
    }
}
