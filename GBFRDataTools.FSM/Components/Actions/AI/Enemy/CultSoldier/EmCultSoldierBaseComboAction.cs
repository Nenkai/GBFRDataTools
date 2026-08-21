using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class EmCultSoldierBaseComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCultSoldierBaseComboAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f; 

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; 

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } 

    [JsonPropertyName("permissionNoHitProbability_")]
    public int PermissionNoHitProbability { get; set; } = 0; 

    [JsonPropertyName("permissionNoHitDist_")]
    public float PermissionNoHitDist { get; set; } = 0f; 

    [JsonPropertyName("permissionNoHitAngleDeg_")]
    public float PermissionNoHitAngleDeg { get; set; } = 190f; 

    [JsonPropertyName("startMotionTime_")]
    public float StartMotionTime { get; set; } = 0f; 

    [JsonPropertyName("movementRateOnFlag_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public int MovementRateOnFlag { get; set; }
}