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
    public int TargetDistance { get; set; } = 0; 

    [JsonPropertyName("nearDist_")]
    public float NearDist { get; set; } = 15f; 

    [JsonPropertyName("frontAngle_")]
    public float FrontAngle { get; set; } = 60f; 

    [JsonPropertyName("isAttackAction_")]
    public bool IsAttackAction { get; set; } = false; 

    [JsonPropertyName("isCheckFront_")]
    public bool IsCheckFront { get; set; } = true; 

    [JsonPropertyName("isCheckLeft_")]
    public bool IsCheckLeft { get; set; } = true; 

    [JsonPropertyName("isCheckRight_")]
    public bool IsCheckRight { get; set; } = true; 

    [JsonPropertyName("isCheckBack_")]
    public bool IsCheckBack { get; set; } = true; 

    [JsonPropertyName("isCancelStepMotion_")]
    public bool IsCancelStepMotion { get; set; } = false; 

    public Em1700PositioningAction()
    {
    }
}
