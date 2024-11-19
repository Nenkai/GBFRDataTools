using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class SoundOneVelAutoTriggerAction : SoundAutoActionBase
{
    [JsonPropertyName("chasePartsNo_")]
    public int ChasePartsNo { get; set; }

    [JsonPropertyName("useSocket_")]
    public bool UseSocket { get; set; }

    [JsonPropertyName("useHeight_")]
    public bool UseHeight { get; set; }

    // THIS IS NOT READ BY RELINK 1.3.2
    [JsonPropertyName("useLocal_")]
    public bool UseLocal { get; set; }

    [JsonPropertyName("stopVel_")]
    public float StopVel { get; set; }

    [JsonPropertyName("moveVel_")]
    public float MoveVel { get; set; }

    [JsonPropertyName("groundHeight_")]
    public float GroundHeight { get; set; }

    [JsonPropertyName("raiseHeight_")]
    public float RaiseHeight { get; set; }

    [JsonPropertyName("limitCount_")]
    public int LimitCount { get; set; }

    [JsonPropertyName("oneVelCoolTime_")]
    public float OneVelCoolTime { get; set; }

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; }

    [JsonPropertyName("isMoveTrigger_")]
    public bool IsMoveTrigger { get; set; }

    [JsonPropertyName("isStartTrigger_")]
    public bool IsStartTrigger { get; set; }

    [JsonPropertyName("gameParamName_")]
    public string GameParamName { get; set; }

    [JsonPropertyName("weaponId_")]
    public int WeaponId { get; set; }

}