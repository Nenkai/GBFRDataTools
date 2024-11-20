using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

using GBFRDataTools.Entities.Converters;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Table;

public class SeriousVoiceCheckDataFile
{
    [JsonPropertyName(nameof(SeriousVoiceCheckData))]
    public SeriousVoiceCheckData SeriousVoiceCheckData { get; set; }

    public static SeriousVoiceCheckDataFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        SeriousVoiceCheckDataFile paramFile = JsonSerializer.Deserialize<SeriousVoiceCheckDataFile>(text, DefaultJsonSerializerOptions.Instance);
        return paramFile;
    }
}

public class SeriousVoiceCheckData
{
    [JsonPropertyName("tables_")]
    public BindingList<TableData> Tables { get; set; }
}

/// <summary>
/// SeriousVoiceCheckData::TableData
/// </summary>
public class TableData
{
    [JsonPropertyName("to_")]
    public string To { get; set; }

    [JsonPropertyName("from_")]
    public string From { get; set; }

    [JsonPropertyName("type_")]
    public string Type { get; set; }
}
