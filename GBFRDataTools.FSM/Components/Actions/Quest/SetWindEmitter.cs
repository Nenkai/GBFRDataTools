using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetWindEmitter : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetWindEmitter);

    [JsonPropertyName("settingType_")]
    public SetWindEmitterSettingType SettingType { get; set; } = SetWindEmitterSettingType.Type0;

    [JsonPropertyName("id_")]
    public ulong Id { get; set; }

    [JsonPropertyName("pos_")]
    public /* cVec4 */ Vector4 Pos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("range_")]
    public /* cVec4 */ Vector4 Range { get; set; } = Vector4.One;

    [JsonPropertyName("dir_")]
    public /* cVec4 */ Vector4 Dir { get; set; } = Vector4.One;

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } = 1.0f;
}

public enum SetWindEmitterSettingType : ulong
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
}
