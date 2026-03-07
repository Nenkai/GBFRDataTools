using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700PositioningAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700PositioningAction);

    [JsonPropertyName("targetDistance_")]
    public int TargetDistance { get; set; } = 0; // Offset 0x34

    [JsonPropertyName("nearDist_")]
    public float NearDist { get; set; } = 15f; // Offset 0x38

    [JsonPropertyName("frontAngle_")]
    public float FrontAngle { get; set; } = 60f; // Offset 0x3C

    [JsonPropertyName("isAttackAction_")]
    public bool IsAttackAction { get; set; } = false; // Offset 0x40

    [JsonPropertyName("isCheckFront_")]
    public bool IsCheckFront { get; set; } = true; // Offset 0x41

    [JsonPropertyName("isCheckLeft_")]
    public bool IsCheckLeft { get; set; } = true; // Offset 0x42

    [JsonPropertyName("isCheckRight_")]
    public bool IsCheckRight { get; set; } = true; // Offset 0x43

    [JsonPropertyName("isCheckBack_")]
    public bool IsCheckBack { get; set; } = true; // Offset 0x44

    [JsonPropertyName("isCancelStepMotion_")]
    public bool IsCancelStepMotion { get; set; } = false; // Offset 0x45

    public Em1700PositioningAction()
    {
    }
}
