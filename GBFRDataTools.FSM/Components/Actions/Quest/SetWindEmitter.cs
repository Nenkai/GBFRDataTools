using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetWindEmitter : QuestActionComponent
{
    [JsonPropertyName("settingType_")]
    public ulong SettingType { get; set; }

    [JsonPropertyName("id_")]
    public ulong Id { get; set; }

    [JsonPropertyName("pos_")]
    public cVec4 Pos { get; set; }

    [JsonPropertyName("range_")]
    public cVec4 Range { get; set; }

    [JsonPropertyName("dir_")]
    public cVec4 Dir { get; set; }

    [JsonPropertyName("speed_")]
    public float Speed { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
