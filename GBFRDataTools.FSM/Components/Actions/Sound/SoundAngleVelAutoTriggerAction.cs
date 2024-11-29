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
    public int LimitCount { get; set; } = 0;

    [JsonPropertyName("chasePartsNoCenter_")]
    public int ChasePartsNoCenter { get; set; } = -1;

    [JsonPropertyName("chasePartsNo0_")]
    public int ChasePartsNo0 { get; set; } = -1;

    [JsonPropertyName("chasePartsNo1_")]
    public int ChasePartsNo1 { get; set; } = -1;

    [JsonPropertyName("useSocketCenter_")]
    public bool UseSocketCenter { get; set; } = false;

    [JsonPropertyName("useSocketNo0_")]
    public bool UseSocketNo0 { get; set; } = false;

    [JsonPropertyName("useSocketNo1_")]
    public bool UseSocketNo1 { get; set; } = false;

    [JsonPropertyName("stopAngle_")]
    public float StopAngle { get; set; } = 0.01f;

    [JsonPropertyName("moveAngle_")]
    public float MoveAngle { get; set; } = 0.5f;

    [JsonPropertyName("isMoveTrigger_")]
    public bool IsMoveTrigger { get; set; } = true;

    [JsonPropertyName("gameParamName_")]
    public string GameParamName { get; set; } = string.Empty;
}