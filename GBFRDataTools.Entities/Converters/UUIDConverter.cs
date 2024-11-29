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

namespace GBFRDataTools.Entities.Converters;

public class UUIDConverter : JsonConverter<UUID>
{
    public override UUID Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        int idx = 0;
        UUID vec = new();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                if (idx != 2)
                    throw new JsonException();

                break;
            }

            if (reader.TokenType != JsonTokenType.Number)
                throw new JsonException();

            if (idx == 0)
                vec.Unk1 = reader.GetUInt64();
            else if (idx == 1)
                vec.Unk2 = reader.GetUInt64();

            idx++;
        }

        return vec;
    }

    public override void Write(Utf8JsonWriter writer, UUID value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
