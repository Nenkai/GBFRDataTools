using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class PadVibrationAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PadVibrationAction);

    [JsonPropertyName("isPosSet_")]
    public bool IsPosSet { get; set; } = false;

    [JsonPropertyName("pos_")]
    public /* cVec4 */ Vector4 Pos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("leftStart_")]
    public float LeftStart { get; set; } = 0.0f;

    [JsonPropertyName("leftEnd_")]
    public float LeftEnd { get; set; } = 0.0f;

    [JsonPropertyName("rightStart_")]
    public float RightStart { get; set; } = 0.0f;

    [JsonPropertyName("rightEnd_")]
    public float RightEnd { get; set; } = 0.0f;

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 1.0f;

    [JsonPropertyName("isTargetSet_")]
    public bool IsTargetSet { get; set; } = false;

    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; } = 0;

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } = 0;

    [JsonPropertyName("noAttenuation_")]
    public bool NoAttenuation { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
