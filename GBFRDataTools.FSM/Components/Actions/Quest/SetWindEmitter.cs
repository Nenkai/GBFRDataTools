using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetWindEmitter : QuestActionComponent
{
    [JsonPropertyName("settingType_")]
    public SetWindEmitterSettingType SettingType { get; set; }

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
}

public enum SetWindEmitterSettingType : ulong
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
}
