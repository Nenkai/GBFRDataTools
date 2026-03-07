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

public class UShortWithStringConverter : JsonConverter<ushort>
{
    public override ushort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String && options.NumberHandling.HasFlag(JsonNumberHandling.AllowReadingFromString))
        {
            if (!ushort.TryParse(reader.GetString(), out ushort result))
                throw new JsonException();

            return result;
        }

        return reader.GetUInt16();
    }

    public override void Write(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value);
    }
}
