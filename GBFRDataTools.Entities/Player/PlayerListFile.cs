using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class PlayerListFile
{
    public PlayerListData PlayerListData { get; set; }

    public static PlayerListFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        JsonDocument doc = JsonDocument.Parse(text);

        var file = new PlayerListFile();

        foreach (var elem in doc.RootElement.GetProperty(nameof(PlayerListData)).EnumerateObject())
        {
            if (elem.NameEquals("ID"))
            {
                uint id = elem.Value.ValueKind == JsonValueKind.String ? uint.Parse(elem.Value.GetString()) : elem.Value.GetUInt32();
                file.PlayerListData.IDs.Add(id);
            }
        }

        return file;
    }
}

public class PlayerListData
{
    public List<uint> IDs { get; set; } = [];
}
