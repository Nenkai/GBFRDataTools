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

public class SingleWithStringConverter : JsonConverter<float>
{
    public override float Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String && options.NumberHandling.HasFlag(JsonNumberHandling.AllowReadingFromString))
        {
            if (!float.TryParse(reader.GetString(), NumberStyles.Float, CultureInfo.InvariantCulture, out float result))
                throw new JsonException();

            return result;
        }

        return reader.GetSingle();
    }

    public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
