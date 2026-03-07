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

public class UIntWithStringConverter : JsonConverter<uint>
{
    public override uint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String && options.NumberHandling.HasFlag(JsonNumberHandling.AllowReadingFromString))
        {
            if (!uint.TryParse(reader.GetString(), out uint result))
                throw new JsonException();

            return result;
        }

        return reader.GetUInt32();
    }

    public override void Write(Utf8JsonWriter writer, uint value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value);
    }
}
