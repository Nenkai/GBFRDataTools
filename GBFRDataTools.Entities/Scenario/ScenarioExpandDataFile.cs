using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Scenario;

public class ScenarioExpandDataFile
{
    [JsonPropertyName("rows_")]
    public List<ScenarioExpandData> Rows { get; set; } = [];

    public static ScenarioExpandDataFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        JsonDocument doc = JsonDocument.Parse(text);

        var file = new ScenarioExpandDataFile();

        foreach (var elem in doc.RootElement.GetProperty("rows_").EnumerateArray())
        {
            var column = elem.GetProperty("column_");
            ScenarioExpandData scenarioData = JsonSerializer.Deserialize<ScenarioExpandData>(column, DefaultJsonSerializerOptions.Instance);
            file.Rows.Add(scenarioData);
        }

        return file;
    }
}

public class ScenarioExpandData
{
    [JsonPropertyName("id_hash_")]
    public string Id_hash { get; set; }

    [JsonPropertyName("scenarioClear_")]
    public bool ScenarioClear { get; set; }
}
