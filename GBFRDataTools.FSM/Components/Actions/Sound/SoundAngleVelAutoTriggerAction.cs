using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class SoundAngleVelAutoTriggerAction : SoundAutoActionBase
{
    [JsonPropertyName("limitCount_")]
    public int LimitCount { get; set; }

    [JsonPropertyName("chasePartsNoCenter_")]
    public int ChasePartsNoCenter { get; set; }

    [JsonPropertyName("chasePartsNo0_")]
    public int ChasePartsNo0 { get; set; }

    [JsonPropertyName("chasePartsNo1_")]
    public int ChasePartsNo1 { get; set; }

    [JsonPropertyName("useSocketCenter_")]
    public bool UseSocketCenter { get; set; }

    [JsonPropertyName("useSocketNo0_")]
    public bool UseSocketNo0 { get; set; }

    [JsonPropertyName("useSocketNo1_")]
    public bool UseSocketNo1 { get; set; }

    [JsonPropertyName("stopAngle_")]
    public float StopAngle { get; set; }

    [JsonPropertyName("moveAngle_")]
    public float MoveAngle { get; set; }

    [JsonPropertyName("isMoveTrigger_")]
    public bool IsMoveTrigger { get; set; }

    [JsonPropertyName("gameParamName_")]
    public string GameParamName { get; set; }
}