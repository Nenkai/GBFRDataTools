using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using MessagePack;

using GBFRDataTools.Entities.Converters;

namespace GBFRDataTools.Entities.Scenario;

public class ScenarioParamFile
{
    [JsonPropertyName(nameof(ScenarioParam))]
    public ScenarioParamFile ScenarioParam { get; set; }

    public static ScenarioParamFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        ScenarioParamFile paramFile = JsonSerializer.Deserialize<ScenarioParamFile>(text, DefaultJsonSerializerOptions.InstanceForRead);
        return paramFile;
    }
}

public class ScenarioParam
{
    [JsonPropertyName("list_")]
    public ScenarioParamList List { get; set; }
}

public class ScenarioParamList
{
    [JsonPropertyName("scenarioNos_")]
    public BindingList<string> ScenarioNos { get; set; }
}
