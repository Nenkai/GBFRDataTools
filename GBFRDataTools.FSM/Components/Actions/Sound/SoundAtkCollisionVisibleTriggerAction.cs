using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class SoundAtkCollisionVisibleTriggerAction : SoundAutoActionBase
{
    [JsonPropertyName("isBeginSeqCallSE_")]
    public bool IsBeginSeqCallSE { get; set; } = true;

    /* Redeclaration?
    [JsonPropertyName("coolTime_")]
    public float CoolTime { get; set; }
    */

    [JsonPropertyName("limitCount_")]
    public int LimitCount { get; set; } = 1;

    [JsonPropertyName("addTime_")]
    public float AddTime { get; set; } = 0.0f;

    [JsonPropertyName("oldTime_")]
    public float OldTime { get; set; } = 0.0f;

    [JsonPropertyName("isFirstEnable_")]
    public bool IsFirstEnable { get; set; }
}