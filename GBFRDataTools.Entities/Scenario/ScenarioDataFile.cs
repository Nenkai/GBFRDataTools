using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Scenario;

public class ScenarioDataFile
{
    [JsonPropertyName("rows_")]
    public List<ScenarioData> ScenarioParam { get; set; } = [];

    public static ScenarioDataFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        JsonDocument doc = JsonDocument.Parse(text);

        var file = new ScenarioDataFile();

        foreach (var elem in doc.RootElement.GetProperty("rows_").EnumerateArray())
        {
            var column = elem.GetProperty("column_");
            ScenarioData scenarioData = JsonSerializer.Deserialize<ScenarioData>(column, DefaultJsonSerializerOptions.Instance);
            file.ScenarioParam.Add(scenarioData);
        }

        return file;
    }
}

public class ScenarioData
{
    [JsonPropertyName("voiceID_")]
    public string VoiceID { get; set; }

    [JsonPropertyName("charaID_")]
    public string CharaID { get; set; }

    [JsonPropertyName("id_hash_")]
    public string Id_hash { get; set; }

    [JsonPropertyName("sentenceID_hash_")]
    public string SentenceID_hash { get; set; }

    [JsonPropertyName("name_hash_")]
    public string Name_hash { get; set; }

    [JsonPropertyName("listener_")]
    public int Listener { get; set; }

    [JsonPropertyName("line_")]
    public int Line { get; set; }

    [JsonPropertyName("emotion_")]
    public int Emotion { get; set; }

    [JsonPropertyName("voiceWaitTime_")]
    public float VoiceWaitTime { get; set; }

    [JsonPropertyName("isContinueTalking_")]
    public bool IsContinueTalking { get; set; }
}
