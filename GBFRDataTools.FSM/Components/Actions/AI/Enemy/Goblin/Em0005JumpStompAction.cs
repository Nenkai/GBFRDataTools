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
    public float TurnRate { get; set; } = 0.05f; // Offset 0xD8

    [JsonPropertyName("disableCheckGroundTimer_")]
    public float DisableCheckGroundTimer { get; set; } = 0.8f; // Offset 0xDC

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.25f; // Offset 0xE0

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 3f; // Offset 0xE4

    [JsonPropertyName("movementDist_")]
    public float MovementDist { get; set; } = 20f; // Offset 0xE8

    [JsonPropertyName("isComboAttack_")]
    public bool IsComboAttack { get; set; } = false; // Offset 0xEC

    [JsonPropertyName("isBreakShield_")]
    public bool IsBreakShield { get; set; } = false; // Offset 0xED

    [JsonPropertyName("gravityRateOD_")]
    public float GravityRateOD { get; set; } = 3f; // Offset 0xF0

    [JsonPropertyName("isCountUp_")]
    public bool IsCountUp { get; set; } = false; // Offset 0xF4

    [JsonPropertyName("maxTargetDist_")]
    public float MaxTargetDist { get; set; } = 15f; // Offset 0xF8

    [JsonPropertyName("isChangeFinishMotion_")]
    public bool IsChangeFinishMotion { get; set; } = false; // Offset 0xFC

    public Em0005JumpStompAction()
    {
    }
}