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

public class GuiColorConverter : JsonConverter<GuiColor>
{
    public override GuiColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        int idx = 0;
        GuiColor color = new();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                if (idx != 5)
                    throw new JsonException();

                break;
            }

            if (reader.TokenType != JsonTokenType.Number && reader.TokenType != JsonTokenType.String)
                throw new JsonException();

            bool parseAsString = reader.TokenType == JsonTokenType.String && options.NumberHandling == JsonNumberHandling.AllowReadingFromString; 
            if (idx == 0)
                color.R = parseAsString ? float.Parse(reader.GetString()) : reader.GetSingle();
            else if (idx == 1)
                color.G = parseAsString ? float.Parse(reader.GetString()) : reader.GetSingle();
            else if (idx == 2)
                color.B = parseAsString ? float.Parse(reader.GetString()) : reader.GetSingle();
            else if (idx == 3)
                color.A = parseAsString ? float.Parse(reader.GetString()) : reader.GetSingle();
            else if (idx == 4)
                color.Unk = parseAsString ? uint.Parse(reader.GetString()) : reader.GetUInt32();
            idx++;
        }

        return color;
    }

    public override void Write(Utf8JsonWriter writer, GuiColor value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
