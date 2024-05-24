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

public class PadVibrationAction : QuestActionComponent
{
    [JsonPropertyName("isPosSet_")]
    public bool IsPosSet { get; set; }

    [JsonPropertyName("pos_")]
    public cVec4 Pos { get; set; }

    [JsonPropertyName("leftStart_")]
    public float LeftStart { get; set; }

    [JsonPropertyName("leftEnd_")]
    public float LeftEnd { get; set; }

    [JsonPropertyName("rightStart_")]
    public float RightStart { get; set; }

    [JsonPropertyName("rightEnd_")]
    public float RightEnd { get; set; }

    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("isTargetSet_")]
    public bool IsTargetSet { get; set; }

    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; }

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; }

    [JsonPropertyName("noAttenuation_")]
    public bool NoAttenuation { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
