using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class BehaviorCallPadVibration : ActionComponent
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

    [JsonPropertyName("vibTime_")]
    public float VibTime { get; set; }

    [JsonPropertyName("vibLayer_")]
    public int VibLayer { get; set; }
}
