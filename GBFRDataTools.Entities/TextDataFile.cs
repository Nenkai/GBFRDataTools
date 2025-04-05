
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities;

public class TextDataFile
{
    [JsonPropertyName("rows_")]
    public List<TextData> Rows { get; set; } = [];

    public static TextDataFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        JsonDocument doc = JsonDocument.Parse(text);

        var file = new TextDataFile();

        foreach (var elem in doc.RootElement.GetProperty("rows_").EnumerateArray())
        {
            var column = elem.GetProperty("column_");
            TextData textData = column.Deserialize<TextData>(DefaultJsonSerializerOptions.InstanceForRead);
            file.Rows.Add(textData);
        }

        return file;
    }
}

public class TextData
{
    [JsonPropertyName("text_")]
    public string Text { get; set; }

    [JsonPropertyName("subid_hash_")]
    public string Subid_hash { get; set; }

    [JsonPropertyName("id_hash_")]
    public string Id_hash { get; set; }
}
