using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Scene.Objects;

using MessagePack;

namespace GBFRDataTools.Entities.Scene;

public class SceneHierarchyFile
{
    [JsonPropertyName(nameof(SceneHierarchy))]
    public SceneHierarchy SceneHierarchy { get; set; }

    public static SceneHierarchyFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        SceneHierarchyFile file = JsonSerializer.Deserialize<SceneHierarchyFile>(text, DefaultJsonSerializerOptions.Instance);
        return file;
    }
}