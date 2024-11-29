using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class BehaviorCallPadVibration : ActionComponent
{
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

    [JsonPropertyName("vibTime_")]
    public float VibTime { get; set; } = 0.5f;

    [JsonPropertyName("vibLayer_")]
    public int VibLayer { get; set; } = 0;
}
