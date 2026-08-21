using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005JumpStompAction : Em0005BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005JumpStompAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; 

    [JsonPropertyName("disableCheckGroundTimer_")]
    public float DisableCheckGroundTimer { get; set; } = 0.8f; 

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.25f; 

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 3f; 

    [JsonPropertyName("movementDist_")]
    public float MovementDist { get; set; } = 20f; 

    [JsonPropertyName("isComboAttack_")]
    public bool IsComboAttack { get; set; } = false; 

    [JsonPropertyName("isBreakShield_")]
    public bool IsBreakShield { get; set; } = false; 

    [JsonPropertyName("gravityRateOD_")]
    public float GravityRateOD { get; set; } = 3f; 

    [JsonPropertyName("isCountUp_")]
    public bool IsCountUp { get; set; } = false; 

    [JsonPropertyName("maxTargetDist_")]
    public float MaxTargetDist { get; set; } = 15f; 

    [JsonPropertyName("isChangeFinishMotion_")]
    public bool IsChangeFinishMotion { get; set; } = false; 
}