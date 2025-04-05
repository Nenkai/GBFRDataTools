using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class SoundOneVelAutoTriggerAction : SoundAutoActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundOneVelAutoTriggerAction);

    [JsonPropertyName("chasePartsNo_")]
    public int ChasePartsNo { get; set; } = -1;

    [JsonPropertyName("useSocket_")]
    public bool UseSocket { get; set; } = false;

    [JsonPropertyName("useHeight_")]
    public bool UseHeight { get; set; } = false;

    // THIS IS NOT READ BY RELINK 1.3.2
    [JsonPropertyName("useLocal_")]
    public bool UseLocal { get; set; }

    [JsonPropertyName("stopVel_")]
    public float StopVel { get; set; } = 0.01f;

    [JsonPropertyName("moveVel_")]
    public float MoveVel { get; set; } = 0.05f;

    [JsonPropertyName("groundHeight_")]
    public float GroundHeight { get; set; } = 0.03f;

    [JsonPropertyName("raiseHeight_")]
    public float RaiseHeight { get; set; } = 0.3f;

    [JsonPropertyName("limitCount_")]
    public int LimitCount { get; set; } = 0;

    [JsonPropertyName("oneVelCoolTime_")]
    public float OneVelCoolTime { get; set; } = 0.0f;

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0.0f;

    [JsonPropertyName("isMoveTrigger_")]
    public bool IsMoveTrigger { get; set; } = true;

    [JsonPropertyName("isStartTrigger_")]
    public bool IsStartTrigger { get; set; } = false;

    [JsonPropertyName("gameParamName_")]
    public string GameParamName { get; set; } = string.Empty;

    [JsonPropertyName("weaponId_")]
    public int WeaponId { get; set; } = -1;

}