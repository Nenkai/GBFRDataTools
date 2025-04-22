using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities;

public class GenericEntitySerializer
{
    public static List<object> Parse(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        var list = new List<object>();

        JsonDocument doc = JsonDocument.Parse(text);

        foreach (var elem in doc.RootElement.EnumerateObject())
        {
            switch (elem.Name)
            {
                case "Em0051Param":
                case "Em00e0Param":
                case "Em00e2Param":
                case "Em00f5Param":
                case "Em0120Param":
                case "Em0140Param":
                case "Em0150Param":
                case "Em0160Param":
                case "Em0510Param":
                case "Em1400Param":
                case "Em7402Param":
                case "Em7403Param":
                case "Em7405Param":
                case "Em7410Param":
                case "Em7502Param":
                    throw new NotSupportedException($"Reflection component '{elem.Name}' not supported (not supported by the game either)");
            }

            if (!ReflectionTypeList.ReflectedTypeMap.TryGetValue(elem.Name, out Type componentType))
            {
                throw new NotSupportedException($"Reflection component '{elem.Name}' not supported");
            }

            object component = (object)elem.Value.Deserialize(componentType, DefaultJsonSerializerOptions.InstanceForRead);
            list.Add(component);
        }

        return list;
    }

    public static void Serialize(Stream stream, IEnumerable<object> objects)
    {
        Utf8JsonWriter writer = new Utf8JsonWriter(stream, new JsonWriterOptions()
        {
            Indented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping, // Makes strings not escaped
        });

        writer.WriteStartObject();

        foreach (var obj in objects)
        {
            writer.WritePropertyName(obj.GetType().Name);
            JsonSerializer.Serialize(writer, obj, obj.GetType(), DefaultJsonSerializerOptions.InstanceForWrite);
        }

        writer.WriteEndObject();
        writer.Flush();
    }
}
