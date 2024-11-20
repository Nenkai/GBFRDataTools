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

public class SceneObjectNameConverter : JsonConverter<SceneObjectName>
{
    public override SceneObjectName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        int idx = 0;
        SceneObjectName vec = new SceneObjectName();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                if (idx != 2)
                    throw new JsonException();

                break;
            }

            if (idx == 0)
                vec.NameStr = reader.GetString();
            else if (idx == 1)
                vec.NameStrHash = reader.GetUInt32();

            idx++;
        }

        return vec;
    }

    public override void Write(Utf8JsonWriter writer, SceneObjectName value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
